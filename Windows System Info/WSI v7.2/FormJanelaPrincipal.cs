using System.Drawing.Drawing2D;
using Windows_System_Info.Properties;
using Windows_System_Info_Fun��es_Janela;
using Windows_System_Info_Fun��es_Aplica��o;

namespace Windows_System_Info_Form_And_Designer
{
    public partial class FormJanelaPrincipal : Form
    {
        private string tema = Settings.Default.Tema; // Vari�vel para controlar a altera��o dos temas.

        private readonly Fun��esAplica��o InstanciaFun��esAplica��o;

        private readonly Fun��esJanela InstanciaFun��esJanela;

        private readonly System.Windows.Forms.Timer timerMensagemCopiada;

        private Label labelConte�doCopiado;

        // Definir constantes usadas para alterar os par�metros de configura��o e estilo da classe de cria��o da janela.
        const int WS_MINIMIZEBOX = 0x20000;
        const int CS_DBLCLKS = 0x8;

        // M�todo para personalizar e estender novas funcionalidades � classe base de cria��o da janela.
        protected override CreateParams CreateParams
        {
            get
            {
                // Obt�m os par�metros padr�o da cria��o da janela chamando o m�todo da classe base.
                CreateParams cp = base.CreateParams;

                // Habilita o estilo de minimizar a janela pela barra de tarefas atrav�s da altera��o dos par�metros.
                cp.Style |= WS_MINIMIZEBOX;

                // Configura a classe da janela para processar eventos de clique duplo atrav�s da altera��o dos par�metros.
                cp.ClassStyle |= CS_DBLCLKS;
                return cp;
            }
        }

        // M�todo para personalizar a forma da janela, criando cantos arredondados.
        protected override void OnPaint(PaintEventArgs e)
        {
            // Mant�m o comportamento padr�o de desenho da classe base antes de aplicar alguma altera��o.
            base.OnPaint(e);

            int raioBorda = 25; // Valor para ajustar o raio dos cantos.

            // Cria um novo caminho gr�fico personalizado com base no raio definido.
            GraphicsPath path = new();
            path.AddArc(0, 0, raioBorda, raioBorda, 180, 90); // Canto superior esquerdo.
            path.AddArc(this.Width - raioBorda, 0, raioBorda, raioBorda, 270, 90); // Canto superior direito.
            path.AddArc(this.Width - raioBorda, this.Height - raioBorda, raioBorda, raioBorda, 0, 90); // Canto inferior direito.
            path.AddArc(0, this.Height - raioBorda, raioBorda, raioBorda, 90, 90); // Canto inferior esquerdo.

            // Define a regi�o da janela de acordo com o caminho gr�fico personalizado definido.
            this.Region = new Region(path);
        }

        public FormJanelaPrincipal()
        {
            InitializeComponent(); // Inicializa e configura os componentes visuais do formul�rio.

            InstanciaFun��esJanela = new Fun��esJanela(this, PnlTitulo, PctbLogo, LblTitulo, BtnAlterarTema,
                ListaInterfacesAzulPreto(this), ListaInterfacesBrancoCinza(this), ListaBot�esMouseOver(this), ListaBot�esCopiar(this));

            // Aciona o bot�oTema para iniciar com a janela no Tema Claro.
            BtnAlterarTema_Click(null, null);

            InstanciaFun��esAplica��o = new Fun��esAplica��o();

            ArredondarCantosMenus(ListaInterfacesCantosRedondos(this), 25);

            // Cria e associa um Timer para agendar tarefas com o evento/m�todo TimerMensagemCopiada_Tick.
            timerMensagemCopiada = new System.Windows.Forms.Timer();
            timerMensagemCopiada.Tick += TimerMensagemCopiada_Tick;
        }

        private async void FormJanelaPrincipal_Load(object sender, EventArgs e)
        {
            await InvocarM�todosMenus();
        }

        private void ArredondarCantosMenus(List<Control> listaMenusRedondos, int raioBorda)
        {
            // Itera sobre a lista das interfaces que devem ter os cantos redondos e aplica o m�todo para tal.
            foreach (var interfaceControle in listaMenusRedondos)
            {
                InstanciaFun��esJanela.ArredondarCantos(interfaceControle, raioBorda);
            }
        }

        private async Task InvocarM�todosMenus()
        {
            // Chame os m�todos ass�ncronos da inst�ncia existente de Fun��esAplica��o.
            await InstanciaFun��esAplica��o.ObterInforma��esAssincronamente(TbSN, TbKEY, TbIP, TbMAC);

            // Atualizar as informa��es dos controles ap�s a finaliza��o dos m�todos.
            TbSN.Text = InstanciaFun��esAplica��o.n�meroDeS�rie;
            TbKEY.Text = InstanciaFun��esAplica��o.chaveDoProduto;
            TbIP.Text = InstanciaFun��esAplica��o.endere�oIPv4;
            TbMAC.Text = InstanciaFun��esAplica��o.endere�oMAC;
        }

