using System.Drawing.Drawing2D;
using Windows_System_Info.Properties;
using Windows_System_Info_Funções_Janela;
using Windows_System_Info_Funções_Aplicação;

namespace Windows_System_Info_Form_And_Designer
{
    public partial class FormJanelaPrincipal : Form
    {
        private string tema = Settings.Default.Tema; // Variável para controlar a alteração dos temas.

        private readonly FunçõesAplicação InstanciaFunçõesAplicação;

        private readonly FunçõesJanela InstanciaFunçõesJanela;

        private readonly System.Windows.Forms.Timer timerMensagemCopiada;

        private Label labelConteúdoCopiado;

        // Definir constantes usadas para alterar os parâmetros de configuração e estilo da classe de criação da janela.
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        // Método para personalizar e estender novas funcionalidades à classe base de criação da janela.
        protected override CreateParams CreateParams
        {
            get
            {
                // Obtém os parâmetros padrão da criação da janela chamando o método da classe base.
                CreateParams cp = base.CreateParams;

                // Habilita o estilo de minimizar a janela pela barra de tarefas através da alteração dos parâmetros.
                cp.Style |= WS_MINIMIZEBOX;

                // Configura a classe da janela para processar eventos de clique duplo através da alteração dos parâmetros.
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        // Método para personalizar a forma da janela, criando cantos arredondados.
        protected override void OnPaint(PaintEventArgs e)
        {
            // Mantém o comportamento padrão de desenho da classe base antes de aplicar alguma alteração.
            base.OnPaint(e);

            int raioBorda = 25; // Valor para ajustar o raio dos cantos.

            // Cria um novo caminho gráfico personalizado com base no raio definido.
            GraphicsPath path = new();
            path.AddArc(0, 0, raioBorda, raioBorda, 180, 90); // Canto superior esquerdo.
            path.AddArc(this.Width - raioBorda, 0, raioBorda, raioBorda, 270, 90); // Canto superior direito.
            path.AddArc(this.Width - raioBorda, this.Height - raioBorda, raioBorda, raioBorda, 0, 90); // Canto inferior direito.
            path.AddArc(0, this.Height - raioBorda, raioBorda, raioBorda, 90, 90); // Canto inferior esquerdo.

            // Define a região da janela de acordo com o caminho gráfico personalizado definido.
            this.Region = new Region(path);
        }

        public FormJanelaPrincipal()
        {
            InitializeComponent(); // Inicializa e configura os componentes visuais do formulário.

            InstanciaFunçõesJanela = new FunçõesJanela(this, PnlTitulo, PctbLogo, LblTitulo, BtnAlterarTema,
                ListaInterfacesAzulPreto(this), ListaInterfacesBrancoCinza(this), ListaBotõesMouseOver(this), ListaBotõesCopiar(this));

            // Aciona o botãoTema para iniciar com a janela no Tema Claro.
            BtnAlterarTema_Click(null, null);

            InstanciaFunçõesAplicação = new FunçõesAplicação();

            ArredondarCantosMenus(ListaInterfacesCantosRedondos(this), 25);

            // Cria e associa um Timer para agendar tarefas com o evento/método TimerMensagemCopiada_Tick.
            timerMensagemCopiada = new System.Windows.Forms.Timer();
            timerMensagemCopiada.Tick += TimerMensagemCopiada_Tick;
        }

        private async void FormJanelaPrincipal_Load(object sender, EventArgs e)
        {
            await InvocarMétodosMenus();
        }

        private void ArredondarCantosMenus(List<Control> listaMenusRedondos, int raioBorda)
        {
            // Itera sobre a lista das interfaces que devem ter os cantos redondos e aplica o método para tal.
            foreach (var interfaceControle in listaMenusRedondos)
            {
                InstanciaFunçõesJanela.ArredondarCantos(interfaceControle, raioBorda);
            }
        }

        private async Task InvocarMétodosMenus()
        {
            // Chame os métodos assíncronos da instância existente de FunçõesAplicação.
            await InstanciaFunçõesAplicação.ObterInformaçõesAssincronamente(TbSN, TbKEY, TbIP, TbMAC);

            // Atualizar as informações dos controles após a finalização dos métodos.
            TbSN.Text = InstanciaFunçõesAplicação.númeroDeSérie;
            TbKEY.Text = InstanciaFunçõesAplicação.chaveDoProduto;
            TbIP.Text = InstanciaFunçõesAplicação.endereçoIPv4;
            TbMAC.Text = InstanciaFunçõesAplicação.endereçoMAC;
        }

        private void BtnGerarArquivo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbMAC.Text)) { }
            else
            {
                InstanciaFunçõesAplicação.GerarArquivo(BtnGerarArquivo, TbSN.Text, TbKEY.Text, TbIP.Text, TbMAC.Text);
            }
        }

