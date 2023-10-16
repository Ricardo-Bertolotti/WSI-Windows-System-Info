using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;

namespace Windows_System_Info_Funções_Janela
{
    public class FunçõesJanela
    {
        // Importar a função nativa do Windows que permite o controle de eventos do mouse por outros elementos.  
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        // Importar a função nativa do Windows para a comunicação e controle interno entre outros elementos.
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hwnd, int wmsg, int wparam, int lparam);

        // Definir constantes usadas pela função SendMessage.
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        // Definir os parâmetro do construtor como objetos das classes de controle gráfico do Windows Forms.
        private readonly Control painel1;
        private readonly PictureBox pictureBox1;
        private readonly Label label1;
        private readonly Button botãoTema;

        private readonly List<Control> ListaInterfacesAzulPreto;
        private readonly List<Control> ListaInterfacesBrancoCinza;
        private readonly List<Button> ListaBotõesMouseOver;
        private readonly List<Button> ListaBotõesCopiar;

        public FunçõesJanela(Form form1, Control painel1, PictureBox pictureBox1 , Label label1, Button botãoTema,
            List<Control> ListaInterfacesAzulPreto, List<Control> ListaInterfacesBrancoCinza,
            List<Button> ListaBotõesMouseOver, List<Button> ListaBotõesCopiar)
        {
            // Obtém os valores recebidos nos parâmetros e os atualiza nos atributos da classe.
            this.painel1 = painel1;
            this.pictureBox1 = pictureBox1;
            this.label1 = label1;
            this.botãoTema = botãoTema;
            this.ListaInterfacesAzulPreto = ListaInterfacesAzulPreto;
            this.ListaInterfacesBrancoCinza = ListaInterfacesBrancoCinza;
            this.ListaBotõesMouseOver = ListaBotõesMouseOver;
            this.ListaBotõesCopiar = ListaBotõesCopiar;

            HabilitarMovimentaçãoJanela();

            // Define a posição inicial da janela para o centro da tela do usuário.
            form1.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void HabilitarMovimentaçãoJanela()
        {
            // Invoca o método MouseCliqueEsquerdo ao detectar uma interação do mouse em algum dos elementos do método.
            painel1.MouseDown += MouseCliqueEsquerdo;
            label1.MouseMove += MouseCliqueEsquerdo;
            pictureBox1.MouseMove += MouseCliqueEsquerdo;
        }

        private void MouseCliqueEsquerdo(object sender, MouseEventArgs e)
        {
            // Verifica se o clique foi com o botão esquerdo do mouse.
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();

                // Permite a movimentação da janela através da interação com o elemento gráfico.
                SendMessage(painel1.FindForm().Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void FecharJanela(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void MinimizarJanela(Form form)
        {
            form.WindowState = FormWindowState.Minimized;
        }

        public void CopiarConteúdo(Control controleInterface)
        {
            Clipboard.SetText(controleInterface.Text);
        }

        public void ArredondarCantos(Control controle, int raioBorda)
        {
            // Cria um novo caminho gráfico personalizado com base no raio definido.
            GraphicsPath path = new();
            path.AddArc(0, 0, raioBorda, raioBorda, 180, 90); // Canto superior esquerdo.
            path.AddArc(controle.Width - raioBorda, 0, raioBorda, raioBorda, 270, 90); // Canto superior direito.
            path.AddArc(controle.Width - raioBorda, controle.Height - raioBorda, raioBorda, raioBorda, 0, 90); // Canto inferior direito.
            path.AddArc(0, controle.Height - raioBorda, raioBorda, raioBorda, 90, 90); // Canto inferior esquerdo.

            // Define a região da interface de cintrole de acordo com o caminho gráfico personalizado definido.
            controle.Region = new Region(path);
        }

        // Altera o ícone do botãoTema e itera sobre as listas das interfaces de controle para alterar suas cores ( Tema Claro ).
        public void TemaClaro(Form formulário)
        {
            // Altera o ícone do botãoTema.
            botãoTema.Image = Windows_System_Info.Properties.Resources.Lua_icon;

            formulário.BackColor = Color.White;

            foreach (Control interfaceControle in ListaInterfacesAzulPreto)
            {
                interfaceControle.BackColor = Color.FromArgb(0, 80, 220);
            }
            foreach (Control interfaceControle in ListaInterfacesBrancoCinza)
            {
                interfaceControle.BackColor = Color.FromArgb(240, 240, 240);
            }
            foreach (Button botãoMouseOver in ListaBotõesMouseOver)
            {
                botãoMouseOver.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 96, 255);
            }
            foreach (Button botãoCopiar in ListaBotõesCopiar)
            {
                botãoCopiar.Image = Windows_System_Info.Properties.Resources.BlueCopy_icon;
            }

        }

        // Altera o ícone do botãoTema e itera sobre as listas das interfaces de controle para alterar suas cores ( Tema Escuro ).
        public void TemaEscuro(Form formulário)
        {
            // Altera o ícone do botãoTema
            botãoTema.Image = Windows_System_Info.Properties.Resources.Sol_icon;   

            formulário.BackColor = Color.FromArgb(64, 64, 64);
            
            foreach (Control interfaceControle in ListaInterfacesAzulPreto)
            {
                interfaceControle.BackColor = Color.Black;
            }
            foreach (Control interfaceControle in ListaInterfacesBrancoCinza)
            {
                interfaceControle.BackColor = Color.FromArgb(180, 180, 180);
            }
            foreach (Button botõesMouseOver in ListaBotõesMouseOver)
            {
                botõesMouseOver.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            }
            foreach (Button botãoCopiar in ListaBotõesCopiar)
            {
                botãoCopiar.Image = Windows_System_Info.Properties.Resources.DarkCopy_icon;
            }
        }
    }
}
