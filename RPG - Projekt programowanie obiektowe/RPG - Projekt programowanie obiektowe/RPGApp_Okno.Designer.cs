namespace RPG___Projekt_programowanie_obiektowe
{
    partial class RPGApp_Okno
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RPGApp_Okno));
            this.Pnl_TopPanel = new System.Windows.Forms.Panel();
            this.Btn_Minimize = new System.Windows.Forms.Button();
            this.Lbl_Tytul = new System.Windows.Forms.Label();
            this.Pic_Logo = new System.Windows.Forms.PictureBox();
            this.Btn_Exit = new System.Windows.Forms.Button();
            this.Pnl_Odstep1 = new System.Windows.Forms.Panel();
            this.Pnl_LeftPanelMenu = new System.Windows.Forms.Panel();
            this.Btn_LeftMenuOn = new System.Windows.Forms.Button();
            this.Btn_Wyjscie = new System.Windows.Forms.Button();
            this.Btn_Credits = new System.Windows.Forms.Button();
            this.Btn_WczytajGre = new System.Windows.Forms.Button();
            this.Btn_ZapiszGre = new System.Windows.Forms.Button();
            this.Btn_NowaGra = new System.Windows.Forms.Button();
            this.Pnl_Odstep2 = new System.Windows.Forms.Panel();
            this.Pnl_Odstep3 = new System.Windows.Forms.Panel();
            this.Pnl_Odstep4 = new System.Windows.Forms.Panel();
            this.Pnl_BottomPanel = new System.Windows.Forms.Panel();
            this.Pnl_Odstep5 = new System.Windows.Forms.Panel();
            this.Pnl_Odstep6 = new System.Windows.Forms.Panel();
            this.Pnl_NowaGra = new System.Windows.Forms.Panel();
            this.Lbl_CheckPlec = new System.Windows.Forms.Label();
            this.Lbl_CheckNazwaPostaci = new System.Windows.Forms.Label();
            this.Pic_ChooseAvatar = new System.Windows.Forms.PictureBox();
            this.Pnl_OdstepNowaGra = new System.Windows.Forms.Panel();
            this.Lbl_WygladPostaci = new System.Windows.Forms.Label();
            this.Btn_StworzPostac = new System.Windows.Forms.Button();
            this.Btn_CofnijCreatorPostaci = new System.Windows.Forms.Button();
            this.Btn_NextAvatarView = new System.Windows.Forms.Button();
            this.Btn_PrevAvatarView = new System.Windows.Forms.Button();
            this.TBox_NazwaPostaci = new System.Windows.Forms.TextBox();
            this.Lbl_Plec = new System.Windows.Forms.Label();
            this.Lbl_NazwaPostaci = new System.Windows.Forms.Label();
            this.Rdo_Female = new System.Windows.Forms.RadioButton();
            this.Rdo_Male = new System.Windows.Forms.RadioButton();
            this.Pnl_LeftGame = new System.Windows.Forms.Panel();
            this.Cpb_Stamina = new CircularProgressBar.CircularProgressBar();
            this.Cpb_Health = new CircularProgressBar.CircularProgressBar();
            this.Lbl_IloscZlota = new System.Windows.Forms.Label();
            this.Lbl_Zloto = new System.Windows.Forms.Label();
            this.Lbl_Wytrzymalosc = new System.Windows.Forms.Label();
            this.Lbl_Zdrowie = new System.Windows.Forms.Label();
            this.Lbl_MaxDoswiadczenie = new System.Windows.Forms.Label();
            this.Lbl_Doswiadczenie = new System.Windows.Forms.Label();
            this.Lbl_Poziom = new System.Windows.Forms.Label();
            this.Cpb_Exp = new CircularProgressBar.CircularProgressBar();
            this.Pic_Avatar = new System.Windows.Forms.PictureBox();
            this.Btn_LeftMenuOff = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Pnl_WelcomeScreen = new System.Windows.Forms.Panel();
            this.Lbl_PressAnyKeyToContinue = new System.Windows.Forms.Label();
            this.Lbl_TyulWelcomeScreen = new System.Windows.Forms.Label();
            this.Btn_WelcomeScreen = new System.Windows.Forms.Button();
            this.Lbl_Nick = new System.Windows.Forms.Label();
            this.Pnl_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).BeginInit();
            this.Pnl_LeftPanelMenu.SuspendLayout();
            this.Pnl_NowaGra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ChooseAvatar)).BeginInit();
            this.Pnl_LeftGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Avatar)).BeginInit();
            this.Pnl_WelcomeScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pnl_TopPanel
            // 
            this.Pnl_TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(80)))));
            this.Pnl_TopPanel.Controls.Add(this.Btn_Minimize);
            this.Pnl_TopPanel.Controls.Add(this.Lbl_Tytul);
            this.Pnl_TopPanel.Controls.Add(this.Pic_Logo);
            this.Pnl_TopPanel.Controls.Add(this.Btn_Exit);
            this.Pnl_TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_TopPanel.Location = new System.Drawing.Point(0, 0);
            this.Pnl_TopPanel.Name = "Pnl_TopPanel";
            this.Pnl_TopPanel.Size = new System.Drawing.Size(1008, 50);
            this.Pnl_TopPanel.TabIndex = 3;
            this.Pnl_TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_TopPanel_MouseDown);
            // 
            // Btn_Minimize
            // 
            this.Btn_Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.Btn_Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Minimize.Font = new System.Drawing.Font("Swis721 BlkEx BT", 18F, System.Drawing.FontStyle.Italic);
            this.Btn_Minimize.ForeColor = System.Drawing.Color.Red;
            this.Btn_Minimize.Location = new System.Drawing.Point(917, 5);
            this.Btn_Minimize.Name = "Btn_Minimize";
            this.Btn_Minimize.Size = new System.Drawing.Size(40, 40);
            this.Btn_Minimize.TabIndex = 21;
            this.Btn_Minimize.Text = "_";
            this.Btn_Minimize.UseVisualStyleBackColor = false;
            this.Btn_Minimize.Click += new System.EventHandler(this.Btn_Minimize_Click);
            // 
            // Lbl_Tytul
            // 
            this.Lbl_Tytul.AutoSize = true;
            this.Lbl_Tytul.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Tytul.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Tytul.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Lbl_Tytul.Location = new System.Drawing.Point(81, 0);
            this.Lbl_Tytul.Name = "Lbl_Tytul";
            this.Lbl_Tytul.Size = new System.Drawing.Size(587, 47);
            this.Lbl_Tytul.TabIndex = 20;
            this.Lbl_Tytul.Text = "RPG - projekt programowanie obiektowe";
            this.Lbl_Tytul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Tytul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lbl_Tytul_MouseDown);
            // 
            // Pic_Logo
            // 
            this.Pic_Logo.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources._300_Spartan_Workout;
            this.Pic_Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_Logo.Location = new System.Drawing.Point(0, 0);
            this.Pic_Logo.Name = "Pic_Logo";
            this.Pic_Logo.Size = new System.Drawing.Size(75, 50);
            this.Pic_Logo.TabIndex = 1;
            this.Pic_Logo.TabStop = false;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.Btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Exit.Font = new System.Drawing.Font("Swis721 BlkEx BT", 18F, System.Drawing.FontStyle.Italic);
            this.Btn_Exit.ForeColor = System.Drawing.Color.Red;
            this.Btn_Exit.Location = new System.Drawing.Point(963, 5);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(40, 40);
            this.Btn_Exit.TabIndex = 0;
            this.Btn_Exit.Text = "X";
            this.Btn_Exit.UseVisualStyleBackColor = false;
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Pnl_Odstep1
            // 
            this.Pnl_Odstep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.Pnl_Odstep1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_Odstep1.Location = new System.Drawing.Point(0, 50);
            this.Pnl_Odstep1.Name = "Pnl_Odstep1";
            this.Pnl_Odstep1.Size = new System.Drawing.Size(1008, 5);
            this.Pnl_Odstep1.TabIndex = 13;
            // 
            // Pnl_LeftPanelMenu
            // 
            this.Pnl_LeftPanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.Pnl_LeftPanelMenu.Controls.Add(this.Btn_LeftMenuOn);
            this.Pnl_LeftPanelMenu.Controls.Add(this.Btn_Wyjscie);
            this.Pnl_LeftPanelMenu.Controls.Add(this.Btn_Credits);
            this.Pnl_LeftPanelMenu.Controls.Add(this.Btn_WczytajGre);
            this.Pnl_LeftPanelMenu.Controls.Add(this.Btn_ZapiszGre);
            this.Pnl_LeftPanelMenu.Controls.Add(this.Btn_NowaGra);
            this.Pnl_LeftPanelMenu.Location = new System.Drawing.Point(5, 55);
            this.Pnl_LeftPanelMenu.Name = "Pnl_LeftPanelMenu";
            this.Pnl_LeftPanelMenu.Size = new System.Drawing.Size(265, 621);
            this.Pnl_LeftPanelMenu.TabIndex = 14;
            // 
            // Btn_LeftMenuOn
            // 
            this.Btn_LeftMenuOn.BackColor = System.Drawing.Color.Transparent;
            this.Btn_LeftMenuOn.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources.Menu_Button1;
            this.Btn_LeftMenuOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_LeftMenuOn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_LeftMenuOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LeftMenuOn.Location = new System.Drawing.Point(16, 10);
            this.Btn_LeftMenuOn.Name = "Btn_LeftMenuOn";
            this.Btn_LeftMenuOn.Size = new System.Drawing.Size(100, 40);
            this.Btn_LeftMenuOn.TabIndex = 20;
            this.Btn_LeftMenuOn.UseVisualStyleBackColor = false;
            this.Btn_LeftMenuOn.Visible = false;
            this.Btn_LeftMenuOn.Click += new System.EventHandler(this.Btn_LeftMenuOn_Click);
            // 
            // Btn_Wyjscie
            // 
            this.Btn_Wyjscie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Wyjscie.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources.decorative_gold_frame_on_a_black_gradient_background_przycisk;
            this.Btn_Wyjscie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Wyjscie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Wyjscie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Wyjscie.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Wyjscie.ForeColor = System.Drawing.Color.Teal;
            this.Btn_Wyjscie.Location = new System.Drawing.Point(16, 520);
            this.Btn_Wyjscie.Name = "Btn_Wyjscie";
            this.Btn_Wyjscie.Size = new System.Drawing.Size(234, 70);
            this.Btn_Wyjscie.TabIndex = 19;
            this.Btn_Wyjscie.Text = "Wyjście";
            this.Btn_Wyjscie.UseVisualStyleBackColor = true;
            this.Btn_Wyjscie.Click += new System.EventHandler(this.Btn_Wyjscie_Click);
            // 
            // Btn_Credits
            // 
            this.Btn_Credits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Credits.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources.decorative_gold_frame_on_a_black_gradient_background_przycisk;
            this.Btn_Credits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Credits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Credits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Credits.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Credits.ForeColor = System.Drawing.Color.Teal;
            this.Btn_Credits.Location = new System.Drawing.Point(16, 420);
            this.Btn_Credits.Name = "Btn_Credits";
            this.Btn_Credits.Size = new System.Drawing.Size(234, 70);
            this.Btn_Credits.TabIndex = 18;
            this.Btn_Credits.Text = "Credits";
            this.Btn_Credits.UseVisualStyleBackColor = true;
            this.Btn_Credits.Click += new System.EventHandler(this.Btn_Credits_Click);
            // 
            // Btn_WczytajGre
            // 
            this.Btn_WczytajGre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_WczytajGre.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources.decorative_gold_frame_on_a_black_gradient_background_przycisk;
            this.Btn_WczytajGre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_WczytajGre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_WczytajGre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_WczytajGre.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.Btn_WczytajGre.ForeColor = System.Drawing.Color.Teal;
            this.Btn_WczytajGre.Location = new System.Drawing.Point(16, 320);
            this.Btn_WczytajGre.Name = "Btn_WczytajGre";
            this.Btn_WczytajGre.Size = new System.Drawing.Size(234, 70);
            this.Btn_WczytajGre.TabIndex = 17;
            this.Btn_WczytajGre.Text = "Wczytaj grę";
            this.Btn_WczytajGre.UseVisualStyleBackColor = true;
            // 
            // Btn_ZapiszGre
            // 
            this.Btn_ZapiszGre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_ZapiszGre.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources.decorative_gold_frame_on_a_black_gradient_background_przycisk;
            this.Btn_ZapiszGre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_ZapiszGre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ZapiszGre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ZapiszGre.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.Btn_ZapiszGre.ForeColor = System.Drawing.Color.Teal;
            this.Btn_ZapiszGre.Location = new System.Drawing.Point(15, 220);
            this.Btn_ZapiszGre.Name = "Btn_ZapiszGre";
            this.Btn_ZapiszGre.Size = new System.Drawing.Size(235, 70);
            this.Btn_ZapiszGre.TabIndex = 16;
            this.Btn_ZapiszGre.Text = "Zapisz grę";
            this.Btn_ZapiszGre.UseVisualStyleBackColor = true;
            // 
            // Btn_NowaGra
            // 
            this.Btn_NowaGra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_NowaGra.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources.decorative_gold_frame_on_a_black_gradient_background_przycisk;
            this.Btn_NowaGra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_NowaGra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NowaGra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NowaGra.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.Btn_NowaGra.ForeColor = System.Drawing.Color.Teal;
            this.Btn_NowaGra.Location = new System.Drawing.Point(15, 120);
            this.Btn_NowaGra.Name = "Btn_NowaGra";
            this.Btn_NowaGra.Size = new System.Drawing.Size(235, 70);
            this.Btn_NowaGra.TabIndex = 15;
            this.Btn_NowaGra.Text = "Nowa gra";
            this.Btn_NowaGra.UseVisualStyleBackColor = true;
            this.Btn_NowaGra.Click += new System.EventHandler(this.Btn_NowaGra_Click);
            // 
            // Pnl_Odstep2
            // 
            this.Pnl_Odstep2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.Pnl_Odstep2.Location = new System.Drawing.Point(270, 55);
            this.Pnl_Odstep2.Name = "Pnl_Odstep2";
            this.Pnl_Odstep2.Size = new System.Drawing.Size(5, 626);
            this.Pnl_Odstep2.TabIndex = 15;
            // 
            // Pnl_Odstep3
            // 
            this.Pnl_Odstep3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.Pnl_Odstep3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_Odstep3.Location = new System.Drawing.Point(0, 676);
            this.Pnl_Odstep3.Name = "Pnl_Odstep3";
            this.Pnl_Odstep3.Size = new System.Drawing.Size(1008, 5);
            this.Pnl_Odstep3.TabIndex = 17;
            // 
            // Pnl_Odstep4
            // 
            this.Pnl_Odstep4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.Pnl_Odstep4.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_Odstep4.Location = new System.Drawing.Point(1003, 55);
            this.Pnl_Odstep4.Name = "Pnl_Odstep4";
            this.Pnl_Odstep4.Size = new System.Drawing.Size(5, 621);
            this.Pnl_Odstep4.TabIndex = 22;
            // 
            // Pnl_BottomPanel
            // 
            this.Pnl_BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.Pnl_BottomPanel.Location = new System.Drawing.Point(275, 576);
            this.Pnl_BottomPanel.Name = "Pnl_BottomPanel";
            this.Pnl_BottomPanel.Size = new System.Drawing.Size(728, 100);
            this.Pnl_BottomPanel.TabIndex = 24;
            // 
            // Pnl_Odstep5
            // 
            this.Pnl_Odstep5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.Pnl_Odstep5.Location = new System.Drawing.Point(270, 571);
            this.Pnl_Odstep5.Name = "Pnl_Odstep5";
            this.Pnl_Odstep5.Size = new System.Drawing.Size(733, 5);
            this.Pnl_Odstep5.TabIndex = 25;
            // 
            // Pnl_Odstep6
            // 
            this.Pnl_Odstep6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.Pnl_Odstep6.Location = new System.Drawing.Point(0, 55);
            this.Pnl_Odstep6.Name = "Pnl_Odstep6";
            this.Pnl_Odstep6.Size = new System.Drawing.Size(5, 626);
            this.Pnl_Odstep6.TabIndex = 27;
            // 
            // Pnl_NowaGra
            // 
            this.Pnl_NowaGra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.Pnl_NowaGra.Controls.Add(this.Lbl_CheckPlec);
            this.Pnl_NowaGra.Controls.Add(this.Lbl_CheckNazwaPostaci);
            this.Pnl_NowaGra.Controls.Add(this.Pic_ChooseAvatar);
            this.Pnl_NowaGra.Controls.Add(this.Pnl_OdstepNowaGra);
            this.Pnl_NowaGra.Controls.Add(this.Lbl_WygladPostaci);
            this.Pnl_NowaGra.Controls.Add(this.Btn_StworzPostac);
            this.Pnl_NowaGra.Controls.Add(this.Btn_CofnijCreatorPostaci);
            this.Pnl_NowaGra.Controls.Add(this.Btn_NextAvatarView);
            this.Pnl_NowaGra.Controls.Add(this.Btn_PrevAvatarView);
            this.Pnl_NowaGra.Controls.Add(this.TBox_NazwaPostaci);
            this.Pnl_NowaGra.Controls.Add(this.Lbl_Plec);
            this.Pnl_NowaGra.Controls.Add(this.Lbl_NazwaPostaci);
            this.Pnl_NowaGra.Controls.Add(this.Rdo_Female);
            this.Pnl_NowaGra.Controls.Add(this.Rdo_Male);
            this.Pnl_NowaGra.ForeColor = System.Drawing.Color.Teal;
            this.Pnl_NowaGra.Location = new System.Drawing.Point(270, 55);
            this.Pnl_NowaGra.Name = "Pnl_NowaGra";
            this.Pnl_NowaGra.Size = new System.Drawing.Size(733, 516);
            this.Pnl_NowaGra.TabIndex = 28;
            this.Pnl_NowaGra.Visible = false;
            // 
            // Lbl_CheckPlec
            // 
            this.Lbl_CheckPlec.AutoSize = true;
            this.Lbl_CheckPlec.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_CheckPlec.ForeColor = System.Drawing.Color.Red;
            this.Lbl_CheckPlec.Location = new System.Drawing.Point(552, 75);
            this.Lbl_CheckPlec.Name = "Lbl_CheckPlec";
            this.Lbl_CheckPlec.Size = new System.Drawing.Size(0, 26);
            this.Lbl_CheckPlec.TabIndex = 15;
            // 
            // Lbl_CheckNazwaPostaci
            // 
            this.Lbl_CheckNazwaPostaci.AutoSize = true;
            this.Lbl_CheckNazwaPostaci.Font = new System.Drawing.Font("Segoe Print", 11F, System.Drawing.FontStyle.Bold);
            this.Lbl_CheckNazwaPostaci.ForeColor = System.Drawing.Color.Red;
            this.Lbl_CheckNazwaPostaci.Location = new System.Drawing.Point(500, 15);
            this.Lbl_CheckNazwaPostaci.Name = "Lbl_CheckNazwaPostaci";
            this.Lbl_CheckNazwaPostaci.Size = new System.Drawing.Size(0, 26);
            this.Lbl_CheckNazwaPostaci.TabIndex = 13;
            // 
            // Pic_ChooseAvatar
            // 
            this.Pic_ChooseAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.Pic_ChooseAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_ChooseAvatar.Image = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources.Avatar_Unkown1;
            this.Pic_ChooseAvatar.Location = new System.Drawing.Point(235, 200);
            this.Pic_ChooseAvatar.Name = "Pic_ChooseAvatar";
            this.Pic_ChooseAvatar.Size = new System.Drawing.Size(256, 256);
            this.Pic_ChooseAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_ChooseAvatar.TabIndex = 12;
            this.Pic_ChooseAvatar.TabStop = false;
            this.Pic_ChooseAvatar.Visible = false;
            // 
            // Pnl_OdstepNowaGra
            // 
            this.Pnl_OdstepNowaGra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.Pnl_OdstepNowaGra.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_OdstepNowaGra.Location = new System.Drawing.Point(0, 0);
            this.Pnl_OdstepNowaGra.Name = "Pnl_OdstepNowaGra";
            this.Pnl_OdstepNowaGra.Size = new System.Drawing.Size(5, 516);
            this.Pnl_OdstepNowaGra.TabIndex = 11;
            // 
            // Lbl_WygladPostaci
            // 
            this.Lbl_WygladPostaci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_WygladPostaci.AutoSize = true;
            this.Lbl_WygladPostaci.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_WygladPostaci.ForeColor = System.Drawing.Color.Teal;
            this.Lbl_WygladPostaci.Location = new System.Drawing.Point(250, 150);
            this.Lbl_WygladPostaci.Name = "Lbl_WygladPostaci";
            this.Lbl_WygladPostaci.Size = new System.Drawing.Size(225, 47);
            this.Lbl_WygladPostaci.TabIndex = 10;
            this.Lbl_WygladPostaci.Text = "Wygląd postaci";
            this.Lbl_WygladPostaci.Visible = false;
            // 
            // Btn_StworzPostac
            // 
            this.Btn_StworzPostac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_StworzPostac.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources.decorative_gold_frame_on_a_black_gradient_background_przycisk;
            this.Btn_StworzPostac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_StworzPostac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_StworzPostac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_StworzPostac.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.Btn_StworzPostac.ForeColor = System.Drawing.Color.Teal;
            this.Btn_StworzPostac.Location = new System.Drawing.Point(534, 440);
            this.Btn_StworzPostac.Name = "Btn_StworzPostac";
            this.Btn_StworzPostac.Size = new System.Drawing.Size(192, 70);
            this.Btn_StworzPostac.TabIndex = 9;
            this.Btn_StworzPostac.Text = "Stwórz postac";
            this.Btn_StworzPostac.UseVisualStyleBackColor = true;
            this.Btn_StworzPostac.Visible = false;
            this.Btn_StworzPostac.Click += new System.EventHandler(this.Btn_StworzPostac_Click);
            // 
            // Btn_CofnijCreatorPostaci
            // 
            this.Btn_CofnijCreatorPostaci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_CofnijCreatorPostaci.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources.decorative_gold_frame_on_a_black_gradient_background_przycisk;
            this.Btn_CofnijCreatorPostaci.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_CofnijCreatorPostaci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_CofnijCreatorPostaci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_CofnijCreatorPostaci.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.Btn_CofnijCreatorPostaci.ForeColor = System.Drawing.Color.Teal;
            this.Btn_CofnijCreatorPostaci.Location = new System.Drawing.Point(11, 440);
            this.Btn_CofnijCreatorPostaci.Name = "Btn_CofnijCreatorPostaci";
            this.Btn_CofnijCreatorPostaci.Size = new System.Drawing.Size(192, 70);
            this.Btn_CofnijCreatorPostaci.TabIndex = 8;
            this.Btn_CofnijCreatorPostaci.Text = "Cofnij";
            this.Btn_CofnijCreatorPostaci.UseVisualStyleBackColor = true;
            this.Btn_CofnijCreatorPostaci.Visible = false;
            this.Btn_CofnijCreatorPostaci.Click += new System.EventHandler(this.Btn_CofnijCreatorPostaci_Click);
            // 
            // Btn_NextAvatarView
            // 
            this.Btn_NextAvatarView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_NextAvatarView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_NextAvatarView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_NextAvatarView.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.Btn_NextAvatarView.ForeColor = System.Drawing.Color.Teal;
            this.Btn_NextAvatarView.Location = new System.Drawing.Point(497, 303);
            this.Btn_NextAvatarView.Name = "Btn_NextAvatarView";
            this.Btn_NextAvatarView.Size = new System.Drawing.Size(50, 50);
            this.Btn_NextAvatarView.TabIndex = 7;
            this.Btn_NextAvatarView.Text = ">";
            this.Btn_NextAvatarView.UseVisualStyleBackColor = true;
            this.Btn_NextAvatarView.Visible = false;
            this.Btn_NextAvatarView.Click += new System.EventHandler(this.Btn_NextAvatarView_Click);
            // 
            // Btn_PrevAvatarView
            // 
            this.Btn_PrevAvatarView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_PrevAvatarView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_PrevAvatarView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_PrevAvatarView.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.Btn_PrevAvatarView.ForeColor = System.Drawing.Color.Teal;
            this.Btn_PrevAvatarView.Location = new System.Drawing.Point(179, 303);
            this.Btn_PrevAvatarView.Name = "Btn_PrevAvatarView";
            this.Btn_PrevAvatarView.Size = new System.Drawing.Size(50, 50);
            this.Btn_PrevAvatarView.TabIndex = 6;
            this.Btn_PrevAvatarView.Text = "<";
            this.Btn_PrevAvatarView.UseVisualStyleBackColor = true;
            this.Btn_PrevAvatarView.Visible = false;
            this.Btn_PrevAvatarView.Click += new System.EventHandler(this.Btn_PrevAvatarView_Click);
            // 
            // TBox_NazwaPostaci
            // 
            this.TBox_NazwaPostaci.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBox_NazwaPostaci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TBox_NazwaPostaci.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.TBox_NazwaPostaci.Location = new System.Drawing.Point(235, 15);
            this.TBox_NazwaPostaci.MaxLength = 15;
            this.TBox_NazwaPostaci.Name = "TBox_NazwaPostaci";
            this.TBox_NazwaPostaci.Size = new System.Drawing.Size(256, 55);
            this.TBox_NazwaPostaci.TabIndex = 5;
            this.TBox_NazwaPostaci.Visible = false;
            this.TBox_NazwaPostaci.Leave += new System.EventHandler(this.TBox_NazwaPostaci_Leave);
            // 
            // Lbl_Plec
            // 
            this.Lbl_Plec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Plec.AutoSize = true;
            this.Lbl_Plec.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Plec.ForeColor = System.Drawing.Color.Teal;
            this.Lbl_Plec.Location = new System.Drawing.Point(20, 75);
            this.Lbl_Plec.Name = "Lbl_Plec";
            this.Lbl_Plec.Size = new System.Drawing.Size(77, 47);
            this.Lbl_Plec.TabIndex = 4;
            this.Lbl_Plec.Text = "Płeć";
            this.Lbl_Plec.Visible = false;
            // 
            // Lbl_NazwaPostaci
            // 
            this.Lbl_NazwaPostaci.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_NazwaPostaci.AutoSize = true;
            this.Lbl_NazwaPostaci.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_NazwaPostaci.ForeColor = System.Drawing.Color.Teal;
            this.Lbl_NazwaPostaci.Location = new System.Drawing.Point(20, 15);
            this.Lbl_NazwaPostaci.Name = "Lbl_NazwaPostaci";
            this.Lbl_NazwaPostaci.Size = new System.Drawing.Size(217, 47);
            this.Lbl_NazwaPostaci.TabIndex = 3;
            this.Lbl_NazwaPostaci.Text = "Nazwa postaci";
            this.Lbl_NazwaPostaci.Visible = false;
            // 
            // Rdo_Female
            // 
            this.Rdo_Female.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rdo_Female.Appearance = System.Windows.Forms.Appearance.Button;
            this.Rdo_Female.AutoSize = true;
            this.Rdo_Female.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rdo_Female.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rdo_Female.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.Rdo_Female.ForeColor = System.Drawing.Color.Teal;
            this.Rdo_Female.Location = new System.Drawing.Point(365, 75);
            this.Rdo_Female.MinimumSize = new System.Drawing.Size(180, 60);
            this.Rdo_Female.Name = "Rdo_Female";
            this.Rdo_Female.Size = new System.Drawing.Size(180, 60);
            this.Rdo_Female.TabIndex = 2;
            this.Rdo_Female.TabStop = true;
            this.Rdo_Female.Text = "Kobieta";
            this.Rdo_Female.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Rdo_Female.UseVisualStyleBackColor = true;
            this.Rdo_Female.Visible = false;
            this.Rdo_Female.CheckedChanged += new System.EventHandler(this.Rdo_Female_CheckedChanged);
            // 
            // Rdo_Male
            // 
            this.Rdo_Male.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Rdo_Male.Appearance = System.Windows.Forms.Appearance.Button;
            this.Rdo_Male.AutoSize = true;
            this.Rdo_Male.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rdo_Male.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rdo_Male.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.Rdo_Male.ForeColor = System.Drawing.Color.Teal;
            this.Rdo_Male.Location = new System.Drawing.Point(175, 75);
            this.Rdo_Male.MinimumSize = new System.Drawing.Size(180, 60);
            this.Rdo_Male.Name = "Rdo_Male";
            this.Rdo_Male.Size = new System.Drawing.Size(180, 60);
            this.Rdo_Male.TabIndex = 1;
            this.Rdo_Male.TabStop = true;
            this.Rdo_Male.Text = "Mężczyzna";
            this.Rdo_Male.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Rdo_Male.UseVisualStyleBackColor = true;
            this.Rdo_Male.Visible = false;
            this.Rdo_Male.CheckedChanged += new System.EventHandler(this.Rdo_Male_CheckedChanged);
            // 
            // Pnl_LeftGame
            // 
            this.Pnl_LeftGame.Controls.Add(this.Lbl_Nick);
            this.Pnl_LeftGame.Controls.Add(this.Cpb_Stamina);
            this.Pnl_LeftGame.Controls.Add(this.Cpb_Health);
            this.Pnl_LeftGame.Controls.Add(this.Lbl_IloscZlota);
            this.Pnl_LeftGame.Controls.Add(this.Lbl_Zloto);
            this.Pnl_LeftGame.Controls.Add(this.Lbl_Wytrzymalosc);
            this.Pnl_LeftGame.Controls.Add(this.Lbl_Zdrowie);
            this.Pnl_LeftGame.Controls.Add(this.Lbl_MaxDoswiadczenie);
            this.Pnl_LeftGame.Controls.Add(this.Lbl_Doswiadczenie);
            this.Pnl_LeftGame.Controls.Add(this.Lbl_Poziom);
            this.Pnl_LeftGame.Controls.Add(this.Cpb_Exp);
            this.Pnl_LeftGame.Controls.Add(this.Pic_Avatar);
            this.Pnl_LeftGame.Controls.Add(this.Btn_LeftMenuOff);
            this.Pnl_LeftGame.Location = new System.Drawing.Point(5, 55);
            this.Pnl_LeftGame.Name = "Pnl_LeftGame";
            this.Pnl_LeftGame.Size = new System.Drawing.Size(265, 621);
            this.Pnl_LeftGame.TabIndex = 29;
            // 
            // Cpb_Stamina
            // 
            this.Cpb_Stamina.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("Cpb_Stamina.AnimationFunction")));
            this.Cpb_Stamina.AnimationSpeed = 500;
            this.Cpb_Stamina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.Cpb_Stamina.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.Cpb_Stamina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cpb_Stamina.InnerColor = System.Drawing.Color.Transparent;
            this.Cpb_Stamina.InnerMargin = 2;
            this.Cpb_Stamina.InnerWidth = -1;
            this.Cpb_Stamina.Location = new System.Drawing.Point(10, 449);
            this.Cpb_Stamina.MarqueeAnimationSpeed = 2000;
            this.Cpb_Stamina.Name = "Cpb_Stamina";
            this.Cpb_Stamina.OuterColor = System.Drawing.Color.Gray;
            this.Cpb_Stamina.OuterMargin = -20;
            this.Cpb_Stamina.OuterWidth = 21;
            this.Cpb_Stamina.ProgressColor = System.Drawing.Color.Blue;
            this.Cpb_Stamina.ProgressWidth = 20;
            this.Cpb_Stamina.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Cpb_Stamina.Size = new System.Drawing.Size(250, 46);
            this.Cpb_Stamina.StartAngle = 180;
            this.Cpb_Stamina.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Cpb_Stamina.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.Cpb_Stamina.SubscriptText = ".23";
            this.Cpb_Stamina.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Cpb_Stamina.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Cpb_Stamina.SuperscriptText = "";
            this.Cpb_Stamina.TabIndex = 55;
            this.Cpb_Stamina.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Cpb_Stamina.Value = 50;
            this.Cpb_Stamina.Visible = false;
            // 
            // Cpb_Health
            // 
            this.Cpb_Health.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("Cpb_Health.AnimationFunction")));
            this.Cpb_Health.AnimationSpeed = 500;
            this.Cpb_Health.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.Cpb_Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.Cpb_Health.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cpb_Health.InnerColor = System.Drawing.Color.Transparent;
            this.Cpb_Health.InnerMargin = 2;
            this.Cpb_Health.InnerWidth = -1;
            this.Cpb_Health.Location = new System.Drawing.Point(10, 349);
            this.Cpb_Health.MarqueeAnimationSpeed = 2000;
            this.Cpb_Health.Name = "Cpb_Health";
            this.Cpb_Health.OuterColor = System.Drawing.Color.Gray;
            this.Cpb_Health.OuterMargin = -20;
            this.Cpb_Health.OuterWidth = 21;
            this.Cpb_Health.ProgressColor = System.Drawing.Color.Red;
            this.Cpb_Health.ProgressWidth = 20;
            this.Cpb_Health.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Cpb_Health.Size = new System.Drawing.Size(250, 46);
            this.Cpb_Health.StartAngle = 180;
            this.Cpb_Health.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Cpb_Health.SubscriptMargin = new System.Windows.Forms.Padding(0);
            this.Cpb_Health.SubscriptText = ".23";
            this.Cpb_Health.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Cpb_Health.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Cpb_Health.SuperscriptText = "";
            this.Cpb_Health.TabIndex = 54;
            this.Cpb_Health.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Cpb_Health.Value = 50;
            this.Cpb_Health.Visible = false;
            // 
            // Lbl_IloscZlota
            // 
            this.Lbl_IloscZlota.AutoSize = true;
            this.Lbl_IloscZlota.Font = new System.Drawing.Font("Segoe Print", 12.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_IloscZlota.ForeColor = System.Drawing.Color.Gold;
            this.Lbl_IloscZlota.Location = new System.Drawing.Point(147, 529);
            this.Lbl_IloscZlota.Name = "Lbl_IloscZlota";
            this.Lbl_IloscZlota.Size = new System.Drawing.Size(61, 30);
            this.Lbl_IloscZlota.TabIndex = 53;
            this.Lbl_IloscZlota.Text = "9999";
            this.Lbl_IloscZlota.Visible = false;
            // 
            // Lbl_Zloto
            // 
            this.Lbl_Zloto.AutoSize = true;
            this.Lbl_Zloto.Font = new System.Drawing.Font("Segoe Print", 12.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Zloto.ForeColor = System.Drawing.Color.Gold;
            this.Lbl_Zloto.Location = new System.Drawing.Point(40, 529);
            this.Lbl_Zloto.Name = "Lbl_Zloto";
            this.Lbl_Zloto.Size = new System.Drawing.Size(66, 30);
            this.Lbl_Zloto.TabIndex = 52;
            this.Lbl_Zloto.Text = "Złoto:";
            this.Lbl_Zloto.Visible = false;
            // 
            // Lbl_Wytrzymalosc
            // 
            this.Lbl_Wytrzymalosc.AutoSize = true;
            this.Lbl_Wytrzymalosc.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Wytrzymalosc.ForeColor = System.Drawing.Color.Blue;
            this.Lbl_Wytrzymalosc.Location = new System.Drawing.Point(64, 413);
            this.Lbl_Wytrzymalosc.Name = "Lbl_Wytrzymalosc";
            this.Lbl_Wytrzymalosc.Size = new System.Drawing.Size(151, 33);
            this.Lbl_Wytrzymalosc.TabIndex = 51;
            this.Lbl_Wytrzymalosc.Text = "Wytrzymałość";
            this.Lbl_Wytrzymalosc.Visible = false;
            // 
            // Lbl_Zdrowie
            // 
            this.Lbl_Zdrowie.AutoSize = true;
            this.Lbl_Zdrowie.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Zdrowie.ForeColor = System.Drawing.Color.Red;
            this.Lbl_Zdrowie.Location = new System.Drawing.Point(85, 306);
            this.Lbl_Zdrowie.Name = "Lbl_Zdrowie";
            this.Lbl_Zdrowie.Size = new System.Drawing.Size(96, 33);
            this.Lbl_Zdrowie.TabIndex = 50;
            this.Lbl_Zdrowie.Text = "Zdrowie";
            this.Lbl_Zdrowie.Visible = false;
            // 
            // Lbl_MaxDoswiadczenie
            // 
            this.Lbl_MaxDoswiadczenie.AutoSize = true;
            this.Lbl_MaxDoswiadczenie.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_MaxDoswiadczenie.Font = new System.Drawing.Font("Segoe Print", 9.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_MaxDoswiadczenie.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_MaxDoswiadczenie.Location = new System.Drawing.Point(55, 114);
            this.Lbl_MaxDoswiadczenie.MinimumSize = new System.Drawing.Size(60, 24);
            this.Lbl_MaxDoswiadczenie.Name = "Lbl_MaxDoswiadczenie";
            this.Lbl_MaxDoswiadczenie.Size = new System.Drawing.Size(62, 24);
            this.Lbl_MaxDoswiadczenie.TabIndex = 49;
            this.Lbl_MaxDoswiadczenie.Text = "/99999";
            this.Lbl_MaxDoswiadczenie.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Lbl_MaxDoswiadczenie.Visible = false;
            // 
            // Lbl_Doswiadczenie
            // 
            this.Lbl_Doswiadczenie.AutoSize = true;
            this.Lbl_Doswiadczenie.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Doswiadczenie.Font = new System.Drawing.Font("Segoe Print", 9.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Doswiadczenie.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_Doswiadczenie.Location = new System.Drawing.Point(8, 95);
            this.Lbl_Doswiadczenie.MinimumSize = new System.Drawing.Size(60, 24);
            this.Lbl_Doswiadczenie.Name = "Lbl_Doswiadczenie";
            this.Lbl_Doswiadczenie.Size = new System.Drawing.Size(60, 24);
            this.Lbl_Doswiadczenie.TabIndex = 48;
            this.Lbl_Doswiadczenie.Text = "99999";
            this.Lbl_Doswiadczenie.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Lbl_Doswiadczenie.Visible = false;
            // 
            // Lbl_Poziom
            // 
            this.Lbl_Poziom.AutoSize = true;
            this.Lbl_Poziom.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Poziom.Font = new System.Drawing.Font("Segoe Print", 12.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Poziom.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_Poziom.Location = new System.Drawing.Point(16, 53);
            this.Lbl_Poziom.Name = "Lbl_Poziom";
            this.Lbl_Poziom.Size = new System.Drawing.Size(95, 30);
            this.Lbl_Poziom.TabIndex = 47;
            this.Lbl_Poziom.Text = "Poziom X";
            this.Lbl_Poziom.Visible = false;
            // 
            // Cpb_Exp
            // 
            this.Cpb_Exp.AnimationFunction = ((WinFormAnimation.AnimationFunctions.Function)(resources.GetObject("Cpb_Exp.AnimationFunction")));
            this.Cpb_Exp.AnimationSpeed = 2000;
            this.Cpb_Exp.BackColor = System.Drawing.Color.DimGray;
            this.Cpb_Exp.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources.decorative_gold_frame_on_a_black_gradient_background_przycisk;
            this.Cpb_Exp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cpb_Exp.Cursor = System.Windows.Forms.Cursors.Default;
            this.Cpb_Exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.Cpb_Exp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Cpb_Exp.InnerColor = System.Drawing.Color.Teal;
            this.Cpb_Exp.InnerMargin = 1;
            this.Cpb_Exp.InnerWidth = -1;
            this.Cpb_Exp.Location = new System.Drawing.Point(119, 6);
            this.Cpb_Exp.Margin = new System.Windows.Forms.Padding(0);
            this.Cpb_Exp.MarqueeAnimationSpeed = 2000;
            this.Cpb_Exp.Maximum = 0;
            this.Cpb_Exp.Name = "Cpb_Exp";
            this.Cpb_Exp.OuterColor = System.Drawing.Color.Black;
            this.Cpb_Exp.OuterMargin = 2;
            this.Cpb_Exp.OuterWidth = 1;
            this.Cpb_Exp.ProgressColor = System.Drawing.Color.Lime;
            this.Cpb_Exp.ProgressWidth = 5;
            this.Cpb_Exp.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Cpb_Exp.Size = new System.Drawing.Size(140, 140);
            this.Cpb_Exp.StartAngle = 270;
            this.Cpb_Exp.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Cpb_Exp.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Cpb_Exp.SubscriptText = ".23";
            this.Cpb_Exp.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Cpb_Exp.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Cpb_Exp.SuperscriptText = "";
            this.Cpb_Exp.TabIndex = 45;
            this.Cpb_Exp.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Cpb_Exp.Visible = false;
            // 
            // Pic_Avatar
            // 
            this.Pic_Avatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic_Avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.Pic_Avatar.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources.Male2;
            this.Pic_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_Avatar.Location = new System.Drawing.Point(83, 201);
            this.Pic_Avatar.Name = "Pic_Avatar";
            this.Pic_Avatar.Size = new System.Drawing.Size(100, 100);
            this.Pic_Avatar.TabIndex = 46;
            this.Pic_Avatar.TabStop = false;
            this.Pic_Avatar.Visible = false;
            // 
            // Btn_LeftMenuOff
            // 
            this.Btn_LeftMenuOff.BackColor = System.Drawing.Color.Transparent;
            this.Btn_LeftMenuOff.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources.Menu_Button2;
            this.Btn_LeftMenuOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_LeftMenuOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_LeftMenuOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LeftMenuOff.Location = new System.Drawing.Point(10, 10);
            this.Btn_LeftMenuOff.Name = "Btn_LeftMenuOff";
            this.Btn_LeftMenuOff.Size = new System.Drawing.Size(40, 40);
            this.Btn_LeftMenuOff.TabIndex = 21;
            this.Btn_LeftMenuOff.UseVisualStyleBackColor = false;
            this.Btn_LeftMenuOff.Visible = false;
            this.Btn_LeftMenuOff.Click += new System.EventHandler(this.Btn_LeftMenuOff_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Pnl_WelcomeScreen
            // 
            this.Pnl_WelcomeScreen.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources.Kraty;
            this.Pnl_WelcomeScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pnl_WelcomeScreen.Controls.Add(this.Lbl_PressAnyKeyToContinue);
            this.Pnl_WelcomeScreen.Controls.Add(this.Lbl_TyulWelcomeScreen);
            this.Pnl_WelcomeScreen.Controls.Add(this.Btn_WelcomeScreen);
            this.Pnl_WelcomeScreen.Location = new System.Drawing.Point(5, 55);
            this.Pnl_WelcomeScreen.Name = "Pnl_WelcomeScreen";
            this.Pnl_WelcomeScreen.Size = new System.Drawing.Size(998, 621);
            this.Pnl_WelcomeScreen.TabIndex = 30;
            // 
            // Lbl_PressAnyKeyToContinue
            // 
            this.Lbl_PressAnyKeyToContinue.AutoSize = true;
            this.Lbl_PressAnyKeyToContinue.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_PressAnyKeyToContinue.Font = new System.Drawing.Font("Segoe Print", 20F, System.Drawing.FontStyle.Bold);
            this.Lbl_PressAnyKeyToContinue.ForeColor = System.Drawing.Color.Red;
            this.Lbl_PressAnyKeyToContinue.Location = new System.Drawing.Point(160, 287);
            this.Lbl_PressAnyKeyToContinue.Name = "Lbl_PressAnyKeyToContinue";
            this.Lbl_PressAnyKeyToContinue.Size = new System.Drawing.Size(679, 47);
            this.Lbl_PressAnyKeyToContinue.TabIndex = 2;
            this.Lbl_PressAnyKeyToContinue.Text = "- Naciśnij dowolny przycisk aby kontynuować -";
            this.Lbl_PressAnyKeyToContinue.Click += new System.EventHandler(this.Lbl_PressAnyKeyToContinue_Click);
            // 
            // Lbl_TyulWelcomeScreen
            // 
            this.Lbl_TyulWelcomeScreen.AutoSize = true;
            this.Lbl_TyulWelcomeScreen.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_TyulWelcomeScreen.Font = new System.Drawing.Font("Segoe Print", 28F, System.Drawing.FontStyle.Bold);
            this.Lbl_TyulWelcomeScreen.ForeColor = System.Drawing.Color.Red;
            this.Lbl_TyulWelcomeScreen.Location = new System.Drawing.Point(85, 46);
            this.Lbl_TyulWelcomeScreen.Name = "Lbl_TyulWelcomeScreen";
            this.Lbl_TyulWelcomeScreen.Size = new System.Drawing.Size(820, 68);
            this.Lbl_TyulWelcomeScreen.TabIndex = 1;
            this.Lbl_TyulWelcomeScreen.Text = "RPG - projekt programowanie obiektowe";
            this.Lbl_TyulWelcomeScreen.Click += new System.EventHandler(this.Lbl_TyulWelcomeScreen_Click);
            // 
            // Btn_WelcomeScreen
            // 
            this.Btn_WelcomeScreen.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources.Kraty;
            this.Btn_WelcomeScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_WelcomeScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_WelcomeScreen.Location = new System.Drawing.Point(0, 0);
            this.Btn_WelcomeScreen.Name = "Btn_WelcomeScreen";
            this.Btn_WelcomeScreen.Size = new System.Drawing.Size(998, 621);
            this.Btn_WelcomeScreen.TabIndex = 3;
            this.Btn_WelcomeScreen.UseVisualStyleBackColor = true;
            this.Btn_WelcomeScreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Btn_WelcomeScreen_KeyPress);
            this.Btn_WelcomeScreen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_WelcomeScreen_MouseClick);
            // 
            // Lbl_Nick
            // 
            this.Lbl_Nick.AutoSize = true;
            this.Lbl_Nick.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Lbl_Nick.Location = new System.Drawing.Point(5, 155);
            this.Lbl_Nick.MinimumSize = new System.Drawing.Size(255, 0);
            this.Lbl_Nick.Name = "Lbl_Nick";
            this.Lbl_Nick.Size = new System.Drawing.Size(255, 43);
            this.Lbl_Nick.TabIndex = 56;
            this.Lbl_Nick.Text = "Nick";
            this.Lbl_Nick.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Nick.Visible = false;
            // 
            // RPGApp_Okno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.Pnl_WelcomeScreen);
            this.Controls.Add(this.Pnl_LeftPanelMenu);
            this.Controls.Add(this.Pnl_LeftGame);
            this.Controls.Add(this.Pnl_NowaGra);
            this.Controls.Add(this.Pnl_Odstep6);
            this.Controls.Add(this.Pnl_Odstep5);
            this.Controls.Add(this.Pnl_BottomPanel);
            this.Controls.Add(this.Pnl_Odstep4);
            this.Controls.Add(this.Pnl_Odstep3);
            this.Controls.Add(this.Pnl_Odstep2);
            this.Controls.Add(this.Pnl_Odstep1);
            this.Controls.Add(this.Pnl_TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RPGApp_Okno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WelcomeScreen_Load);
            this.Pnl_TopPanel.ResumeLayout(false);
            this.Pnl_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Logo)).EndInit();
            this.Pnl_LeftPanelMenu.ResumeLayout(false);
            this.Pnl_NowaGra.ResumeLayout(false);
            this.Pnl_NowaGra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_ChooseAvatar)).EndInit();
            this.Pnl_LeftGame.ResumeLayout(false);
            this.Pnl_LeftGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Avatar)).EndInit();
            this.Pnl_WelcomeScreen.ResumeLayout(false);
            this.Pnl_WelcomeScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Pnl_TopPanel;
        private System.Windows.Forms.Button Btn_Exit;
        private System.Windows.Forms.PictureBox Pic_Logo;
        private System.Windows.Forms.Panel Pnl_Odstep1;
        private System.Windows.Forms.Panel Pnl_LeftPanelMenu;
        private System.Windows.Forms.Button Btn_Wyjscie;
        private System.Windows.Forms.Button Btn_Credits;
        private System.Windows.Forms.Button Btn_WczytajGre;
        private System.Windows.Forms.Button Btn_ZapiszGre;
        private System.Windows.Forms.Button Btn_NowaGra;
        private System.Windows.Forms.Panel Pnl_Odstep2;
        private System.Windows.Forms.Panel Pnl_Odstep3;
        private System.Windows.Forms.Label Lbl_Tytul;
        private System.Windows.Forms.Button Btn_LeftMenuOn;
        private System.Windows.Forms.Button Btn_LeftMenuOff;
        private System.Windows.Forms.Panel Pnl_Odstep4;
        private System.Windows.Forms.Panel Pnl_BottomPanel;
        private System.Windows.Forms.Panel Pnl_Odstep5;
        private System.Windows.Forms.Panel Pnl_Odstep6;
        private System.Windows.Forms.Panel Pnl_NowaGra;
        private System.Windows.Forms.Button Btn_NextAvatarView;
        private System.Windows.Forms.Button Btn_PrevAvatarView;
        private System.Windows.Forms.TextBox TBox_NazwaPostaci;
        private System.Windows.Forms.Label Lbl_Plec;
        private System.Windows.Forms.Label Lbl_NazwaPostaci;
        private System.Windows.Forms.RadioButton Rdo_Female;
        private System.Windows.Forms.RadioButton Rdo_Male;
        private System.Windows.Forms.Button Btn_StworzPostac;
        private System.Windows.Forms.Button Btn_CofnijCreatorPostaci;
        private System.Windows.Forms.Label Lbl_WygladPostaci;
        private System.Windows.Forms.Panel Pnl_OdstepNowaGra;
        private System.Windows.Forms.PictureBox Pic_ChooseAvatar;
        private System.Windows.Forms.Button Btn_Minimize;
        private System.Windows.Forms.Panel Pnl_LeftGame;
        private System.Windows.Forms.Label Lbl_CheckNazwaPostaci;
        private System.Windows.Forms.Label Lbl_CheckPlec;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Lbl_TyulWelcomeScreen;
        private System.Windows.Forms.Label Lbl_PressAnyKeyToContinue;
        private System.Windows.Forms.Panel Pnl_WelcomeScreen;
        private System.Windows.Forms.Button Btn_WelcomeScreen;
        internal CircularProgressBar.CircularProgressBar Cpb_Stamina;
        internal CircularProgressBar.CircularProgressBar Cpb_Health;
        internal System.Windows.Forms.Label Lbl_IloscZlota;
        internal System.Windows.Forms.Label Lbl_Zloto;
        internal System.Windows.Forms.Label Lbl_Wytrzymalosc;
        internal System.Windows.Forms.Label Lbl_Zdrowie;
        internal System.Windows.Forms.Label Lbl_MaxDoswiadczenie;
        internal System.Windows.Forms.Label Lbl_Doswiadczenie;
        internal System.Windows.Forms.Label Lbl_Poziom;
        internal CircularProgressBar.CircularProgressBar Cpb_Exp;
        internal System.Windows.Forms.PictureBox Pic_Avatar;
        private System.Windows.Forms.Label Lbl_Nick;
    }
}