        private void BtnCopiarSN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbSN.Text)) { }
            else
            {
                InstanciaFunçõesJanela.CopiarConteúdo(TbSN);

                this.labelConteúdoCopiado = LblSNCopiado;

                LblSNCopiado.Visible = true;

                timerMensagemCopiada.Start();
            }
        }

        private void BtnCopiarKEY_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbKEY.Text)) { }
            else
            {
                InstanciaFunçõesJanela.CopiarConteúdo(TbKEY);

                this.labelConteúdoCopiado = LblKEYCopiado;

                LblKEYCopiado.Visible = true;

                timerMensagemCopiada.Start();
            }
        }

        private void BtnCopiarIP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbIP.Text)) { }
            else
            {
                InstanciaFunçõesJanela.CopiarConteúdo(TbIP);

                this.labelConteúdoCopiado = LblIPCopiado;

                LblIPCopiado.Visible = true;

                timerMensagemCopiada.Start();
            }

        }

        private void BtnCopiarMAC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbMAC.Text)) { }
            else
            {
                InstanciaFunçõesJanela.CopiarConteúdo(TbMAC);

                this.labelConteúdoCopiado = LblMACCopiado;

                LblMACCopiado.Visible = true;

                timerMensagemCopiada.Start();
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            InstanciaFunçõesJanela.FecharJanela(sender, e);
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            InstanciaFunçõesJanela.MinimizarJanela(this);
        }

        private void BtnAlterarTema_Click(object sender, EventArgs e)
        {
            if (tema == "Claro")
            {
                InstanciaFunçõesJanela.TemaClaro(this);

                // Salva o tema atual nas configurações padrões do usuário ( Claro ).
                Settings.Default.Tema = "Claro";
                Settings.Default.Save();

                this.tema = "Escuro"; // Alterar o valor que reconhece o modo dos temas.
            }
            else
            {
                InstanciaFunçõesJanela.TemaEscuro(this);

                // Salva o tema atual nas configurações padrões do usuário ( Escuro ).
                Settings.Default.Tema = "Escuro";
                Settings.Default.Save();

                this.tema = "Claro"; // Alterar o valor que reconhece o modo dos temas.
            }
        }

        // Método para ocultar a label informativa após um tempo de quando uma caixa de texto tem o seu conteúdo copiado.
        public void TimerMensagemCopiada_Tick(object sender, EventArgs e)
        {
            this.labelConteúdoCopiado.Visible = false;
            timerMensagemCopiada.Interval = 500;

            timerMensagemCopiada.Stop();
        }

        // Lista com as interfaces de controle que devem ter os cantos redondos.
        private static List<Control> ListaInterfacesCantosRedondos(FormJanelaPrincipal formulário)
        {
            List<Control> ListaInterfacesControleRedondas = new()
            {
                formulário.LblSN,
                formulário.LblKEY,
                formulário.LblIP,
                formulário.LblMAC,
                formulário.LblSNBack,
                formulário.LblKEYBack,
                formulário.LblIPBack,
                formulário.LblMACBack,
                formulário.BtnCopiarSN,
                formulário.BtnCopiarKEY,
                formulário.BtnCopiarIP,
                formulário.BtnCopiarMAC
            };
            return ListaInterfacesControleRedondas;
        }

        // Lista com as interfaces de controle ( Principais ) que devem mudar de cor ( Tema claro/escuro ).
        public static List<Control> ListaInterfacesAzulPreto(FormJanelaPrincipal formulário)
        {
            List<Control> ListaInterfacesAzulPreto = new()
            {
                formulário.PnlTitulo,
                formulário.PctbLogo,
                formulário.LblTitulo,
                formulário.BtnAlterarTema,
                formulário.BtnMinimizar,
                formulário.BtnFechar,

                formulário.LblSN,
                formulário.LblKEY,
                formulário.LblIP,
                formulário.LblMAC,

                formulário.LblGapSN,
                formulário.LblGapKEY,
                formulário.LblGapIP,
                formulário.LblGapMAC,

                formulário.BtnGerarArquivo,
                formulário.LblRodape,
                formulário.PctbCopyright,
                formulário.LblCopyright
            };
            return ListaInterfacesAzulPreto;
        }

        // Lista com as interfaces de controle ( Fundo e caixas de textos ) que devem mudar de cor ( Tema claro/escuro ).
        public static List<Control> ListaInterfacesBrancoCinza(FormJanelaPrincipal formulário)
        {
            List<Control> ListaInterfacesBrancoCinza = new()
            {
                formulário.LblSNBack,
                formulário.LblKEYBack,
                formulário.LblIPBack,
                formulário.LblMACBack,

                formulário.TbSN,
                formulário.TbKEY,
                formulário.TbIP,
                formulário.TbMAC,

                formulário.BtnCopiarSN,
                formulário.BtnCopiarKEY,
                formulário.BtnCopiarIP,
                formulário.BtnCopiarMAC
            };
            return ListaInterfacesBrancoCinza;
        }

        // Lista com os botões que devem ter a cor da propriedade MouseOver alterada ( Tema claro/escuro ).
        public static List<Button> ListaBotõesMouseOver(FormJanelaPrincipal formulário)
        {
            List<Button> ListaBotõesMouseOver = new()
            {
                formulário.BtnAlterarTema,
                formulário.BtnMinimizar,
                formulário.BtnFechar,
                formulário.BtnGerarArquivo
            };
            return ListaBotõesMouseOver;
        }

        // Lista com os botões de cópia que devem ter o ícone alterado ( Tema claro/escuro ).
        public static List<Button> ListaBotõesCopiar(FormJanelaPrincipal formulário)
        {
            List<Button> ListaBotõesCopiar = new()
            {
                formulário.BtnCopiarSN,
                formulário.BtnCopiarKEY,
                formulário.BtnCopiarIP,
                formulário.BtnCopiarMAC
            };
            return ListaBotõesCopiar;
        }
    }
}
