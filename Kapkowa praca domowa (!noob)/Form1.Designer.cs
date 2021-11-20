namespace Kapkowa_praca_domowa___noob_
{
    partial class Altair
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Gracz = new System.Windows.Forms.PictureBox();
            this.animacja = new System.Windows.Forms.Timer(this.components);
            this.punktyLabel = new System.Windows.Forms.Label();
            this.wzowienie = new System.Windows.Forms.Button();
            this.comboLabel = new System.Windows.Forms.Label();
            this.skinCzerwony = new System.Windows.Forms.Button();
            this.skinPomaranczowy = new System.Windows.Forms.Button();
            this.skinCyan = new System.Windows.Forms.Button();
            this.skinRóżowy = new System.Windows.Forms.Button();
            this.skinBialasa = new System.Windows.Forms.Button();
            this.skinyLabel = new System.Windows.Forms.Label();
            this.zaczynamy = new System.Windows.Forms.Button();
            this.zycko1 = new System.Windows.Forms.ProgressBar();
            this.zycko2 = new System.Windows.Forms.ProgressBar();
            this.zycko3 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.winLabel = new System.Windows.Forms.Label();
            this.istrukcjaLabel = new System.Windows.Forms.Label();
            this.przegranaLabel = new System.Windows.Forms.Label();
            this.probyLabel = new System.Windows.Forms.Label();
            this.godMode = new System.Windows.Forms.CheckBox();
            this.maxComboLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Gracz)).BeginInit();
            this.SuspendLayout();
            // 
            // Gracz
            // 
            this.Gracz.BackColor = System.Drawing.Color.Coral;
            this.Gracz.Location = new System.Drawing.Point(12, 599);
            this.Gracz.Name = "Gracz";
            this.Gracz.Size = new System.Drawing.Size(56, 56);
            this.Gracz.TabIndex = 0;
            this.Gracz.TabStop = false;
            // 
            // animacja
            // 
            this.animacja.Enabled = true;
            this.animacja.Interval = 10;
            this.animacja.Tick += new System.EventHandler(this.animacja_Tick);
            // 
            // punktyLabel
            // 
            this.punktyLabel.AutoSize = true;
            this.punktyLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.punktyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.punktyLabel.Location = new System.Drawing.Point(9, 9);
            this.punktyLabel.Name = "punktyLabel";
            this.punktyLabel.Size = new System.Drawing.Size(86, 21);
            this.punktyLabel.TabIndex = 1;
            this.punktyLabel.Text = "Punkty:  0";
            // 
            // wzowienie
            // 
            this.wzowienie.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wzowienie.Location = new System.Drawing.Point(101, 414);
            this.wzowienie.Name = "wzowienie";
            this.wzowienie.Size = new System.Drawing.Size(178, 93);
            this.wzowienie.TabIndex = 2;
            this.wzowienie.Text = "Wznowić?";
            this.wzowienie.UseVisualStyleBackColor = true;
            this.wzowienie.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboLabel
            // 
            this.comboLabel.AutoSize = true;
            this.comboLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboLabel.Location = new System.Drawing.Point(298, 9);
            this.comboLabel.Name = "comboLabel";
            this.comboLabel.Size = new System.Drawing.Size(92, 21);
            this.comboLabel.TabIndex = 3;
            this.comboLabel.Text = "Combo: 0x";
            // 
            // skinCzerwony
            // 
            this.skinCzerwony.BackColor = System.Drawing.Color.Red;
            this.skinCzerwony.Location = new System.Drawing.Point(107, 380);
            this.skinCzerwony.Name = "skinCzerwony";
            this.skinCzerwony.Size = new System.Drawing.Size(28, 28);
            this.skinCzerwony.TabIndex = 4;
            this.skinCzerwony.UseVisualStyleBackColor = false;
            this.skinCzerwony.Click += new System.EventHandler(this.skinCzerwony_Click);
            // 
            // skinPomaranczowy
            // 
            this.skinPomaranczowy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.skinPomaranczowy.Location = new System.Drawing.Point(141, 380);
            this.skinPomaranczowy.Name = "skinPomaranczowy";
            this.skinPomaranczowy.Size = new System.Drawing.Size(28, 28);
            this.skinPomaranczowy.TabIndex = 5;
            this.skinPomaranczowy.UseVisualStyleBackColor = false;
            this.skinPomaranczowy.Click += new System.EventHandler(this.skinPomaranczowy_Click);
            // 
            // skinCyan
            // 
            this.skinCyan.BackColor = System.Drawing.Color.Cyan;
            this.skinCyan.Location = new System.Drawing.Point(175, 380);
            this.skinCyan.Name = "skinCyan";
            this.skinCyan.Size = new System.Drawing.Size(28, 28);
            this.skinCyan.TabIndex = 6;
            this.skinCyan.UseVisualStyleBackColor = false;
            this.skinCyan.Click += new System.EventHandler(this.skinCyan_Click);
            // 
            // skinRóżowy
            // 
            this.skinRóżowy.BackColor = System.Drawing.Color.Fuchsia;
            this.skinRóżowy.Location = new System.Drawing.Point(209, 380);
            this.skinRóżowy.Name = "skinRóżowy";
            this.skinRóżowy.Size = new System.Drawing.Size(28, 28);
            this.skinRóżowy.TabIndex = 7;
            this.skinRóżowy.UseVisualStyleBackColor = false;
            this.skinRóżowy.Click += new System.EventHandler(this.skinRóżowy_Click);
            // 
            // skinBialasa
            // 
            this.skinBialasa.BackColor = System.Drawing.Color.White;
            this.skinBialasa.Location = new System.Drawing.Point(243, 380);
            this.skinBialasa.Name = "skinBialasa";
            this.skinBialasa.Size = new System.Drawing.Size(28, 28);
            this.skinBialasa.TabIndex = 8;
            this.skinBialasa.UseVisualStyleBackColor = false;
            this.skinBialasa.Click += new System.EventHandler(this.skinBialasa_Click);
            // 
            // skinyLabel
            // 
            this.skinyLabel.AutoSize = true;
            this.skinyLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.skinyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.skinyLabel.Location = new System.Drawing.Point(165, 354);
            this.skinyLabel.Name = "skinyLabel";
            this.skinyLabel.Size = new System.Drawing.Size(50, 21);
            this.skinyLabel.TabIndex = 9;
            this.skinyLabel.Text = "Skiny";
            // 
            // zaczynamy
            // 
            this.zaczynamy.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zaczynamy.Location = new System.Drawing.Point(101, 258);
            this.zaczynamy.Name = "zaczynamy";
            this.zaczynamy.Size = new System.Drawing.Size(178, 93);
            this.zaczynamy.TabIndex = 10;
            this.zaczynamy.Text = "Start";
            this.zaczynamy.UseVisualStyleBackColor = true;
            this.zaczynamy.Click += new System.EventHandler(this.zaczynamy_Click);
            this.zaczynamy.MouseClick += new System.Windows.Forms.MouseEventHandler(this.zaczynamyGre);
            // 
            // zycko1
            // 
            this.zycko1.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.zycko1.Location = new System.Drawing.Point(101, 36);
            this.zycko1.Name = "zycko1";
            this.zycko1.Size = new System.Drawing.Size(69, 18);
            this.zycko1.TabIndex = 11;
            // 
            // zycko2
            // 
            this.zycko2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.zycko2.Location = new System.Drawing.Point(164, 36);
            this.zycko2.Name = "zycko2";
            this.zycko2.Size = new System.Drawing.Size(68, 18);
            this.zycko2.TabIndex = 12;
            // 
            // zycko3
            // 
            this.zycko3.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.zycko3.Location = new System.Drawing.Point(224, 36);
            this.zycko3.Name = "zycko3";
            this.zycko3.Size = new System.Drawing.Size(68, 18);
            this.zycko3.TabIndex = 13;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(101, 13);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(191, 17);
            this.progressBar1.TabIndex = 14;
            // 
            // winLabel
            // 
            this.winLabel.AutoSize = true;
            this.winLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.winLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.winLabel.Location = new System.Drawing.Point(76, 160);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(233, 38);
            this.winLabel.TabIndex = 15;
            this.winLabel.Text = "Wygrałeś. Cool!";
            // 
            // istrukcjaLabel
            // 
            this.istrukcjaLabel.AutoSize = true;
            this.istrukcjaLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.istrukcjaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.istrukcjaLabel.Location = new System.Drawing.Point(22, 198);
            this.istrukcjaLabel.Name = "istrukcjaLabel";
            this.istrukcjaLabel.Size = new System.Drawing.Size(310, 25);
            this.istrukcjaLabel.TabIndex = 16;
            this.istrukcjaLabel.Text = "Naciśnij R aby zagrać ponownie!";
            // 
            // przegranaLabel
            // 
            this.przegranaLabel.AutoSize = true;
            this.przegranaLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.przegranaLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.przegranaLabel.Location = new System.Drawing.Point(46, 160);
            this.przegranaLabel.Name = "przegranaLabel";
            this.przegranaLabel.Size = new System.Drawing.Size(303, 38);
            this.przegranaLabel.TabIndex = 17;
            this.przegranaLabel.Text = "Przegrałeś. Not cool.";
            // 
            // probyLabel
            // 
            this.probyLabel.AutoSize = true;
            this.probyLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.probyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.probyLabel.Location = new System.Drawing.Point(8, 36);
            this.probyLabel.Name = "probyLabel";
            this.probyLabel.Size = new System.Drawing.Size(77, 21);
            this.probyLabel.TabIndex = 18;
            this.probyLabel.Text = "Próby:  0";
            // 
            // godMode
            // 
            this.godMode.AutoSize = true;
            this.godMode.Location = new System.Drawing.Point(160, 60);
            this.godMode.Name = "godMode";
            this.godMode.Size = new System.Drawing.Size(72, 17);
            this.godMode.TabIndex = 19;
            this.godMode.TabStop = false;
            this.godMode.Text = "Godmode";
            this.godMode.UseVisualStyleBackColor = true;
            this.godMode.CheckedChanged += new System.EventHandler(this.godMode_CheckedChanged);
            // 
            // maxComboLabel
            // 
            this.maxComboLabel.AutoSize = true;
            this.maxComboLabel.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.maxComboLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.maxComboLabel.Location = new System.Drawing.Point(298, 33);
            this.maxComboLabel.Name = "maxComboLabel";
            this.maxComboLabel.Size = new System.Drawing.Size(69, 21);
            this.maxComboLabel.TabIndex = 20;
            this.maxComboLabel.Text = "Max: 0x";
            // 
            // Altair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(402, 667);
            this.Controls.Add(this.maxComboLabel);
            this.Controls.Add(this.godMode);
            this.Controls.Add(this.probyLabel);
            this.Controls.Add(this.przegranaLabel);
            this.Controls.Add(this.istrukcjaLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.zycko3);
            this.Controls.Add(this.zycko2);
            this.Controls.Add(this.zycko1);
            this.Controls.Add(this.zaczynamy);
            this.Controls.Add(this.skinyLabel);
            this.Controls.Add(this.skinBialasa);
            this.Controls.Add(this.skinRóżowy);
            this.Controls.Add(this.skinCyan);
            this.Controls.Add(this.skinPomaranczowy);
            this.Controls.Add(this.skinCzerwony);
            this.Controls.Add(this.comboLabel);
            this.Controls.Add(this.wzowienie);
            this.Controls.Add(this.punktyLabel);
            this.Controls.Add(this.Gracz);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Altair";
            this.Text = "Altair";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Gracz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Gracz;
        private System.Windows.Forms.Timer animacja;
        private System.Windows.Forms.Label punktyLabel;
        private System.Windows.Forms.Button wzowienie;
        private System.Windows.Forms.Label comboLabel;
        private System.Windows.Forms.Button skinCzerwony;
        private System.Windows.Forms.Button skinPomaranczowy;
        private System.Windows.Forms.Button skinCyan;
        private System.Windows.Forms.Button skinRóżowy;
        private System.Windows.Forms.Button skinBialasa;
        private System.Windows.Forms.Label skinyLabel;
        private System.Windows.Forms.Button zaczynamy;
        private System.Windows.Forms.ProgressBar zycko1;
        private System.Windows.Forms.ProgressBar zycko2;
        private System.Windows.Forms.ProgressBar zycko3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Label istrukcjaLabel;
        private System.Windows.Forms.Label przegranaLabel;
        private System.Windows.Forms.Label probyLabel;
        private System.Windows.Forms.CheckBox godMode;
        private System.Windows.Forms.Label maxComboLabel;
    }
}