        private void BtnGerarArquivo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbMAC.Text)) { }
            else
            {
                InstanciaFun��esAplica��o.GerarArquivo(BtnGerarArquivo, TbSN.Text, TbKEY.Text, TbIP.Text, TbMAC.Text);
            }
        }

        private void BtnCopiarSN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbSN.Text)) { }
            else
            {
                InstanciaFun��esJanela.CopiarConte�do(TbSN);

                this.labelConte�doCopiado = LblSNCopiado;

                LblSNCopiado.Visible = true;

                timerMensagemCopiada.Start();
            }
        }

        private void BtnCopiarKEY_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbKEY.Text)) { }
            else
            {
                InstanciaFun��esJanela.CopiarConte�do(TbKEY);

                this.labelConte�doCopiado = LblKEYCopiado;

                LblKEYCopiado.Visible = true;

                timerMensagemCopiada.Start();
            }
        }

        private void BtnCopiarIP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbIP.Text)) { }
            else
            {
                InstanciaFun��esJanela.CopiarConte�do(TbIP);

                this.labelConte�doCopiado = LblIPCopiado;

                LblIPCopiado.Visible = true;

                timerMensagemCopiada.Start();
            }

        }

        private void BtnCopiarMAC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TbMAC.Text)) { }
            else
            {
                InstanciaFun��esJanela.CopiarConte�do(TbMAC);

                this.labelConte�doCopiado = LblMACCopiado;

                LblMACCopiado.Visible = true;

                timerMensagemCopiada.Start();
            }
        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            InstanciaFun��esJanela.FecharJanela(sender, e);
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            InstanciaFun��esJanela.MinimizarJanela(this);
        }

        private void BtnAlterarTema_Click(object sender, EventArgs e)
        {
            if (tema == "Claro")
            {
                InstanciaFun��esJanela.TemaClaro(this);

                // Salva o tema atual nas configura��es padr�es do usu�rio ( Claro ).
                Settings.Default.Tema = "Claro";
                Settings.Default.Save();

                this.tema = "Escuro"; // Alterar o valor que reconhece o modo dos temas.
            }
            else
            {
                InstanciaFun��esJanela.TemaEscuro(this);

                // Salva o tema atual nas configura��es padr�es do usu�rio ( Escuro ).
                Settings.Default.Tema = "Escuro";
                Settings.Default.Save();

                this.tema = "Claro"; // Alterar o valor que reconhece o modo dos temas.
            }
        }

        // M�todo para ocultar a label informativa ap�s um tempo de quando uma caixa de texto tem o seu conte�do copiado.
        public void TimerMensagemCopiada_Tick(object sender, EventArgs e)
        {
            this.labelConte�doCopiado.Visible = false;
            timerMensagemCopiada.Interval = 500;

            timerMensagemCopiada.Stop();
        }

        // Lista com as interfaces de controle que devem ter os cantos redondos.
        private static List<Control> ListaInterfacesCantosRedondos(FormJanelaPrincipal formul�rio)
        {
            List<Control> ListaInterfacesControleRedondas = new()
            {
                formul�rio.LblSN,
                formul�rio.LblKEY,
                formul�rio.LblIP,
                formul�rio.LblMAC,
                formul�rio.LblSNBack,
                formul�rio.LblKEYBack,
                formul�rio.LblIPBack,
                formul�rio.LblMACBack,
                formul�rio.BtnCopiarSN,
                formul�rio.BtnCopiarKEY,
                formul�rio.BtnCopiarIP,
                formul�rio.BtnCopiarMAC
            };
            return ListaInterfacesControleRedondas;
        }

        // Lista com as interfaces de controle ( Principais ) que devem mudar de cor ( Tema claro/escuro ).
        public static List<Control> ListaInterfacesAzulPreto(FormJanelaPrincipal formul�rio)
        {
            List<Control> ListaInterfacesAzulPreto = new()
            {
                formul�rio.PnlTitulo,
                formul�rio.PctbLogo,
                formul�rio.LblTitulo,
                formul�rio.BtnAlterarTema,
                formul�rio.BtnMinimizar,
                formul�rio.BtnFechar,

                formul�rio.LblSN,
                formul�rio.LblKEY,
                formul�rio.LblIP,
                formul�rio.LblMAC,

                formul�rio.LblGapSN,
                formul�rio.LblGapKEY,
                formul�rio.LblGapIP,
                formul�rio.LblGapMAC,

                formul�rio.BtnGerarArquivo,
                formul�rio.LblRodape,
                formul�rio.PctbCopyright,
                formul�rio.LblCopyright
            };
            return ListaInterfacesAzulPreto;
        }

        // Lista com as interfaces de controle ( Fundo e caixas de textos ) que devem mudar de cor ( Tema claro/escuro ).
        public static List<Control> ListaInterfacesBrancoCinza(FormJanelaPrincipal formul�rio)
        {
            List<Control> ListaInterfacesBrancoCinza = new()
            {
                formul�rio.LblSNBack,
                formul�rio.LblKEYBack,
                formul�rio.LblIPBack,
                formul�rio.LblMACBack,

                formul�rio.TbSN,
                formul�rio.TbKEY,
                formul�rio.TbIP,
                formul�rio.TbMAC,

                formul�rio.BtnCopiarSN,
                formul�rio.BtnCopiarKEY,
                formul�rio.BtnCopiarIP,
                formul�rio.BtnCopiarMAC
            };
            return ListaInterfacesBrancoCinza;
        }

        // Lista com os bot�es que devem ter a cor da propriedade MouseOver alterada ( Tema claro/escuro ).
        public static List<Button> ListaBot�esMouseOver(FormJanelaPrincipal formul�rio)
        {
            List<Button> ListaBot�esMouseOver = new()
            {
                formul�rio.BtnAlterarTema,
                formul�rio.BtnMinimizar,
                formul�rio.BtnFechar,
                formul�rio.BtnGerarArquivo
            };
            return ListaBot�esMouseOver;
        }

        // Lista com os bot�es de c�pia que devem ter o �cone alterado ( Tema claro/escuro ).
        public static List<Button> ListaBot�esCopiar(FormJanelaPrincipal formul�rio)
        {
            List<Button> ListaBot�esCopiar = new()
            {
                formul�rio.BtnCopiarSN,
                formul�rio.BtnCopiarKEY,
                formul�rio.BtnCopiarIP,
                formul�rio.BtnCopiarMAC
            };
            return ListaBot�esCopiar;
        }
    }
}
