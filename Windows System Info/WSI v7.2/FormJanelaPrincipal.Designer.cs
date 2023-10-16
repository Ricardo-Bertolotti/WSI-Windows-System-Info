namespace Windows_System_Info_Form_And_Designer
{
    partial class FormJanelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJanelaPrincipal));
            PnlTitulo = new Panel();
            BtnAlterarTema = new Button();
            PctbLogo = new PictureBox();
            LblTitulo = new Label();
            BtnMinimizar = new Button();
            BtnFechar = new Button();
            LblRodape = new Label();
            BtnGerarArquivo = new Button();
            LblSN = new Label();
            LblKEY = new Label();
            LblIP = new Label();
            LblMAC = new Label();
            LblGapSN = new Label();
            LblGapKEY = new Label();
            LblGapIP = new Label();
            LblGapMAC = new Label();
            PctbCopyright = new PictureBox();
            LblCopyright = new Label();
            TbSN = new TextBox();
            TbKEY = new TextBox();
            TbIP = new TextBox();
            TbMAC = new TextBox();
            BtnCopiarSN = new Button();
            BtnCopiarKEY = new Button();
            BtnCopiarIP = new Button();
            BtnCopiarMAC = new Button();
            LblSNBack = new Label();
            LblKEYBack = new Label();
            LblIPBack = new Label();
            LblMACBack = new Label();
            LblSNCopiado = new Label();
            LblKEYCopiado = new Label();
            LblIPCopiado = new Label();
            LblMACCopiado = new Label();
            PnlTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PctbLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PctbCopyright).BeginInit();
            SuspendLayout();
            // 
            // PnlTitulo
            // 
            PnlTitulo.BackColor = Color.FromArgb(0, 80, 220);
            PnlTitulo.Controls.Add(BtnAlterarTema);
            PnlTitulo.Controls.Add(PctbLogo);
            PnlTitulo.Controls.Add(LblTitulo);
            PnlTitulo.Controls.Add(BtnMinimizar);
            PnlTitulo.Controls.Add(BtnFechar);
            PnlTitulo.Location = new Point(0, 0);
            PnlTitulo.Margin = new Padding(0);
            PnlTitulo.Name = "PnlTitulo";
            PnlTitulo.Size = new Size(800, 60);
            PnlTitulo.TabIndex = 0;
            // 
            // BtnAlterarTema
            // 
            BtnAlterarTema.BackColor = Color.FromArgb(0, 80, 220);
            BtnAlterarTema.BackgroundImageLayout = ImageLayout.Center;
            BtnAlterarTema.FlatAppearance.BorderSize = 0;
            BtnAlterarTema.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            BtnAlterarTema.FlatStyle = FlatStyle.Flat;
            BtnAlterarTema.ForeColor = Color.Black;
            BtnAlterarTema.Location = new Point(620, 0);
            BtnAlterarTema.Margin = new Padding(0);
            BtnAlterarTema.Name = "BtnAlterarTema";
            BtnAlterarTema.Size = new Size(60, 60);
            BtnAlterarTema.TabIndex = 30;
            BtnAlterarTema.UseVisualStyleBackColor = false;
            BtnAlterarTema.Click += BtnAlterarTema_Click;
            // 
            // PctbLogo
            // 
            PctbLogo.BackColor = Color.FromArgb(0, 80, 220);
            PctbLogo.BackgroundImage = Windows_System_Info.Properties.Resources.W10_icon;
            PctbLogo.BackgroundImageLayout = ImageLayout.Center;
            PctbLogo.Location = new Point(5, 5);
            PctbLogo.Name = "PctbLogo";
            PctbLogo.Size = new Size(50, 50);
            PctbLogo.TabIndex = 15;
            PctbLogo.TabStop = false;
            // 
            // LblTitulo
            // 
            LblTitulo.BackColor = Color.FromArgb(0, 80, 220);
            LblTitulo.FlatStyle = FlatStyle.Flat;
            LblTitulo.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point);
            LblTitulo.ForeColor = SystemColors.Control;
            LblTitulo.Location = new Point(90, 0);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(380, 60);
            LblTitulo.TabIndex = 15;
            LblTitulo.Text = "Windows System Info";
            LblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // BtnMinimizar
            // 
            BtnMinimizar.BackColor = Color.FromArgb(0, 80, 220);
            BtnMinimizar.BackgroundImage = Windows_System_Info.Properties.Resources.Minimize_icon;
            BtnMinimizar.BackgroundImageLayout = ImageLayout.Center;
            BtnMinimizar.FlatAppearance.BorderSize = 0;
            BtnMinimizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            BtnMinimizar.FlatStyle = FlatStyle.Flat;
            BtnMinimizar.ForeColor = Color.Black;
            BtnMinimizar.Location = new Point(680, 0);
            BtnMinimizar.Margin = new Padding(0);
            BtnMinimizar.Name = "BtnMinimizar";
            BtnMinimizar.Size = new Size(60, 60);
            BtnMinimizar.TabIndex = 1;
            BtnMinimizar.UseVisualStyleBackColor = false;
            BtnMinimizar.Click += BtnMinimizar_Click;
            // 
            // BtnFechar
            // 
            BtnFechar.BackColor = Color.FromArgb(0, 80, 220);
            BtnFechar.BackgroundImage = Windows_System_Info.Properties.Resources.Exit_icon;
            BtnFechar.BackgroundImageLayout = ImageLayout.Center;
            BtnFechar.FlatAppearance.BorderSize = 0;
            BtnFechar.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            BtnFechar.FlatStyle = FlatStyle.Flat;
            BtnFechar.ForeColor = Color.Black;
            BtnFechar.Location = new Point(740, 0);
            BtnFechar.Margin = new Padding(0);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(60, 60);
            BtnFechar.TabIndex = 0;
            BtnFechar.UseVisualStyleBackColor = false;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // LblRodape
            // 
            LblRodape.BackColor = Color.FromArgb(0, 80, 220);
            LblRodape.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            LblRodape.ForeColor = SystemColors.ControlLightLight;
            LblRodape.Location = new Point(0, 615);
            LblRodape.Name = "LblRodape";
            LblRodape.Size = new Size(800, 20);
            LblRodape.TabIndex = 1;
            LblRodape.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // BtnGerarArquivo
            // 
            BtnGerarArquivo.BackColor = Color.FromArgb(0, 80, 220);
            BtnGerarArquivo.FlatAppearance.BorderSize = 0;
            BtnGerarArquivo.FlatAppearance.MouseOverBackColor = Color.FromArgb(30, 30, 30);
            BtnGerarArquivo.FlatStyle = FlatStyle.Flat;
            BtnGerarArquivo.Font = new Font("Impact", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGerarArquivo.ForeColor = Color.White;
            BtnGerarArquivo.Location = new Point(250, 540);
            BtnGerarArquivo.Margin = new Padding(0);
            BtnGerarArquivo.Name = "BtnGerarArquivo";
            BtnGerarArquivo.Size = new Size(300, 50);
            BtnGerarArquivo.TabIndex = 2;
            BtnGerarArquivo.Text = "GERAR ARQUIVO";
            BtnGerarArquivo.UseVisualStyleBackColor = false;
            BtnGerarArquivo.Click += BtnGerarArquivo_Click;
            // 
            // LblSN
            // 
            LblSN.BackColor = Color.FromArgb(0, 80, 220);
            LblSN.FlatStyle = FlatStyle.Flat;
            LblSN.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point);
            LblSN.ForeColor = SystemColors.Control;
            LblSN.Location = new Point(50, 85);
            LblSN.Name = "LblSN";
            LblSN.Size = new Size(100, 90);
            LblSN.TabIndex = 7;
            LblSN.Text = "SN";
            LblSN.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblKEY
            // 
            LblKEY.BackColor = Color.FromArgb(0, 80, 220);
            LblKEY.FlatStyle = FlatStyle.Flat;
            LblKEY.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point);
            LblKEY.ForeColor = SystemColors.Control;
            LblKEY.Location = new Point(50, 195);
            LblKEY.Name = "LblKEY";
            LblKEY.Size = new Size(100, 90);
            LblKEY.TabIndex = 8;
            LblKEY.Text = "KEY";
            LblKEY.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblIP
            // 
            LblIP.BackColor = Color.FromArgb(0, 80, 220);
            LblIP.FlatStyle = FlatStyle.Flat;
            LblIP.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point);
            LblIP.ForeColor = SystemColors.Control;
            LblIP.Location = new Point(50, 310);
            LblIP.Name = "LblIP";
            LblIP.Size = new Size(100, 90);
            LblIP.TabIndex = 9;
            LblIP.Text = "IP";
            LblIP.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblMAC
            // 
            LblMAC.BackColor = Color.FromArgb(0, 80, 220);
            LblMAC.FlatStyle = FlatStyle.Flat;
            LblMAC.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point);
            LblMAC.ForeColor = SystemColors.Control;
            LblMAC.Location = new Point(50, 425);
            LblMAC.Name = "LblMAC";
            LblMAC.Size = new Size(100, 90);
            LblMAC.TabIndex = 10;
            LblMAC.Text = "MAC";
            LblMAC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblGapSN
            // 
            LblGapSN.BackColor = Color.FromArgb(0, 80, 220);
            LblGapSN.FlatStyle = FlatStyle.Flat;
            LblGapSN.Location = new Point(135, 85);
            LblGapSN.Margin = new Padding(0);
            LblGapSN.Name = "LblGapSN";
            LblGapSN.Size = new Size(15, 90);
            LblGapSN.TabIndex = 11;
            // 
            // LblGapKEY
            // 
            LblGapKEY.BackColor = Color.FromArgb(0, 80, 220);
            LblGapKEY.FlatStyle = FlatStyle.Flat;
            LblGapKEY.Location = new Point(135, 195);
            LblGapKEY.Margin = new Padding(0);
            LblGapKEY.Name = "LblGapKEY";
            LblGapKEY.Size = new Size(15, 90);
            LblGapKEY.TabIndex = 12;
            // 
            // LblGapIP
            // 
            LblGapIP.BackColor = Color.FromArgb(0, 80, 220);
            LblGapIP.FlatStyle = FlatStyle.Flat;
            LblGapIP.Location = new Point(135, 310);
            LblGapIP.Margin = new Padding(0);
            LblGapIP.Name = "LblGapIP";
            LblGapIP.Size = new Size(15, 90);
            LblGapIP.TabIndex = 13;
            // 
            // LblGapMAC
            // 
            LblGapMAC.BackColor = Color.FromArgb(0, 80, 220);
            LblGapMAC.FlatStyle = FlatStyle.Flat;
            LblGapMAC.Location = new Point(135, 425);
            LblGapMAC.Margin = new Padding(0);
            LblGapMAC.Name = "LblGapMAC";
            LblGapMAC.Size = new Size(15, 90);
            LblGapMAC.TabIndex = 14;
            // 
            // PctbCopyright
            // 
            PctbCopyright.BackColor = Color.FromArgb(0, 80, 220);
            PctbCopyright.BackgroundImage = Windows_System_Info.Properties.Resources.Copyright_icon;
            PctbCopyright.BackgroundImageLayout = ImageLayout.Center;
            PctbCopyright.Location = new Point(13, 617);
            PctbCopyright.Name = "PctbCopyright";
            PctbCopyright.Size = new Size(15, 15);
            PctbCopyright.TabIndex = 16;
            PctbCopyright.TabStop = false;
            // 
            // LblCopyright
            // 
            LblCopyright.BackColor = Color.FromArgb(0, 80, 220);
            LblCopyright.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point);
            LblCopyright.ForeColor = SystemColors.ControlLightLight;
            LblCopyright.Location = new Point(33, 617);
            LblCopyright.Name = "LblCopyright";
            LblCopyright.Size = new Size(771, 20);
            LblCopyright.TabIndex = 17;
            LblCopyright.Text = "Ricardo Bertolotti - Engenharia de Software ( 2023 )          -          Todos os direitos reservados                                                    Versão 7.2    . :        ";
            LblCopyright.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // TbSN
            // 
            TbSN.BackColor = SystemColors.ButtonFace;
            TbSN.BorderStyle = BorderStyle.None;
            TbSN.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            TbSN.ForeColor = Color.Black;
            TbSN.Location = new Point(150, 113);
            TbSN.Margin = new Padding(0);
            TbSN.Name = "TbSN";
            TbSN.ReadOnly = true;
            TbSN.Size = new Size(560, 34);
            TbSN.TabIndex = 18;
            TbSN.TextAlign = HorizontalAlignment.Center;
            // 
            // TbKEY
            // 
            TbKEY.BackColor = SystemColors.ButtonFace;
            TbKEY.BorderStyle = BorderStyle.None;
            TbKEY.Font = new Font("Arial", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            TbKEY.ForeColor = Color.Black;
            TbKEY.Location = new Point(150, 223);
            TbKEY.Margin = new Padding(0);
            TbKEY.Name = "TbKEY";
            TbKEY.ReadOnly = true;
            TbKEY.Size = new Size(560, 32);
            TbKEY.TabIndex = 19;
            TbKEY.TextAlign = HorizontalAlignment.Center;
            // 
            // TbIP
            // 
            TbIP.BackColor = SystemColors.ButtonFace;
            TbIP.BorderStyle = BorderStyle.None;
            TbIP.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            TbIP.ForeColor = Color.Black;
            TbIP.Location = new Point(150, 338);
            TbIP.Margin = new Padding(0);
            TbIP.Name = "TbIP";
            TbIP.ReadOnly = true;
            TbIP.Size = new Size(560, 34);
            TbIP.TabIndex = 20;
            TbIP.TextAlign = HorizontalAlignment.Center;
            // 
            // TbMAC
            // 
            TbMAC.BackColor = SystemColors.ButtonFace;
            TbMAC.BorderStyle = BorderStyle.None;
            TbMAC.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            TbMAC.ForeColor = Color.Black;
            TbMAC.Location = new Point(150, 453);
            TbMAC.Margin = new Padding(0);
            TbMAC.Name = "TbMAC";
            TbMAC.ReadOnly = true;
            TbMAC.Size = new Size(560, 34);
            TbMAC.TabIndex = 21;
            TbMAC.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnCopiarSN
            // 
            BtnCopiarSN.BackColor = SystemColors.ButtonFace;
            BtnCopiarSN.BackgroundImageLayout = ImageLayout.Center;
            BtnCopiarSN.FlatAppearance.BorderSize = 0;
            BtnCopiarSN.FlatStyle = FlatStyle.Flat;
            BtnCopiarSN.ForeColor = SystemColors.ActiveBorder;
            BtnCopiarSN.Image = Windows_System_Info.Properties.Resources.BlueCopy_icon;
            BtnCopiarSN.Location = new Point(710, 85);
            BtnCopiarSN.Margin = new Padding(0);
            BtnCopiarSN.Name = "BtnCopiarSN";
            BtnCopiarSN.Size = new Size(40, 40);
            BtnCopiarSN.TabIndex = 22;
            BtnCopiarSN.UseVisualStyleBackColor = false;
            BtnCopiarSN.Click += BtnCopiarSN_Click;
            // 
            // BtnCopiarKEY
            // 
            BtnCopiarKEY.BackColor = SystemColors.ButtonFace;
            BtnCopiarKEY.BackgroundImageLayout = ImageLayout.Center;
            BtnCopiarKEY.FlatAppearance.BorderSize = 0;
            BtnCopiarKEY.FlatStyle = FlatStyle.Flat;
            BtnCopiarKEY.ForeColor = SystemColors.ActiveBorder;
            BtnCopiarKEY.Image = Windows_System_Info.Properties.Resources.BlueCopy_icon;
            BtnCopiarKEY.Location = new Point(710, 195);
            BtnCopiarKEY.Margin = new Padding(0);
            BtnCopiarKEY.Name = "BtnCopiarKEY";
            BtnCopiarKEY.Size = new Size(40, 40);
            BtnCopiarKEY.TabIndex = 23;
            BtnCopiarKEY.UseVisualStyleBackColor = false;
            BtnCopiarKEY.Click += BtnCopiarKEY_Click;
            // 
            // BtnCopiarIP
            // 
            BtnCopiarIP.BackColor = SystemColors.ButtonFace;
            BtnCopiarIP.BackgroundImageLayout = ImageLayout.Center;
            BtnCopiarIP.FlatAppearance.BorderSize = 0;
            BtnCopiarIP.FlatStyle = FlatStyle.Flat;
            BtnCopiarIP.ForeColor = SystemColors.ActiveBorder;
            BtnCopiarIP.Image = Windows_System_Info.Properties.Resources.BlueCopy_icon;
            BtnCopiarIP.Location = new Point(710, 310);
            BtnCopiarIP.Margin = new Padding(0);
            BtnCopiarIP.Name = "BtnCopiarIP";
            BtnCopiarIP.Size = new Size(40, 40);
            BtnCopiarIP.TabIndex = 24;
            BtnCopiarIP.UseVisualStyleBackColor = false;
            BtnCopiarIP.Click += BtnCopiarIP_Click;
            // 
            // BtnCopiarMAC
            // 
            BtnCopiarMAC.BackColor = SystemColors.ButtonFace;
            BtnCopiarMAC.BackgroundImageLayout = ImageLayout.Center;
            BtnCopiarMAC.FlatAppearance.BorderSize = 0;
            BtnCopiarMAC.FlatStyle = FlatStyle.Flat;
            BtnCopiarMAC.ForeColor = SystemColors.ActiveBorder;
            BtnCopiarMAC.Image = Windows_System_Info.Properties.Resources.BlueCopy_icon;
            BtnCopiarMAC.Location = new Point(710, 425);
            BtnCopiarMAC.Margin = new Padding(0);
            BtnCopiarMAC.Name = "BtnCopiarMAC";
            BtnCopiarMAC.Size = new Size(40, 40);
            BtnCopiarMAC.TabIndex = 25;
            BtnCopiarMAC.UseVisualStyleBackColor = false;
            BtnCopiarMAC.Click += BtnCopiarMAC_Click;
            // 
            // LblSNBack
            // 
            LblSNBack.BackColor = SystemColors.ButtonFace;
            LblSNBack.FlatStyle = FlatStyle.Flat;
            LblSNBack.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point);
            LblSNBack.ForeColor = SystemColors.Control;
            LblSNBack.Location = new Point(50, 85);
            LblSNBack.Name = "LblSNBack";
            LblSNBack.Size = new Size(700, 90);
            LblSNBack.TabIndex = 26;
            LblSNBack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblKEYBack
            // 
            LblKEYBack.BackColor = SystemColors.ButtonFace;
            LblKEYBack.FlatStyle = FlatStyle.Flat;
            LblKEYBack.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point);
            LblKEYBack.ForeColor = SystemColors.Control;
            LblKEYBack.Location = new Point(50, 195);
            LblKEYBack.Name = "LblKEYBack";
            LblKEYBack.Size = new Size(700, 90);
            LblKEYBack.TabIndex = 27;
            LblKEYBack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblIPBack
            // 
            LblIPBack.BackColor = SystemColors.ButtonFace;
            LblIPBack.FlatStyle = FlatStyle.Flat;
            LblIPBack.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point);
            LblIPBack.ForeColor = SystemColors.Control;
            LblIPBack.Location = new Point(50, 310);
            LblIPBack.Name = "LblIPBack";
            LblIPBack.Size = new Size(700, 90);
            LblIPBack.TabIndex = 28;
            LblIPBack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblMACBack
            // 
            LblMACBack.BackColor = SystemColors.ButtonFace;
            LblMACBack.FlatStyle = FlatStyle.Flat;
            LblMACBack.Font = new Font("Impact", 30F, FontStyle.Regular, GraphicsUnit.Point);
            LblMACBack.ForeColor = SystemColors.Control;
            LblMACBack.Location = new Point(50, 425);
            LblMACBack.Name = "LblMACBack";
            LblMACBack.Size = new Size(700, 90);
            LblMACBack.TabIndex = 29;
            LblMACBack.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LblSNCopiado
            // 
            LblSNCopiado.AutoSize = true;
            LblSNCopiado.BackColor = SystemColors.ActiveCaptionText;
            LblSNCopiado.FlatStyle = FlatStyle.Flat;
            LblSNCopiado.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            LblSNCopiado.ForeColor = SystemColors.ControlLightLight;
            LblSNCopiado.Location = new Point(710, 125);
            LblSNCopiado.Name = "LblSNCopiado";
            LblSNCopiado.Size = new Size(51, 15);
            LblSNCopiado.TabIndex = 30;
            LblSNCopiado.Text = "Copiado";
            LblSNCopiado.TextAlign = ContentAlignment.MiddleCenter;
            LblSNCopiado.Visible = false;
            // 
            // LblKEYCopiado
            // 
            LblKEYCopiado.AutoSize = true;
            LblKEYCopiado.BackColor = SystemColors.ActiveCaptionText;
            LblKEYCopiado.FlatStyle = FlatStyle.Flat;
            LblKEYCopiado.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            LblKEYCopiado.ForeColor = SystemColors.ControlLightLight;
            LblKEYCopiado.Location = new Point(710, 235);
            LblKEYCopiado.Name = "LblKEYCopiado";
            LblKEYCopiado.Size = new Size(51, 15);
            LblKEYCopiado.TabIndex = 31;
            LblKEYCopiado.Text = "Copiado";
            LblKEYCopiado.TextAlign = ContentAlignment.MiddleCenter;
            LblKEYCopiado.Visible = false;
            // 
            // LblIPCopiado
            // 
            LblIPCopiado.AutoSize = true;
            LblIPCopiado.BackColor = SystemColors.ActiveCaptionText;
            LblIPCopiado.FlatStyle = FlatStyle.Flat;
            LblIPCopiado.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            LblIPCopiado.ForeColor = SystemColors.ControlLightLight;
            LblIPCopiado.Location = new Point(710, 350);
            LblIPCopiado.Name = "LblIPCopiado";
            LblIPCopiado.Size = new Size(51, 15);
            LblIPCopiado.TabIndex = 32;
            LblIPCopiado.Text = "Copiado";
            LblIPCopiado.TextAlign = ContentAlignment.MiddleCenter;
            LblIPCopiado.Visible = false;
            // 
            // LblMACCopiado
            // 
            LblMACCopiado.AutoSize = true;
            LblMACCopiado.BackColor = SystemColors.ActiveCaptionText;
            LblMACCopiado.FlatStyle = FlatStyle.Flat;
            LblMACCopiado.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            LblMACCopiado.ForeColor = SystemColors.ControlLightLight;
            LblMACCopiado.Location = new Point(710, 465);
            LblMACCopiado.Name = "LblMACCopiado";
            LblMACCopiado.Size = new Size(51, 15);
            LblMACCopiado.TabIndex = 33;
            LblMACCopiado.Text = "Copiado";
            LblMACCopiado.TextAlign = ContentAlignment.MiddleCenter;
            LblMACCopiado.Visible = false;
            // 
            // FormJanelaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 635);
            Controls.Add(LblMACCopiado);
            Controls.Add(LblIPCopiado);
            Controls.Add(LblKEYCopiado);
            Controls.Add(LblSNCopiado);
            Controls.Add(BtnCopiarMAC);
            Controls.Add(BtnCopiarIP);
            Controls.Add(BtnCopiarKEY);
            Controls.Add(BtnCopiarSN);
            Controls.Add(LblCopyright);
            Controls.Add(PctbCopyright);
            Controls.Add(LblGapMAC);
            Controls.Add(LblGapIP);
            Controls.Add(LblGapKEY);
            Controls.Add(LblGapSN);
            Controls.Add(LblMAC);
            Controls.Add(LblIP);
            Controls.Add(LblKEY);
            Controls.Add(LblSN);
            Controls.Add(BtnGerarArquivo);
            Controls.Add(LblRodape);
            Controls.Add(PnlTitulo);
            Controls.Add(TbSN);
            Controls.Add(TbKEY);
            Controls.Add(TbIP);
            Controls.Add(TbMAC);
            Controls.Add(LblSNBack);
            Controls.Add(LblKEYBack);
            Controls.Add(LblIPBack);
            Controls.Add(LblMACBack);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormJanelaPrincipal";
            Text = "WSI";
            Load += FormJanelaPrincipal_Load;
            PnlTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PctbLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)PctbCopyright).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel PnlTitulo;
        private Button BtnMinimizar;
        private Button BtnFechar;
        private Label LblRodape;
        private Button BtnGerarArquivo;
        private Label LblSN;
        private Label LblKEY;
        private Label LblIP;
        private Label LblMAC;
        private Label LblGapSN;
        private Label LblGapKEY;
        private Label LblGapIP;
        private Label LblGapMAC;
        private Label LblTitulo;
        private PictureBox PctbLogo;
        private PictureBox PctbCopyright;
        private Label LblCopyright;
        private TextBox TbSN;
        private TextBox TbKEY;
        private TextBox TbIP;
        private TextBox TbMAC;
        private Button BtnCopiarSN;
        private Button BtnCopiarKEY;
        private Button BtnCopiarIP;
        private Button BtnCopiarMAC;
        private Label LblSNBack;
        private Label LblKEYBack;
        private Label LblIPBack;
        private Label LblMACBack;
        private Button BtnAlterarTema;
        private Label LblSNCopiado;
        private Label LblKEYCopiado;
        private Label LblIPCopiado;
        private Label LblMACCopiado;
    }
}