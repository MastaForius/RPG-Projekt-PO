namespace RPG___Projekt_programowanie_obiektowe
{
    partial class CreditsInfo
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditsInfo));
            this.TBox_Credits = new System.Windows.Forms.TextBox();
            this.Btn_Zamknij = new System.Windows.Forms.Button();
            this.Pnl_TopPanel = new System.Windows.Forms.Panel();
            this.Pic_LogoCredits = new System.Windows.Forms.PictureBox();
            this.Lbl_Credits = new System.Windows.Forms.Label();
            this.Pnl_TopPanelOdzielenie = new System.Windows.Forms.Panel();
            this.Pnl_OdstepCreditsRight = new System.Windows.Forms.Panel();
            this.Pnl_OdstepCreditsLeft = new System.Windows.Forms.Panel();
            this.Pnl_OdstepCreditsBottom = new System.Windows.Forms.Panel();
            this.Pnl_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_LogoCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // TBox_Credits
            // 
            this.TBox_Credits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBox_Credits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TBox_Credits.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TBox_Credits.Enabled = false;
            this.TBox_Credits.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Bold);
            this.TBox_Credits.ForeColor = System.Drawing.Color.DimGray;
            this.TBox_Credits.Location = new System.Drawing.Point(12, 61);
            this.TBox_Credits.Multiline = true;
            this.TBox_Credits.Name = "TBox_Credits";
            this.TBox_Credits.Size = new System.Drawing.Size(1000, 577);
            this.TBox_Credits.TabIndex = 1;
            this.TBox_Credits.Text = resources.GetString("TBox_Credits.Text");
            this.TBox_Credits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBox_Credits.TextChanged += new System.EventHandler(this.TBox_Credits_TextChanged);
            // 
            // Btn_Zamknij
            // 
            this.Btn_Zamknij.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Zamknij.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources.decorative_gold_frame_on_a_black_gradient_background_przycisk;
            this.Btn_Zamknij.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btn_Zamknij.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Zamknij.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.Btn_Zamknij.Location = new System.Drawing.Point(362, 644);
            this.Btn_Zamknij.Name = "Btn_Zamknij";
            this.Btn_Zamknij.Size = new System.Drawing.Size(300, 64);
            this.Btn_Zamknij.TabIndex = 2;
            this.Btn_Zamknij.Text = "Zamknij";
            this.Btn_Zamknij.UseVisualStyleBackColor = true;
            this.Btn_Zamknij.Click += new System.EventHandler(this.Btn_Zamknij_Click);
            // 
            // Pnl_TopPanel
            // 
            this.Pnl_TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(80)))));
            this.Pnl_TopPanel.Controls.Add(this.Pic_LogoCredits);
            this.Pnl_TopPanel.Controls.Add(this.Lbl_Credits);
            this.Pnl_TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_TopPanel.Location = new System.Drawing.Point(0, 0);
            this.Pnl_TopPanel.Name = "Pnl_TopPanel";
            this.Pnl_TopPanel.Size = new System.Drawing.Size(1024, 50);
            this.Pnl_TopPanel.TabIndex = 3;
            this.Pnl_TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_TopPanel_MouseDown);
            // 
            // Pic_LogoCredits
            // 
            this.Pic_LogoCredits.BackgroundImage = global::RPG___Projekt_programowanie_obiektowe.Properties.Resources._300_Spartan_Workout;
            this.Pic_LogoCredits.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic_LogoCredits.Location = new System.Drawing.Point(0, 0);
            this.Pic_LogoCredits.Name = "Pic_LogoCredits";
            this.Pic_LogoCredits.Size = new System.Drawing.Size(75, 50);
            this.Pic_LogoCredits.TabIndex = 2;
            this.Pic_LogoCredits.TabStop = false;
            // 
            // Lbl_Credits
            // 
            this.Lbl_Credits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Lbl_Credits.AutoSize = true;
            this.Lbl_Credits.BackColor = System.Drawing.Color.Transparent;
            this.Lbl_Credits.Font = new System.Drawing.Font("Segoe Print", 20.25F, System.Drawing.FontStyle.Bold);
            this.Lbl_Credits.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Lbl_Credits.Location = new System.Drawing.Point(78, 0);
            this.Lbl_Credits.Name = "Lbl_Credits";
            this.Lbl_Credits.Size = new System.Drawing.Size(117, 47);
            this.Lbl_Credits.TabIndex = 0;
            this.Lbl_Credits.Text = "Credits";
            this.Lbl_Credits.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lbl_Credits_MouseDown);
            // 
            // Pnl_TopPanelOdzielenie
            // 
            this.Pnl_TopPanelOdzielenie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.Pnl_TopPanelOdzielenie.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_TopPanelOdzielenie.Location = new System.Drawing.Point(0, 50);
            this.Pnl_TopPanelOdzielenie.Name = "Pnl_TopPanelOdzielenie";
            this.Pnl_TopPanelOdzielenie.Size = new System.Drawing.Size(1024, 5);
            this.Pnl_TopPanelOdzielenie.TabIndex = 4;
            // 
            // Pnl_OdstepCreditsRight
            // 
            this.Pnl_OdstepCreditsRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.Pnl_OdstepCreditsRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.Pnl_OdstepCreditsRight.Location = new System.Drawing.Point(1019, 55);
            this.Pnl_OdstepCreditsRight.Name = "Pnl_OdstepCreditsRight";
            this.Pnl_OdstepCreditsRight.Size = new System.Drawing.Size(5, 665);
            this.Pnl_OdstepCreditsRight.TabIndex = 12;
            // 
            // Pnl_OdstepCreditsLeft
            // 
            this.Pnl_OdstepCreditsLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.Pnl_OdstepCreditsLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_OdstepCreditsLeft.Location = new System.Drawing.Point(0, 55);
            this.Pnl_OdstepCreditsLeft.Name = "Pnl_OdstepCreditsLeft";
            this.Pnl_OdstepCreditsLeft.Size = new System.Drawing.Size(5, 665);
            this.Pnl_OdstepCreditsLeft.TabIndex = 13;
            // 
            // Pnl_OdstepCreditsBottom
            // 
            this.Pnl_OdstepCreditsBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(28)))), ((int)(((byte)(32)))));
            this.Pnl_OdstepCreditsBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_OdstepCreditsBottom.Location = new System.Drawing.Point(5, 715);
            this.Pnl_OdstepCreditsBottom.Name = "Pnl_OdstepCreditsBottom";
            this.Pnl_OdstepCreditsBottom.Size = new System.Drawing.Size(1014, 5);
            this.Pnl_OdstepCreditsBottom.TabIndex = 14;
            // 
            // CreditsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1024, 720);
            this.Controls.Add(this.Pnl_OdstepCreditsBottom);
            this.Controls.Add(this.Pnl_OdstepCreditsLeft);
            this.Controls.Add(this.Pnl_OdstepCreditsRight);
            this.Controls.Add(this.Pnl_TopPanelOdzielenie);
            this.Controls.Add(this.Pnl_TopPanel);
            this.Controls.Add(this.Btn_Zamknij);
            this.Controls.Add(this.TBox_Credits);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "CreditsInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreditsInfo";
            this.Pnl_TopPanel.ResumeLayout(false);
            this.Pnl_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_LogoCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Zamknij;
        private System.Windows.Forms.Panel Pnl_TopPanel;
        private System.Windows.Forms.Panel Pnl_TopPanelOdzielenie;
        private System.Windows.Forms.Label Lbl_Credits;
        private System.Windows.Forms.Panel Pnl_OdstepCreditsRight;
        private System.Windows.Forms.Panel Pnl_OdstepCreditsLeft;
        private System.Windows.Forms.Panel Pnl_OdstepCreditsBottom;
        private System.Windows.Forms.TextBox TBox_Credits;
        private System.Windows.Forms.PictureBox Pic_LogoCredits;
    }
}