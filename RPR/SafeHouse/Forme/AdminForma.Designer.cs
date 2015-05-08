namespace SafeHouse
{
    partial class AdminForma
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox_osnovniPodaci = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textbox_imeRadnika = new System.Windows.Forms.TextBox();
            this.textbox_prezimeRadnika = new System.Windows.Forms.TextBox();
            this.combobox_opisPoslaRadnika = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datum_rodj_radnik = new System.Windows.Forms.Label();
            this.registr_radnika_ime = new System.Windows.Forms.Label();
            this.registr_radnika_prezime = new System.Windows.Forms.Label();
            this.groupBox_dodjelaPristupa = new System.Windows.Forms.GroupBox();
            this.textbox_usernameRadnika = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textbox_passwordRadnika = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.registracija_radnika = new System.Windows.Forms.Button();
            this.raspored_za_radnika = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_osnovniPodaci.SuspendLayout();
            this.groupBox_dodjelaPristupa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(165, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 303);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox_osnovniPodaci);
            this.tabPage1.Controls.Add(this.groupBox_dodjelaPristupa);
            this.tabPage1.Controls.Add(this.registracija_radnika);
            this.tabPage1.Controls.Add(this.raspored_za_radnika);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(638, 277);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registracija novog radnika";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox_osnovniPodaci
            // 
            this.groupBox_osnovniPodaci.Controls.Add(this.dateTimePicker1);
            this.groupBox_osnovniPodaci.Controls.Add(this.textbox_imeRadnika);
            this.groupBox_osnovniPodaci.Controls.Add(this.textbox_prezimeRadnika);
            this.groupBox_osnovniPodaci.Controls.Add(this.combobox_opisPoslaRadnika);
            this.groupBox_osnovniPodaci.Controls.Add(this.label3);
            this.groupBox_osnovniPodaci.Controls.Add(this.datum_rodj_radnik);
            this.groupBox_osnovniPodaci.Controls.Add(this.registr_radnika_ime);
            this.groupBox_osnovniPodaci.Controls.Add(this.registr_radnika_prezime);
            this.groupBox_osnovniPodaci.Location = new System.Drawing.Point(48, 27);
            this.groupBox_osnovniPodaci.Name = "groupBox_osnovniPodaci";
            this.groupBox_osnovniPodaci.Size = new System.Drawing.Size(260, 144);
            this.groupBox_osnovniPodaci.TabIndex = 17;
            this.groupBox_osnovniPodaci.TabStop = false;
            this.groupBox_osnovniPodaci.Text = "Osnovni podaci";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(109, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // textbox_imeRadnika
            // 
            this.textbox_imeRadnika.Location = new System.Drawing.Point(110, 10);
            this.textbox_imeRadnika.Name = "textbox_imeRadnika";
            this.textbox_imeRadnika.Size = new System.Drawing.Size(104, 20);
            this.textbox_imeRadnika.TabIndex = 12;
            // 
            // textbox_prezimeRadnika
            // 
            this.textbox_prezimeRadnika.Location = new System.Drawing.Point(110, 41);
            this.textbox_prezimeRadnika.Name = "textbox_prezimeRadnika";
            this.textbox_prezimeRadnika.Size = new System.Drawing.Size(104, 20);
            this.textbox_prezimeRadnika.TabIndex = 11;
            // 
            // combobox_opisPoslaRadnika
            // 
            this.combobox_opisPoslaRadnika.FormattingEnabled = true;
            this.combobox_opisPoslaRadnika.Items.AddRange(new object[] {
            "Doktor",
            "Psiholog",
            "Ekonomista",
            "Pravnik"});
            this.combobox_opisPoslaRadnika.Location = new System.Drawing.Point(112, 105);
            this.combobox_opisPoslaRadnika.Name = "combobox_opisPoslaRadnika";
            this.combobox_opisPoslaRadnika.Size = new System.Drawing.Size(102, 21);
            this.combobox_opisPoslaRadnika.TabIndex = 8;
            this.combobox_opisPoslaRadnika.SelectedIndexChanged += new System.EventHandler(this.combobox_opisPoslaRadnika_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Opis posla:";
            // 
            // datum_rodj_radnik
            // 
            this.datum_rodj_radnik.AutoSize = true;
            this.datum_rodj_radnik.Location = new System.Drawing.Point(8, 75);
            this.datum_rodj_radnik.Name = "datum_rodj_radnik";
            this.datum_rodj_radnik.Size = new System.Drawing.Size(83, 13);
            this.datum_rodj_radnik.TabIndex = 4;
            this.datum_rodj_radnik.Text = "Datum rođenja: ";
            // 
            // registr_radnika_ime
            // 
            this.registr_radnika_ime.AutoSize = true;
            this.registr_radnika_ime.Location = new System.Drawing.Point(64, 17);
            this.registr_radnika_ime.Name = "registr_radnika_ime";
            this.registr_radnika_ime.Size = new System.Drawing.Size(27, 13);
            this.registr_radnika_ime.TabIndex = 2;
            this.registr_radnika_ime.Text = "Ime:";
            // 
            // registr_radnika_prezime
            // 
            this.registr_radnika_prezime.AutoSize = true;
            this.registr_radnika_prezime.Location = new System.Drawing.Point(49, 44);
            this.registr_radnika_prezime.Name = "registr_radnika_prezime";
            this.registr_radnika_prezime.Size = new System.Drawing.Size(47, 13);
            this.registr_radnika_prezime.TabIndex = 3;
            this.registr_radnika_prezime.Text = "Prezime:";
            // 
            // groupBox_dodjelaPristupa
            // 
            this.groupBox_dodjelaPristupa.Controls.Add(this.textbox_usernameRadnika);
            this.groupBox_dodjelaPristupa.Controls.Add(this.label1);
            this.groupBox_dodjelaPristupa.Controls.Add(this.textbox_passwordRadnika);
            this.groupBox_dodjelaPristupa.Controls.Add(this.label2);
            this.groupBox_dodjelaPristupa.Location = new System.Drawing.Point(358, 27);
            this.groupBox_dodjelaPristupa.Name = "groupBox_dodjelaPristupa";
            this.groupBox_dodjelaPristupa.Size = new System.Drawing.Size(215, 144);
            this.groupBox_dodjelaPristupa.TabIndex = 16;
            this.groupBox_dodjelaPristupa.TabStop = false;
            this.groupBox_dodjelaPristupa.Text = "Dodjela pristupnih podataka";
            this.groupBox_dodjelaPristupa.Visible = false;
            // 
            // textbox_usernameRadnika
            // 
            this.textbox_usernameRadnika.Location = new System.Drawing.Point(90, 55);
            this.textbox_usernameRadnika.Name = "textbox_usernameRadnika";
            this.textbox_usernameRadnika.Size = new System.Drawing.Size(104, 20);
            this.textbox_usernameRadnika.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username: ";
            // 
            // textbox_passwordRadnika
            // 
            this.textbox_passwordRadnika.Location = new System.Drawing.Point(90, 91);
            this.textbox_passwordRadnika.Name = "textbox_passwordRadnika";
            this.textbox_passwordRadnika.Size = new System.Drawing.Size(104, 20);
            this.textbox_passwordRadnika.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // registracija_radnika
            // 
            this.registracija_radnika.Location = new System.Drawing.Point(483, 199);
            this.registracija_radnika.Name = "registracija_radnika";
            this.registracija_radnika.Size = new System.Drawing.Size(122, 29);
            this.registracija_radnika.TabIndex = 15;
            this.registracija_radnika.Text = "Registruj radnika";
            this.registracija_radnika.UseVisualStyleBackColor = true;
            this.registracija_radnika.Click += new System.EventHandler(this.registracija_radnika_Click);
            // 
            // raspored_za_radnika
            // 
            this.raspored_za_radnika.Location = new System.Drawing.Point(358, 199);
            this.raspored_za_radnika.Name = "raspored_za_radnika";
            this.raspored_za_radnika.Size = new System.Drawing.Size(119, 29);
            this.raspored_za_radnika.TabIndex = 14;
            this.raspored_za_radnika.Text = "Kreiraj raspored";
            this.raspored_za_radnika.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(638, 277);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registracija novog korisnika";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(638, 277);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Upravljanje zahtjevima";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(638, 277);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Upravljanje rasporedima";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Forme.Properties.Resources.user1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 132);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 349);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "AdminForma";
            this.Text = "AdminForma";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox_osnovniPodaci.ResumeLayout(false);
            this.groupBox_osnovniPodaci.PerformLayout();
            this.groupBox_dodjelaPristupa.ResumeLayout(false);
            this.groupBox_dodjelaPristupa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button registracija_radnika;
        private System.Windows.Forms.Button raspored_za_radnika;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textbox_imeRadnika;
        private System.Windows.Forms.TextBox textbox_prezimeRadnika;
        private System.Windows.Forms.TextBox textbox_usernameRadnika;
        private System.Windows.Forms.TextBox textbox_passwordRadnika;
        private System.Windows.Forms.ComboBox combobox_opisPoslaRadnika;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label datum_rodj_radnik;
        private System.Windows.Forms.Label registr_radnika_ime;
        private System.Windows.Forms.Label registr_radnika_prezime;
        private System.Windows.Forms.GroupBox groupBox_osnovniPodaci;
        private System.Windows.Forms.GroupBox groupBox_dodjelaPristupa;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}