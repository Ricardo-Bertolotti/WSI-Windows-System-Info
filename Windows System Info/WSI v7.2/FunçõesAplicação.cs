using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Net.NetworkInformation;

namespace Windows_System_Info_Funções_Aplicação
{
    public class FunçõesAplicação
    {
        // Variáveis para alocar os resultados dos métodos.
        public string ?númeroDeSérie;
        public string ?chaveDoProduto;
        public string ?endereçoIPv4;
        public string ?endereçoMAC;

        /*public FunçõesAplicação() {}          Construtor não utilizado     */

        public async Task ObterInformaçõesAssincronamente(Control textBox1, Control textBox2, Control textBox3, Control textBox4)
        {
            // Aguarda cada tarefa individualmente e atribui os resultados imediatamente
            await Task.Run(() => ChecarConexãoInternet(textBox3, textBox4));
            chaveDoProduto = await Task.Run(() => ObterChaveDoProduto(textBox2));
            númeroDeSérie = await Task.Run(() => ObterNúmeroDeSérie(textBox1));
        }

        public string ObterNúmeroDeSérie(Control textBox1)
        {
            // Utiliza o comando "wmic bios get serialnumber" no cmd para obter o número de série
            ProcessStartInfo startInfo = new()
            {
                FileName = "wmic",
                Arguments = "bios get serialnumber",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using (Process process = Process.Start(startInfo))
            {
                process.WaitForExit();
                string output = process.StandardOutput.ReadToEnd();

                //Divide o retorno do comando para cada linha obtida, criando um array de strings.
                string[] lines = output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

                // Verifica a 2º linha do retorno do comando, se conter um sequência sem espaços consideramos como um SN válido.
                if (string.IsNullOrWhiteSpace(lines[1]) || lines[1].Trim().Contains(" "))
                {
                    textBox1.ForeColor = Color.Red;                   
                    return "Máquina sem número de série";
                }
                else
                {
                    return lines[1].Trim();
                }
            }
        }

        public string ObterChaveDoProduto(Control textBox2)
        {
            // Utiliza o comando "wmic path softwarelicensingservice get OA3xOriginalProductKey" no cmd para obter a chave Windows do produto.
            ProcessStartInfo startInfo = new()
            {
                FileName = "wmic",
                Arguments = "path softwarelicensingservice get OA3xOriginalProductKey",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using Process process = Process.Start(startInfo);
            process.WaitForExit();
            string output = process.StandardOutput.ReadToEnd();

            //Divide o retorno do comando para cada linha obtida, criando um array de strings.
            string[] lines = output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // Verifica a 2º linha do retorno do comando, se conter um sequência sem espaços consideramos como uma chave válida.
            if (string.IsNullOrWhiteSpace(lines[1]) || lines[1].Trim().Contains(" "))
            {
                textBox2.ForeColor = Color.Red;
                return "Máquina sem chave windows";
            }

            else
            {
                return lines[1].Trim();
            }
        }

        public async Task ChecarConexãoInternet(Control textBox3, Control textBox4)
        {
            using (var client = new HttpClient())
            {
                // Define um limite de tempo de 2 segundos para a solicitação.
                client.Timeout = TimeSpan.FromSeconds(2);

                try {
                    // Tenta fazer uma solicitação ao endereço do Google no tempo estipulado.
                    HttpResponseMessage response = await client.GetAsync("https://www.google.com");

                    // Verifica se a resposta da solicitação é bem-sucedida (código de status HTTP 200 OK).
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        // Se a resposta for bem-sucedida, chama os métodos para obter o endereço IPv4 e o endereço MAC.
                        endereçoIPv4 = ObterEndereçoIPv4();
                        endereçoMAC = ObterEndereçoMAC(endereçoIPv4);
                    }
                }
                catch (Exception ex) {
                    textBox3.ForeColor = Color.Red;
                    textBox4.ForeColor = Color.Red;
                    endereçoIPv4 = "Sem conexão com a internet";
                    endereçoMAC = "Nenhuma mídia em uso";
                }
            }
        }

        public static string ObterEndereçoIPv4()
        {
            // Cria um novo soquete com uma família de endereços IPv4 e tipo datagrama ( UDP ).
            using (Socket socket = new(AddressFamily.InterNetwork, SocketType.Dgram, 0))
            {
                socket.Connect("8.8.8.8", 65530);

                // Obtém informações sobre o ponto de extremidade local do soquete, que contém o endereço IPv4.
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                return endPoint.Address.ToString();
            }
        }

        public static string ObterEndereçoMAC(string endereçoIPv4)
        {
            // Obtém todas as interfaces de rede disponíveis na máquina.
            NetworkInterface[] interfaceRede = NetworkInterface.GetAllNetworkInterfaces();

            // Itera sobre cada interface de rede.
            foreach (NetworkInterface adaptador in interfaceRede)
            {
                // Itera sobre as informações de endereços IP associadas a essa interface.
                foreach (UnicastIPAddressInformation infoEndIPv4Unic in adaptador.GetIPProperties().UnicastAddresses)
                {
                    // Verifica se o endereço IP é do tipo InterNetwork (IPv4).
                    if (infoEndIPv4Unic.Address.AddressFamily == AddressFamily.InterNetwork)
                    {
                        // Compara o endereço IP da interface com o endereço IPv4 fornecido
                        if (infoEndIPv4Unic.Address.ToString() == endereçoIPv4)
                        {
                            // Obtém o endereço endereço físico da interface correspondente.
                            PhysicalAddress endereçoFísico = adaptador.GetPhysicalAddress();
                            return BitConverter.ToString(endereçoFísico.GetAddressBytes());
                        }
                    }
                }
            }
            return "Erro ao tentar obter o MAC";
        }

        private string ObterModeloProduto()
        {
            // Utiliza o comando "wmic baseboard get produc" no cmd para obter o modelo do produto.
            ProcessStartInfo startInfo = new()
            {
                FileName = "wmic",
                Arguments = "baseboard get product",
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            using Process process = Process.Start(startInfo);
            process.WaitForExit();
            string output = process.StandardOutput.ReadToEnd();

            // Divide o retorno do comando para cada linha obtida, criando um array de strings.
            string[] lines = output.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            // Verifica a 2º linha do retorno do comando, se conter um sequência sem espaços consideramos como um modelo válido.
            if (string.IsNullOrWhiteSpace(lines[1]) || lines[1].Trim().Contains(" "))
            {
                return "Nenhum modelo registrado";
            }
            else
            {
                return lines[1].Trim();
            }
        }
        
        void GerarArquivoTexto(string arquivo, string textBoxSN, string textBoxKEY, string textBoxIP, string textBoxMAC)
        {
            // Cria um arquivo de texto padrão com adição das informações obtidas através de outros métodos.
            using StreamWriter writer = new(arquivo);
            writer.WriteLine("----------------------------------------------------");
            writer.WriteLine("");
            writer.WriteLine("             WSI ( Windows System Info )");
            writer.WriteLine("");
            writer.WriteLine($"                    {DateTime.Now.ToString("dd-MM-yyyy")}");
            writer.WriteLine($"                     {DateTime.Now.ToString("HH:mm:ss")}");
            writer.WriteLine("");
            writer.WriteLine("----------------------------------------------------");
            writer.WriteLine("");
            writer.WriteLine($" SerialNumber : {textBoxSN}");
            writer.WriteLine("");
            writer.WriteLine($" ProductKey : {textBoxKEY}");
            writer.WriteLine("");
            writer.WriteLine($" Modelo : {ObterModeloProduto()}");
            writer.WriteLine("");
            writer.WriteLine("----------------------------------------------------");
            writer.WriteLine("");
            writer.WriteLine($" IP Adress : {textBoxIP}");
            writer.WriteLine("");
            writer.WriteLine($" MAC Adress : {textBoxMAC}");
            writer.WriteLine("");
            writer.WriteLine("----------------------------------------------------");
        }

        public void GerarArquivo(Control button, string textBoxSN, string textBoxKEY, string textBoxIP, string textBoxMAC)
        {
            using SaveFileDialog saveFileDialog = new();
            saveFileDialog.Filter = "Arquivos de Texto (*.txt)|*.txt|Todos os Arquivos (*.*)|*.*";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.Title = "Salvar Arquivo";

            // Define um nome de arquivo padrão para a caixa de diálogo de salvamento ( "MAQ" + DATA + HORÁRIO ).
            saveFileDialog.FileName = $"MAQ_{DateTime.Now.ToString("ddMMyy")}-{DateTime.Now.ToString("HHmmss")}.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string arquivo = saveFileDialog.FileName;

                GerarArquivoTexto(arquivo, textBoxSN, textBoxKEY, textBoxIP, textBoxMAC);

                // Cria uma caixa de diálogo que permite o usuário escolher entre abrir ou  não o arquivo de texto criado.
                DialogResult opçãoEscolhida = MessageBox.Show(
                    button,
                    "Arquivo salvo com sucesso! Deseja abri-lo?",
                    "Confirmação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    );

                // Verifica a escolha do usuário
                if (opçãoEscolhida == DialogResult.Yes)
                {
                    Process.Start("notepad.exe", arquivo);
                }
            }
        }
    }
}
