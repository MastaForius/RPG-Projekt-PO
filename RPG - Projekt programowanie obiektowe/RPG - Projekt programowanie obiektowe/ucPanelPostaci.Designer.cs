namespace RPG___Projekt_programowanie_obiektowe
{
    partial class ucPanelPostaci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPanelPostaci));
            this.Pnl_Hero = new System.Windows.Forms.Panel();
            this.Pnl_Odstep1 = new System.Windows.Forms.Panel();
            this.Btn_LeftMenuOff = new System.Windows.Forms.Button();
            this.Cpb_Exp = new CircularProgressBar.CircularProgressBar();
            this.Pic_Avatar = new System.Windows.Forms.PictureBox();
            this.Lbl_Poziom = new System.Windows.Forms.Label();
            this.Lbl_Doswiadczenie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pnl_Zdrowie = new System.Windows.Forms.Label();
            this.Pnl_Wytrzymalosc = new System.Windows.Forms.Label();
            this.Lbl_Zloto = new System.Windows.Forms.Label();
            this.Lbl_IloscZlota = new System.Windows.Forms.Label();
            this.Cpb_Health = new CircularProgressBar.CircularProgressBar();
            this.Cpb_Stamina = new CircularProgressBar.CircularProgressBar();
            this.Pnl_Hero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // Pnl_Hero
            // 
            this.Pnl_Hero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.Pnl_Hero.Controls.Add(this.Cpb_Stamina);
            this.Pnl_Hero.Controls.Add(this.Cpb_Health);
            this.Pnl_Hero.Controls.Add(this.Lbl_IloscZlota);
            this.Pnl_Hero.Controls.Add(this.Lbl_Zloto);
            this.Pnl_Hero.Controls.Add(this.Pnl_Wytrzymalosc);
            this.Pnl_Hero.Controls.Add(this.Pnl_Zdrowie);
            this.Pnl_Hero.Controls.Add(this.label2);
            this.Pnl_Hero.Controls.Add(this.Lbl_Doswiadczenie);
            this.Pnl_Hero.Controls.Add(this.Lbl_Poziom);
            this.Pnl_Hero.Controls.Add(this.Btn_LeftMenuOff);
            this.Pnl_Hero.Controls.Add(this.Cpb_Exp);
            this.Pnl_Hero.Controls.Add(this.Pic_Avatar);
            this.Pnl_Hero.Controls.Add(this.Pnl_Odstep1);
            this.Pnl_Hero.Location = new System.Drawing.Point(0, 0);
            this.Pnl_Hero.Name = "Pnl_Hero";
            this.Pnl_Hero.Size = new System.Drawing.Size(270, 621);
            this.Pnl_Hero.TabIndex = 0;
            // 
            // Pnl_Odstep1
            // 
            this.Pnl_Odstep1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.Pnl_Odstep1.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_Odstep1.Location = new System.Drawing.Point(265, 0);
            this.Pnl_Odstep1.Name = "Pnl_Odstep1";
            this.Pnl_Odstep1.Size = new System.Drawing.Size(5, 621);
            this.Pnl_Odstep1.TabIndex = 30;
            // 
            // Btn_LeftMenuOff
            // 
            this.Btn_LeftMenuOff.BackColor = System.Drawing.Color.Transparent;
            this.Btn_LeftMenuOff.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources.Menu_Button2;
            this.Btn_LeftMenuOff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_LeftMenuOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_LeftMenuOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_LeftMenuOff.Location = new System.Drawing.Point(15, 5);
            this.Btn_LeftMenuOff.Name = "Btn_LeftMenuOff";
            this.Btn_LeftMenuOff.Size = new System.Drawing.Size(40, 40);
            this.Btn_LeftMenuOff.TabIndex = 31;
            this.Btn_LeftMenuOff.UseVisualStyleBackColor = false;
            this.Btn_LeftMenuOff.Visible = false;
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
            this.Cpb_Exp.Location = new System.Drawing.Point(5, 50);
            this.Cpb_Exp.Margin = new System.Windows.Forms.Padding(0);
            this.Cpb_Exp.MarqueeAnimationSpeed = 2000;
            this.Cpb_Exp.Maximum = 720;
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
            this.Cpb_Exp.SuperscriptText = "%";
            this.Cpb_Exp.TabIndex = 32;
            this.Cpb_Exp.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Cpb_Exp.Value = 180;
            this.Cpb_Exp.Visible = false;
            // 
            // Pic_Avatar
            // 
            this.Pic_Avatar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Pic_Avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.Pic_Avatar.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources.Male2;
            this.Pic_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_Avatar.Location = new System.Drawing.Point(155, 90);
            this.Pic_Avatar.Name = "Pic_Avatar";
            this.Pic_Avatar.Size = new System.Drawing.Size(100, 100);
            this.Pic_Avatar.TabIndex = 33;
            this.Pic_Avatar.TabStop = false;
            this.Pic_Avatar.Visible = false;
            // 
            // Lbl_Poziom
            // 
            this.Lbl_Poziom.AutoSize = true;
            this.Lbl_Poziom.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Poziom.Font = new System.Drawing.Font("Segoe Print", 12.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Poziom.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_Poziom.Location = new System.Drawing.Point(151, 50);
            this.Lbl_Poziom.Name = "Lbl_Poziom";
            this.Lbl_Poziom.Size = new System.Drawing.Size(95, 30);
            this.Lbl_Poziom.TabIndex = 34;
            this.Lbl_Poziom.Text = "Poziom X";
            this.Lbl_Poziom.Visible = false;
            // 
            // Lbl_Doswiadczenie
            // 
            this.Lbl_Doswiadczenie.AutoSize = true;
            this.Lbl_Doswiadczenie.BackColor = System.Drawing.Color.Teal;
            this.Lbl_Doswiadczenie.Font = new System.Drawing.Font("Segoe Print", 10.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Doswiadczenie.ForeColor = System.Drawing.Color.Lime;
            this.Lbl_Doswiadczenie.Location = new System.Drawing.Point(25, 95);
            this.Lbl_Doswiadczenie.Name = "Lbl_Doswiadczenie";
            this.Lbl_Doswiadczenie.Size = new System.Drawing.Size(70, 24);
            this.Lbl_Doswiadczenie.TabIndex = 37;
            this.Lbl_Doswiadczenie.Text = "999999";
            this.Lbl_Doswiadczenie.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 10.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(59, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 38;
            this.label2.Text = "999999";
            this.label2.Visible = false;
            // 
            // Pnl_Zdrowie
            // 
            this.Pnl_Zdrowie.AutoSize = true;
            this.Pnl_Zdrowie.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.Pnl_Zdrowie.ForeColor = System.Drawing.Color.Red;
            this.Pnl_Zdrowie.Location = new System.Drawing.Point(75, 214);
            this.Pnl_Zdrowie.Name = "Pnl_Zdrowie";
            this.Pnl_Zdrowie.Size = new System.Drawing.Size(96, 33);
            this.Pnl_Zdrowie.TabIndex = 39;
            this.Pnl_Zdrowie.Text = "Zdrowie";
            this.Pnl_Zdrowie.Visible = false;
            // 
            // Pnl_Wytrzymalosc
            // 
            this.Pnl_Wytrzymalosc.AutoSize = true;
            this.Pnl_Wytrzymalosc.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold);
            this.Pnl_Wytrzymalosc.ForeColor = System.Drawing.Color.Blue;
            this.Pnl_Wytrzymalosc.Location = new System.Drawing.Point(57, 316);
            this.Pnl_Wytrzymalosc.Name = "Pnl_Wytrzymalosc";
            this.Pnl_Wytrzymalosc.Size = new System.Drawing.Size(151, 33);
            this.Pnl_Wytrzymalosc.TabIndex = 40;
            this.Pnl_Wytrzymalosc.Text = "Wytrzymałość";
            this.Pnl_Wytrzymalosc.Visible = false;
            // 
            // Lbl_Zloto
            // 
            this.Lbl_Zloto.AutoSize = true;
            this.Lbl_Zloto.Font = new System.Drawing.Font("Segoe Print", 12.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Zloto.ForeColor = System.Drawing.Color.Gold;
            this.Lbl_Zloto.Location = new System.Drawing.Point(40, 413);
            this.Lbl_Zloto.Name = "Lbl_Zloto";
            this.Lbl_Zloto.Size = new System.Drawing.Size(66, 30);
            this.Lbl_Zloto.TabIndex = 41;
            this.Lbl_Zloto.Text = "Złoto:";
            this.Lbl_Zloto.Visible = false;
            // 
            // Lbl_IloscZlota
            // 
            this.Lbl_IloscZlota.AutoSize = true;
            this.Lbl_IloscZlota.Font = new System.Drawing.Font("Segoe Print", 12.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_IloscZlota.ForeColor = System.Drawing.Color.Gold;
            this.Lbl_IloscZlota.Location = new System.Drawing.Point(147, 413);
            this.Lbl_IloscZlota.Name = "Lbl_IloscZlota";
            this.Lbl_IloscZlota.Size = new System.Drawing.Size(61, 30);
            this.Lbl_IloscZlota.TabIndex = 42;
            this.Lbl_IloscZlota.Text = "9999";
            this.Lbl_IloscZlota.Visible = false;
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
            this.Cpb_Health.Location = new System.Drawing.Point(10, 250);
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
            this.Cpb_Health.TabIndex = 43;
            this.Cpb_Health.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Cpb_Health.Value = 50;
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
            this.Cpb_Stamina.Location = new System.Drawing.Point(10, 352);
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
            this.Cpb_Stamina.TabIndex = 44;
            this.Cpb_Stamina.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Cpb_Stamina.Value = 50;
            // 
            // ucPanelPostaci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Pnl_Hero);
            this.Name = "ucPanelPostaci";
            this.Size = new System.Drawing.Size(270, 621);
            this.Pnl_Hero.ResumeLayout(false);
            this.Pnl_Hero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Panel Pnl_Odstep1;
        internal System.Windows.Forms.Panel Pnl_Hero;
        internal System.Windows.Forms.Button Btn_LeftMenuOff;
        internal CircularProgressBar.CircularProgressBar Cpb_Exp;
        internal System.Windows.Forms.PictureBox Pic_Avatar;
        internal System.Windows.Forms.Label Lbl_Poziom;
        internal System.Windows.Forms.Label Pnl_Wytrzymalosc;
        internal System.Windows.Forms.Label Pnl_Zdrowie;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label Lbl_Doswiadczenie;
        internal System.Windows.Forms.Label Lbl_IloscZlota;
        internal System.Windows.Forms.Label Lbl_Zloto;
        private CircularProgressBar.CircularProgressBar Cpb_Stamina;
        private CircularProgressBar.CircularProgressBar Cpb_Health;
    }
}
