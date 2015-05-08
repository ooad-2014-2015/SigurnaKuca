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
            this.button_raspored = new System.Windows.Forms.Button();
            this.button_registrujKorisnika = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_dodaneOsobe = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button_addOsobe = new System.Windows.Forms.Button();
            this.textBox_dodajOsobu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox_personalniPsiholog = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_personalniDoktor = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_datumOtpustaKorisnika = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker_datumPrijemaKorisnika = new System.Windows.Forms.DateTimePicker();
            this.comboBox_lokacijaKorisnika = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_passwordKorisnika = new System.Windows.Forms.TextBox();
            this.textBox_usernameKorisnika = new System.Windows.Forms.TextBox();
            this.textBox_prezimeKorisnika = new System.Windows.Forms.TextBox();
            this.textBox_imeKorisnika = new System.Windows.Forms.TextBox();
            this.dateTimePicker_datRodjenjaKorisnika = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton_potpunoAnoniman = new System.Windows.Forms.RadioButton();
            this.radioButton_djelomičnoAnoniman = new System.Windows.Forms.RadioButton();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_osnovniPodaci.SuspendLayout();
            this.groupBox_dodjelaPristupa.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tabControl1.Location = new System.Drawing.Point(165, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(646, 320);
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
            this.tabPage1.Size = new System.Drawing.Size(638, 294);
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
            this.textbox_usernameRadnika.TextChanged += new System.EventHandler(this.textbox_usernameRadnika_TextChanged);
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
            this.textbox_passwordRadnika.TextChanged += new System.EventHandler(this.textbox_passwordRadnika_TextChanged);
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
            this.tabPage2.Controls.Add(this.button_raspored);
            this.tabPage2.Controls.Add(this.button_registrujKorisnika);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.radioButton_potpunoAnoniman);
            this.tabPage2.Controls.Add(this.radioButton_djelomičnoAnoniman);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(638, 294);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registracija novog korisnika";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button_raspored
            // 
            this.button_raspored.Location = new System.Drawing.Point(358, 257);
            this.button_raspored.Name = "button_raspored";
            this.button_raspored.Size = new System.Drawing.Size(127, 27);
            this.button_raspored.TabIndex = 15;
            this.button_raspored.Text = "Kreiraj raspored";
            this.button_raspored.UseVisualStyleBackColor = true;
            // 
            // button_registrujKorisnika
            // 
            this.button_registrujKorisnika.Location = new System.Drawing.Point(491, 257);
            this.button_registrujKorisnika.Name = "button_registrujKorisnika";
            this.button_registrujKorisnika.Size = new System.Drawing.Size(127, 27);
            this.button_registrujKorisnika.TabIndex = 14;
            this.button_registrujKorisnika.Text = "Registruj korisnika";
            this.button_registrujKorisnika.UseVisualStyleBackColor = true;
            this.button_registrujKorisnika.Click += new System.EventHandler(this.button_registrujKorisnika_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.comboBox_personalniPsiholog);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBox_personalniDoktor);
            this.groupBox2.Controls.Add(this.dateTimePicker_datumOtpustaKorisnika);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(310, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(310, 234);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Djelomično anoniman korisnik";
            this.groupBox2.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_dodaneOsobe);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.button_addOsobe);
            this.groupBox3.Controls.Add(this.textBox_dodajOsobu);
            this.groupBox3.Location = new System.Drawing.Point(21, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 74);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // comboBox_dodaneOsobe
            // 
            this.comboBox_dodaneOsobe.FormattingEnabled = true;
            this.comboBox_dodaneOsobe.Location = new System.Drawing.Point(123, 46);
            this.comboBox_dodaneOsobe.Name = "comboBox_dodaneOsobe";
            this.comboBox_dodaneOsobe.Size = new System.Drawing.Size(140, 21);
            this.comboBox_dodaneOsobe.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(23, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(83, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Dodane osobe: ";
            // 
            // button_addOsobe
            // 
            this.button_addOsobe.Location = new System.Drawing.Point(174, 19);
            this.button_addOsobe.Name = "button_addOsobe";
            this.button_addOsobe.Size = new System.Drawing.Size(90, 20);
            this.button_addOsobe.TabIndex = 8;
            this.button_addOsobe.Text = "Dodaj osobu";
            this.button_addOsobe.UseVisualStyleBackColor = true;
            this.button_addOsobe.Click += new System.EventHandler(this.button_addOsobe_Click);
            // 
            // textBox_dodajOsobu
            // 
            this.textBox_dodajOsobu.Location = new System.Drawing.Point(16, 19);
            this.textBox_dodajOsobu.Name = "textBox_dodajOsobu";
            this.textBox_dodajOsobu.Size = new System.Drawing.Size(150, 20);
            this.textBox_dodajOsobu.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(253, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "Osobe upoznate sa slučajem (po odabiru korisnika): ";
            // 
            // comboBox_personalniPsiholog
            // 
            this.comboBox_personalniPsiholog.FormattingEnabled = true;
            this.comboBox_personalniPsiholog.Location = new System.Drawing.Point(133, 90);
            this.comboBox_personalniPsiholog.Name = "comboBox_personalniPsiholog";
            this.comboBox_personalniPsiholog.Size = new System.Drawing.Size(130, 21);
            this.comboBox_personalniPsiholog.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Personalni psiholog: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Personalni doktor: ";
            // 
            // comboBox_personalniDoktor
            // 
            this.comboBox_personalniDoktor.FormattingEnabled = true;
            this.comboBox_personalniDoktor.Location = new System.Drawing.Point(133, 59);
            this.comboBox_personalniDoktor.Name = "comboBox_personalniDoktor";
            this.comboBox_personalniDoktor.Size = new System.Drawing.Size(130, 21);
            this.comboBox_personalniDoktor.TabIndex = 2;
            // 
            // dateTimePicker_datumOtpustaKorisnika
            // 
            this.dateTimePicker_datumOtpustaKorisnika.Location = new System.Drawing.Point(133, 26);
            this.dateTimePicker_datumOtpustaKorisnika.Name = "dateTimePicker_datumOtpustaKorisnika";
            this.dateTimePicker_datumOtpustaKorisnika.Size = new System.Drawing.Size(130, 20);
            this.dateTimePicker_datumOtpustaKorisnika.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Datum otpusta: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dateTimePicker_datumPrijemaKorisnika);
            this.groupBox1.Controls.Add(this.comboBox_lokacijaKorisnika);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox_passwordKorisnika);
            this.groupBox1.Controls.Add(this.textBox_usernameKorisnika);
            this.groupBox1.Controls.Add(this.textBox_prezimeKorisnika);
            this.groupBox1.Controls.Add(this.textBox_imeKorisnika);
            this.groupBox1.Controls.Add(this.dateTimePicker_datRodjenjaKorisnika);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(25, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 220);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o korisniku";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 166);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Datum prijema:";
            // 
            // dateTimePicker_datumPrijemaKorisnika
            // 
            this.dateTimePicker_datumPrijemaKorisnika.Location = new System.Drawing.Point(108, 160);
            this.dateTimePicker_datumPrijemaKorisnika.Name = "dateTimePicker_datumPrijemaKorisnika";
            this.dateTimePicker_datumPrijemaKorisnika.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker_datumPrijemaKorisnika.TabIndex = 11;
            // 
            // comboBox_lokacijaKorisnika
            // 
            this.comboBox_lokacijaKorisnika.FormattingEnabled = true;
            this.comboBox_lokacijaKorisnika.Location = new System.Drawing.Point(108, 191);
            this.comboBox_lokacijaKorisnika.Name = "comboBox_lokacijaKorisnika";
            this.comboBox_lokacijaKorisnika.Size = new System.Drawing.Size(130, 21);
            this.comboBox_lokacijaKorisnika.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 191);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Lokacija: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Datum rođenja: ";
            // 
            // textBox_passwordKorisnika
            // 
            this.textBox_passwordKorisnika.Location = new System.Drawing.Point(108, 130);
            this.textBox_passwordKorisnika.Name = "textBox_passwordKorisnika";
            this.textBox_passwordKorisnika.Size = new System.Drawing.Size(115, 20);
            this.textBox_passwordKorisnika.TabIndex = 8;
            // 
            // textBox_usernameKorisnika
            // 
            this.textBox_usernameKorisnika.Location = new System.Drawing.Point(108, 101);
            this.textBox_usernameKorisnika.Name = "textBox_usernameKorisnika";
            this.textBox_usernameKorisnika.Size = new System.Drawing.Size(115, 20);
            this.textBox_usernameKorisnika.TabIndex = 7;
            // 
            // textBox_prezimeKorisnika
            // 
            this.textBox_prezimeKorisnika.Location = new System.Drawing.Point(108, 49);
            this.textBox_prezimeKorisnika.Name = "textBox_prezimeKorisnika";
            this.textBox_prezimeKorisnika.Size = new System.Drawing.Size(115, 20);
            this.textBox_prezimeKorisnika.TabIndex = 6;
            // 
            // textBox_imeKorisnika
            // 
            this.textBox_imeKorisnika.Location = new System.Drawing.Point(108, 19);
            this.textBox_imeKorisnika.Name = "textBox_imeKorisnika";
            this.textBox_imeKorisnika.Size = new System.Drawing.Size(115, 20);
            this.textBox_imeKorisnika.TabIndex = 5;
            // 
            // dateTimePicker_datRodjenjaKorisnika
            // 
            this.dateTimePicker_datRodjenjaKorisnika.Location = new System.Drawing.Point(108, 75);
            this.dateTimePicker_datRodjenjaKorisnika.Name = "dateTimePicker_datRodjenjaKorisnika";
            this.dateTimePicker_datRodjenjaKorisnika.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker_datRodjenjaKorisnika.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Username: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Prezime: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ime: ";
            // 
            // radioButton_potpunoAnoniman
            // 
            this.radioButton_potpunoAnoniman.AutoSize = true;
            this.radioButton_potpunoAnoniman.Location = new System.Drawing.Point(39, 267);
            this.radioButton_potpunoAnoniman.Name = "radioButton_potpunoAnoniman";
            this.radioButton_potpunoAnoniman.Size = new System.Drawing.Size(153, 17);
            this.radioButton_potpunoAnoniman.TabIndex = 11;
            this.radioButton_potpunoAnoniman.TabStop = true;
            this.radioButton_potpunoAnoniman.Text = "Potpuno anoniman korisnik";
            this.radioButton_potpunoAnoniman.UseVisualStyleBackColor = true;
            // 
            // radioButton_djelomičnoAnoniman
            // 
            this.radioButton_djelomičnoAnoniman.AutoSize = true;
            this.radioButton_djelomičnoAnoniman.Location = new System.Drawing.Point(39, 244);
            this.radioButton_djelomičnoAnoniman.Name = "radioButton_djelomičnoAnoniman";
            this.radioButton_djelomičnoAnoniman.Size = new System.Drawing.Size(165, 17);
            this.radioButton_djelomičnoAnoniman.TabIndex = 10;
            this.radioButton_djelomičnoAnoniman.TabStop = true;
            this.radioButton_djelomičnoAnoniman.Text = "Djelomično anoniman korisnik";
            this.radioButton_djelomičnoAnoniman.UseVisualStyleBackColor = true;
            this.radioButton_djelomičnoAnoniman.CheckedChanged += new System.EventHandler(this.radioButton_djelomičnoAnoniman_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(638, 294);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Upravljanje zahtjevima";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(638, 294);
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
            this.ClientSize = new System.Drawing.Size(823, 356);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_passwordKorisnika;
        private System.Windows.Forms.TextBox textBox_usernameKorisnika;
        private System.Windows.Forms.TextBox textBox_prezimeKorisnika;
        private System.Windows.Forms.TextBox textBox_imeKorisnika;
        private System.Windows.Forms.DateTimePicker dateTimePicker_datRodjenjaKorisnika;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton_potpunoAnoniman;
        private System.Windows.Forms.RadioButton radioButton_djelomičnoAnoniman;
        private System.Windows.Forms.DateTimePicker dateTimePicker_datumOtpustaKorisnika;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_personalniDoktor;
        private System.Windows.Forms.ComboBox comboBox_personalniPsiholog;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_raspored;
        private System.Windows.Forms.Button button_registrujKorisnika;
        private System.Windows.Forms.Button button_addOsobe;
        private System.Windows.Forms.TextBox textBox_dodajOsobu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox_lokacijaKorisnika;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker_datumPrijemaKorisnika;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_dodaneOsobe;
    }
}