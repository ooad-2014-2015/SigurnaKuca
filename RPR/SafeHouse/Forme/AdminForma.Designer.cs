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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForma));
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
            this.groupBox_djelomičnoAnonimniKorisnik = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_dodaneOsobe = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button_addOsobe = new System.Windows.Forms.Button();
            this.textBox_dodajOsobu = new System.Windows.Forms.TextBox();
            this.comboBox_personalniPsiholog = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_personalniDoktor = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_datumOtpustaKorisnika = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox_anonimniKorisnik = new System.Windows.Forms.GroupBox();
            this.comboBox_personalniPravnikAnonimniKorisnik = new System.Windows.Forms.ComboBox();
            this.comboBox_personalniEkonomistaAnonimniKorisnik = new System.Windows.Forms.ComboBox();
            this.comboBox_personalniPsihologAnonimniKorisnik = new System.Windows.Forms.ComboBox();
            this.comboBox_personalniDoktorAnonimniKorisnik = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button_registrujKorisnika = new System.Windows.Forms.Button();
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox_osnovniPodaci.SuspendLayout();
            this.groupBox_dodjelaPristupa.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox_djelomičnoAnonimniKorisnik.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox_anonimniKorisnik.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabControl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl1.Location = new System.Drawing.Point(177, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(663, 375);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage1.Controls.Add(this.groupBox_osnovniPodaci);
            this.tabPage1.Controls.Add(this.groupBox_dodjelaPristupa);
            this.tabPage1.Controls.Add(this.registracija_radnika);
            this.tabPage1.Controls.Add(this.raspored_za_radnika);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(655, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registracija novog radnika";
            // 
            // groupBox_osnovniPodaci
            // 
            this.groupBox_osnovniPodaci.BackColor = System.Drawing.Color.White;
            this.groupBox_osnovniPodaci.Controls.Add(this.dateTimePicker1);
            this.groupBox_osnovniPodaci.Controls.Add(this.textbox_imeRadnika);
            this.groupBox_osnovniPodaci.Controls.Add(this.textbox_prezimeRadnika);
            this.groupBox_osnovniPodaci.Controls.Add(this.combobox_opisPoslaRadnika);
            this.groupBox_osnovniPodaci.Controls.Add(this.label3);
            this.groupBox_osnovniPodaci.Controls.Add(this.datum_rodj_radnik);
            this.groupBox_osnovniPodaci.Controls.Add(this.registr_radnika_ime);
            this.groupBox_osnovniPodaci.Controls.Add(this.registr_radnika_prezime);
            this.groupBox_osnovniPodaci.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_osnovniPodaci.Location = new System.Drawing.Point(32, 36);
            this.groupBox_osnovniPodaci.Name = "groupBox_osnovniPodaci";
            this.groupBox_osnovniPodaci.Size = new System.Drawing.Size(280, 167);
            this.groupBox_osnovniPodaci.TabIndex = 17;
            this.groupBox_osnovniPodaci.TabStop = false;
            this.groupBox_osnovniPodaci.Text = "Osnovni podaci";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(138, 87);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 23);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // textbox_imeRadnika
            // 
            this.textbox_imeRadnika.Location = new System.Drawing.Point(138, 29);
            this.textbox_imeRadnika.Name = "textbox_imeRadnika";
            this.textbox_imeRadnika.Size = new System.Drawing.Size(104, 23);
            this.textbox_imeRadnika.TabIndex = 12;
            // 
            // textbox_prezimeRadnika
            // 
            this.textbox_prezimeRadnika.Location = new System.Drawing.Point(138, 58);
            this.textbox_prezimeRadnika.Name = "textbox_prezimeRadnika";
            this.textbox_prezimeRadnika.Size = new System.Drawing.Size(104, 23);
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
            this.combobox_opisPoslaRadnika.Location = new System.Drawing.Point(138, 120);
            this.combobox_opisPoslaRadnika.Name = "combobox_opisPoslaRadnika";
            this.combobox_opisPoslaRadnika.Size = new System.Drawing.Size(102, 24);
            this.combobox_opisPoslaRadnika.TabIndex = 8;
            this.combobox_opisPoslaRadnika.SelectedIndexChanged += new System.EventHandler(this.combobox_opisPoslaRadnika_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Opis posla:";
            // 
            // datum_rodj_radnik
            // 
            this.datum_rodj_radnik.AutoSize = true;
            this.datum_rodj_radnik.Location = new System.Drawing.Point(21, 92);
            this.datum_rodj_radnik.Name = "datum_rodj_radnik";
            this.datum_rodj_radnik.Size = new System.Drawing.Size(102, 16);
            this.datum_rodj_radnik.TabIndex = 4;
            this.datum_rodj_radnik.Text = "Datum rođenja: ";
            // 
            // registr_radnika_ime
            // 
            this.registr_radnika_ime.AutoSize = true;
            this.registr_radnika_ime.Location = new System.Drawing.Point(88, 36);
            this.registr_radnika_ime.Name = "registr_radnika_ime";
            this.registr_radnika_ime.Size = new System.Drawing.Size(35, 16);
            this.registr_radnika_ime.TabIndex = 2;
            this.registr_radnika_ime.Text = "Ime:";
            // 
            // registr_radnika_prezime
            // 
            this.registr_radnika_prezime.AutoSize = true;
            this.registr_radnika_prezime.Location = new System.Drawing.Point(64, 61);
            this.registr_radnika_prezime.Name = "registr_radnika_prezime";
            this.registr_radnika_prezime.Size = new System.Drawing.Size(59, 16);
            this.registr_radnika_prezime.TabIndex = 3;
            this.registr_radnika_prezime.Text = "Prezime:";
            // 
            // groupBox_dodjelaPristupa
            // 
            this.groupBox_dodjelaPristupa.Controls.Add(this.textbox_usernameRadnika);
            this.groupBox_dodjelaPristupa.Controls.Add(this.label1);
            this.groupBox_dodjelaPristupa.Controls.Add(this.textbox_passwordRadnika);
            this.groupBox_dodjelaPristupa.Controls.Add(this.label2);
            this.groupBox_dodjelaPristupa.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_dodjelaPristupa.Location = new System.Drawing.Point(347, 36);
            this.groupBox_dodjelaPristupa.Name = "groupBox_dodjelaPristupa";
            this.groupBox_dodjelaPristupa.Size = new System.Drawing.Size(264, 167);
            this.groupBox_dodjelaPristupa.TabIndex = 16;
            this.groupBox_dodjelaPristupa.TabStop = false;
            this.groupBox_dodjelaPristupa.Text = "Dodjela pristupnih podataka";
            this.groupBox_dodjelaPristupa.Visible = false;
            // 
            // textbox_usernameRadnika
            // 
            this.textbox_usernameRadnika.Location = new System.Drawing.Point(134, 58);
            this.textbox_usernameRadnika.Name = "textbox_usernameRadnika";
            this.textbox_usernameRadnika.Size = new System.Drawing.Size(104, 23);
            this.textbox_usernameRadnika.TabIndex = 10;
            this.textbox_usernameRadnika.TextChanged += new System.EventHandler(this.textbox_usernameRadnika_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username: ";
            // 
            // textbox_passwordRadnika
            // 
            this.textbox_passwordRadnika.Location = new System.Drawing.Point(134, 89);
            this.textbox_passwordRadnika.Name = "textbox_passwordRadnika";
            this.textbox_passwordRadnika.Size = new System.Drawing.Size(104, 23);
            this.textbox_passwordRadnika.TabIndex = 9;
            this.textbox_passwordRadnika.TextChanged += new System.EventHandler(this.textbox_passwordRadnika_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // registracija_radnika
            // 
            this.registracija_radnika.Location = new System.Drawing.Point(509, 229);
            this.registracija_radnika.Name = "registracija_radnika";
            this.registracija_radnika.Size = new System.Drawing.Size(102, 29);
            this.registracija_radnika.TabIndex = 15;
            this.registracija_radnika.Text = "Registruj radnika";
            this.registracija_radnika.UseVisualStyleBackColor = true;
            this.registracija_radnika.Click += new System.EventHandler(this.registracija_radnika_Click);
            // 
            // raspored_za_radnika
            // 
            this.raspored_za_radnika.Location = new System.Drawing.Point(389, 229);
            this.raspored_za_radnika.Name = "raspored_za_radnika";
            this.raspored_za_radnika.Size = new System.Drawing.Size(102, 29);
            this.raspored_za_radnika.TabIndex = 14;
            this.raspored_za_radnika.Text = "Kreiraj raspored";
            this.raspored_za_radnika.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage2.Controls.Add(this.groupBox_djelomičnoAnonimniKorisnik);
            this.tabPage2.Controls.Add(this.groupBox_anonimniKorisnik);
            this.tabPage2.Controls.Add(this.button_registrujKorisnika);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.radioButton_potpunoAnoniman);
            this.tabPage2.Controls.Add(this.radioButton_djelomičnoAnoniman);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(655, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registracija novog korisnika";
            // 
            // groupBox_djelomičnoAnonimniKorisnik
            // 
            this.groupBox_djelomičnoAnonimniKorisnik.Controls.Add(this.groupBox3);
            this.groupBox_djelomičnoAnonimniKorisnik.Controls.Add(this.comboBox_personalniPsiholog);
            this.groupBox_djelomičnoAnonimniKorisnik.Controls.Add(this.label11);
            this.groupBox_djelomičnoAnonimniKorisnik.Controls.Add(this.label10);
            this.groupBox_djelomičnoAnonimniKorisnik.Controls.Add(this.comboBox_personalniDoktor);
            this.groupBox_djelomičnoAnonimniKorisnik.Controls.Add(this.dateTimePicker_datumOtpustaKorisnika);
            this.groupBox_djelomičnoAnonimniKorisnik.Controls.Add(this.label9);
            this.groupBox_djelomičnoAnonimniKorisnik.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_djelomičnoAnonimniKorisnik.Location = new System.Drawing.Point(301, 18);
            this.groupBox_djelomičnoAnonimniKorisnik.Name = "groupBox_djelomičnoAnonimniKorisnik";
            this.groupBox_djelomičnoAnonimniKorisnik.Size = new System.Drawing.Size(341, 265);
            this.groupBox_djelomičnoAnonimniKorisnik.TabIndex = 13;
            this.groupBox_djelomičnoAnonimniKorisnik.TabStop = false;
            this.groupBox_djelomičnoAnonimniKorisnik.Text = "Djelomično anoniman korisnik";
            this.groupBox_djelomičnoAnonimniKorisnik.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_dodaneOsobe);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.button_addOsobe);
            this.groupBox3.Controls.Add(this.textBox_dodajOsobu);
            this.groupBox3.Location = new System.Drawing.Point(12, 160);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 82);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Osobe upoznate sa slučajem:";
            // 
            // comboBox_dodaneOsobe
            // 
            this.comboBox_dodaneOsobe.FormattingEnabled = true;
            this.comboBox_dodaneOsobe.Location = new System.Drawing.Point(170, 47);
            this.comboBox_dodaneOsobe.Name = "comboBox_dodaneOsobe";
            this.comboBox_dodaneOsobe.Size = new System.Drawing.Size(140, 24);
            this.comboBox_dodaneOsobe.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(56, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 16);
            this.label15.TabIndex = 10;
            this.label15.Text = "Dodane osobe: ";
            // 
            // button_addOsobe
            // 
            this.button_addOsobe.Location = new System.Drawing.Point(220, 17);
            this.button_addOsobe.Name = "button_addOsobe";
            this.button_addOsobe.Size = new System.Drawing.Size(90, 25);
            this.button_addOsobe.TabIndex = 8;
            this.button_addOsobe.Text = "Dodaj osobu";
            this.button_addOsobe.UseVisualStyleBackColor = true;
            this.button_addOsobe.Click += new System.EventHandler(this.button_addOsobe_Click);
            // 
            // textBox_dodajOsobu
            // 
            this.textBox_dodajOsobu.Location = new System.Drawing.Point(47, 18);
            this.textBox_dodajOsobu.Name = "textBox_dodajOsobu";
            this.textBox_dodajOsobu.Size = new System.Drawing.Size(150, 23);
            this.textBox_dodajOsobu.TabIndex = 7;
            // 
            // comboBox_personalniPsiholog
            // 
            this.comboBox_personalniPsiholog.FormattingEnabled = true;
            this.comboBox_personalniPsiholog.Location = new System.Drawing.Point(186, 79);
            this.comboBox_personalniPsiholog.Name = "comboBox_personalniPsiholog";
            this.comboBox_personalniPsiholog.Size = new System.Drawing.Size(130, 24);
            this.comboBox_personalniPsiholog.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Personalni psiholog: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 57);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 16);
            this.label10.TabIndex = 3;
            this.label10.Text = "Personalni doktor: ";
            // 
            // comboBox_personalniDoktor
            // 
            this.comboBox_personalniDoktor.FormattingEnabled = true;
            this.comboBox_personalniDoktor.Location = new System.Drawing.Point(186, 49);
            this.comboBox_personalniDoktor.Name = "comboBox_personalniDoktor";
            this.comboBox_personalniDoktor.Size = new System.Drawing.Size(130, 24);
            this.comboBox_personalniDoktor.TabIndex = 2;
            // 
            // dateTimePicker_datumOtpustaKorisnika
            // 
            this.dateTimePicker_datumOtpustaKorisnika.Location = new System.Drawing.Point(186, 21);
            this.dateTimePicker_datumOtpustaKorisnika.Name = "dateTimePicker_datumOtpustaKorisnika";
            this.dateTimePicker_datumOtpustaKorisnika.Size = new System.Drawing.Size(130, 23);
            this.dateTimePicker_datumOtpustaKorisnika.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(62, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Datum otpusta: ";
            // 
            // groupBox_anonimniKorisnik
            // 
            this.groupBox_anonimniKorisnik.Controls.Add(this.comboBox_personalniPravnikAnonimniKorisnik);
            this.groupBox_anonimniKorisnik.Controls.Add(this.comboBox_personalniEkonomistaAnonimniKorisnik);
            this.groupBox_anonimniKorisnik.Controls.Add(this.comboBox_personalniPsihologAnonimniKorisnik);
            this.groupBox_anonimniKorisnik.Controls.Add(this.comboBox_personalniDoktorAnonimniKorisnik);
            this.groupBox_anonimniKorisnik.Controls.Add(this.label19);
            this.groupBox_anonimniKorisnik.Controls.Add(this.label18);
            this.groupBox_anonimniKorisnik.Controls.Add(this.label17);
            this.groupBox_anonimniKorisnik.Controls.Add(this.label16);
            this.groupBox_anonimniKorisnik.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox_anonimniKorisnik.Location = new System.Drawing.Point(312, 18);
            this.groupBox_anonimniKorisnik.Name = "groupBox_anonimniKorisnik";
            this.groupBox_anonimniKorisnik.Size = new System.Drawing.Size(318, 237);
            this.groupBox_anonimniKorisnik.TabIndex = 16;
            this.groupBox_anonimniKorisnik.TabStop = false;
            this.groupBox_anonimniKorisnik.Text = "Potpuno aninimni korisnik";
            this.groupBox_anonimniKorisnik.Visible = false;
            // 
            // comboBox_personalniPravnikAnonimniKorisnik
            // 
            this.comboBox_personalniPravnikAnonimniKorisnik.FormattingEnabled = true;
            this.comboBox_personalniPravnikAnonimniKorisnik.Location = new System.Drawing.Point(162, 129);
            this.comboBox_personalniPravnikAnonimniKorisnik.Name = "comboBox_personalniPravnikAnonimniKorisnik";
            this.comboBox_personalniPravnikAnonimniKorisnik.Size = new System.Drawing.Size(126, 24);
            this.comboBox_personalniPravnikAnonimniKorisnik.TabIndex = 7;
            // 
            // comboBox_personalniEkonomistaAnonimniKorisnik
            // 
            this.comboBox_personalniEkonomistaAnonimniKorisnik.FormattingEnabled = true;
            this.comboBox_personalniEkonomistaAnonimniKorisnik.Location = new System.Drawing.Point(162, 100);
            this.comboBox_personalniEkonomistaAnonimniKorisnik.Name = "comboBox_personalniEkonomistaAnonimniKorisnik";
            this.comboBox_personalniEkonomistaAnonimniKorisnik.Size = new System.Drawing.Size(126, 24);
            this.comboBox_personalniEkonomistaAnonimniKorisnik.TabIndex = 6;
            // 
            // comboBox_personalniPsihologAnonimniKorisnik
            // 
            this.comboBox_personalniPsihologAnonimniKorisnik.FormattingEnabled = true;
            this.comboBox_personalniPsihologAnonimniKorisnik.Location = new System.Drawing.Point(162, 67);
            this.comboBox_personalniPsihologAnonimniKorisnik.Name = "comboBox_personalniPsihologAnonimniKorisnik";
            this.comboBox_personalniPsihologAnonimniKorisnik.Size = new System.Drawing.Size(126, 24);
            this.comboBox_personalniPsihologAnonimniKorisnik.TabIndex = 5;
            // 
            // comboBox_personalniDoktorAnonimniKorisnik
            // 
            this.comboBox_personalniDoktorAnonimniKorisnik.FormattingEnabled = true;
            this.comboBox_personalniDoktorAnonimniKorisnik.Location = new System.Drawing.Point(162, 29);
            this.comboBox_personalniDoktorAnonimniKorisnik.Name = "comboBox_personalniDoktorAnonimniKorisnik";
            this.comboBox_personalniDoktorAnonimniKorisnik.Size = new System.Drawing.Size(126, 24);
            this.comboBox_personalniDoktorAnonimniKorisnik.TabIndex = 4;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(23, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 16);
            this.label19.TabIndex = 3;
            this.label19.Text = "Personalni pravnik: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 101);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(141, 16);
            this.label18.TabIndex = 2;
            this.label18.Text = "Personalni ekonomista:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(23, 70);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(127, 16);
            this.label17.TabIndex = 1;
            this.label17.Text = "Personalni psiholog: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(34, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 16);
            this.label16.TabIndex = 0;
            this.label16.Text = "Personalni doktor: ";
            // 
            // button_registrujKorisnika
            // 
            this.button_registrujKorisnika.Location = new System.Drawing.Point(512, 303);
            this.button_registrujKorisnika.Name = "button_registrujKorisnika";
            this.button_registrujKorisnika.Size = new System.Drawing.Size(127, 27);
            this.button_registrujKorisnika.TabIndex = 14;
            this.button_registrujKorisnika.Text = "Registruj korisnika";
            this.button_registrujKorisnika.UseVisualStyleBackColor = true;
            this.button_registrujKorisnika.Click += new System.EventHandler(this.button_registrujKorisnika_Click);
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
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(25, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 261);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Osnovni podaci o korisniku";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 191);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 16);
            this.label14.TabIndex = 12;
            this.label14.Text = "Datum prijema:";
            // 
            // dateTimePicker_datumPrijemaKorisnika
            // 
            this.dateTimePicker_datumPrijemaKorisnika.Location = new System.Drawing.Point(118, 186);
            this.dateTimePicker_datumPrijemaKorisnika.Name = "dateTimePicker_datumPrijemaKorisnika";
            this.dateTimePicker_datumPrijemaKorisnika.Size = new System.Drawing.Size(115, 23);
            this.dateTimePicker_datumPrijemaKorisnika.TabIndex = 11;
            // 
            // comboBox_lokacijaKorisnika
            // 
            this.comboBox_lokacijaKorisnika.FormattingEnabled = true;
            this.comboBox_lokacijaKorisnika.Location = new System.Drawing.Point(118, 218);
            this.comboBox_lokacijaKorisnika.Name = "comboBox_lokacijaKorisnika";
            this.comboBox_lokacijaKorisnika.Size = new System.Drawing.Size(115, 24);
            this.comboBox_lokacijaKorisnika.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 221);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 16);
            this.label13.TabIndex = 10;
            this.label13.Text = "Lokacija: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Datum rođenja: ";
            // 
            // textBox_passwordKorisnika
            // 
            this.textBox_passwordKorisnika.Location = new System.Drawing.Point(118, 157);
            this.textBox_passwordKorisnika.Name = "textBox_passwordKorisnika";
            this.textBox_passwordKorisnika.Size = new System.Drawing.Size(115, 23);
            this.textBox_passwordKorisnika.TabIndex = 8;
            // 
            // textBox_usernameKorisnika
            // 
            this.textBox_usernameKorisnika.Location = new System.Drawing.Point(118, 126);
            this.textBox_usernameKorisnika.Name = "textBox_usernameKorisnika";
            this.textBox_usernameKorisnika.Size = new System.Drawing.Size(115, 23);
            this.textBox_usernameKorisnika.TabIndex = 7;
            // 
            // textBox_prezimeKorisnika
            // 
            this.textBox_prezimeKorisnika.Location = new System.Drawing.Point(118, 63);
            this.textBox_prezimeKorisnika.Name = "textBox_prezimeKorisnika";
            this.textBox_prezimeKorisnika.Size = new System.Drawing.Size(115, 23);
            this.textBox_prezimeKorisnika.TabIndex = 6;
            // 
            // textBox_imeKorisnika
            // 
            this.textBox_imeKorisnika.Location = new System.Drawing.Point(118, 29);
            this.textBox_imeKorisnika.Name = "textBox_imeKorisnika";
            this.textBox_imeKorisnika.Size = new System.Drawing.Size(115, 23);
            this.textBox_imeKorisnika.TabIndex = 5;
            // 
            // dateTimePicker_datRodjenjaKorisnika
            // 
            this.dateTimePicker_datRodjenjaKorisnika.Location = new System.Drawing.Point(118, 94);
            this.dateTimePicker_datRodjenjaKorisnika.Name = "dateTimePicker_datRodjenjaKorisnika";
            this.dateTimePicker_datRodjenjaKorisnika.Size = new System.Drawing.Size(115, 23);
            this.dateTimePicker_datRodjenjaKorisnika.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 16);
            this.label7.TabIndex = 3;
            this.label7.Text = "Password:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Username: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Prezime: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ime: ";
            // 
            // radioButton_potpunoAnoniman
            // 
            this.radioButton_potpunoAnoniman.AutoSize = true;
            this.radioButton_potpunoAnoniman.Location = new System.Drawing.Point(39, 308);
            this.radioButton_potpunoAnoniman.Name = "radioButton_potpunoAnoniman";
            this.radioButton_potpunoAnoniman.Size = new System.Drawing.Size(152, 17);
            this.radioButton_potpunoAnoniman.TabIndex = 11;
            this.radioButton_potpunoAnoniman.TabStop = true;
            this.radioButton_potpunoAnoniman.Text = "Potpuno anoniman korisnik";
            this.radioButton_potpunoAnoniman.UseVisualStyleBackColor = true;
            this.radioButton_potpunoAnoniman.CheckedChanged += new System.EventHandler(this.radioButton_potpunoAnoniman_CheckedChanged);
            // 
            // radioButton_djelomičnoAnoniman
            // 
            this.radioButton_djelomičnoAnoniman.AutoSize = true;
            this.radioButton_djelomičnoAnoniman.Location = new System.Drawing.Point(39, 285);
            this.radioButton_djelomičnoAnoniman.Name = "radioButton_djelomičnoAnoniman";
            this.radioButton_djelomičnoAnoniman.Size = new System.Drawing.Size(163, 17);
            this.radioButton_djelomičnoAnoniman.TabIndex = 10;
            this.radioButton_djelomičnoAnoniman.TabStop = true;
            this.radioButton_djelomičnoAnoniman.Text = "Djelomično anoniman korisnik";
            this.radioButton_djelomičnoAnoniman.UseVisualStyleBackColor = true;
            this.radioButton_djelomičnoAnoniman.CheckedChanged += new System.EventHandler(this.radioButton_djelomičnoAnoniman_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.GhostWhite;
            this.tabPage3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(655, 349);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Upravljanje zahtjevima";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.PapayaWhip;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(655, 349);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Upravljanje rasporedima";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabel1.Location = new System.Drawing.Point(790, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(50, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 135);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AdminForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SafeHouse.Properties.Resources.Background_69;
            this.ClientSize = new System.Drawing.Size(845, 406);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin MainMenu";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox_osnovniPodaci.ResumeLayout(false);
            this.groupBox_osnovniPodaci.PerformLayout();
            this.groupBox_dodjelaPristupa.ResumeLayout(false);
            this.groupBox_dodjelaPristupa.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox_djelomičnoAnonimniKorisnik.ResumeLayout(false);
            this.groupBox_djelomičnoAnonimniKorisnik.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox_anonimniKorisnik.ResumeLayout(false);
            this.groupBox_anonimniKorisnik.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
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
        private System.Windows.Forms.GroupBox groupBox_djelomičnoAnonimniKorisnik;
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
        private System.Windows.Forms.Button button_registrujKorisnika;
        private System.Windows.Forms.Button button_addOsobe;
        private System.Windows.Forms.TextBox textBox_dodajOsobu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox comboBox_lokacijaKorisnika;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker_datumPrijemaKorisnika;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBox_dodaneOsobe;
        private System.Windows.Forms.GroupBox groupBox_anonimniKorisnik;
        private System.Windows.Forms.ComboBox comboBox_personalniPravnikAnonimniKorisnik;
        private System.Windows.Forms.ComboBox comboBox_personalniEkonomistaAnonimniKorisnik;
        private System.Windows.Forms.ComboBox comboBox_personalniPsihologAnonimniKorisnik;
        private System.Windows.Forms.ComboBox comboBox_personalniDoktorAnonimniKorisnik;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}