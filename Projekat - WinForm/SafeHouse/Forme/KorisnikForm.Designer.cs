﻿namespace SafeHouse
{
    partial class KorisnikForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.radioButton_ekonomskaRjesenjaKorisnik = new System.Windows.Forms.RadioButton();
            this.radioButton_pravnaRjesenjaKorisnik = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_obavjestOZahtjevimaKorisniku = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox_standardniTermini = new System.Windows.Forms.CheckBox();
            this.checkBox_dodatniTermini = new System.Windows.Forms.CheckBox();
            this.groupBox_zahtjeviZaAnonimnogKorisnika = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.linkLabel_logOutKorisnik = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox_zahtjeviZaAnonimnogKorisnika.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(13, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 127);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(13, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 184);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID broj";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 375);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pregled rasporeda";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(151, 14);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 419);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(688, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Lični karton";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox3);
            this.groupBox1.Controls.Add(this.radioButton_ekonomskaRjesenjaKorisnik);
            this.groupBox1.Controls.Add(this.radioButton_pravnaRjesenjaKorisnik);
            this.groupBox1.Location = new System.Drawing.Point(21, 246);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(641, 113);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekonomska i pravna pomoć ";
            this.groupBox1.Visible = false;
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(154, 22);
            this.richTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(469, 73);
            this.richTextBox3.TabIndex = 2;
            this.richTextBox3.Text = "";
            // 
            // radioButton_ekonomskaRjesenjaKorisnik
            // 
            this.radioButton_ekonomskaRjesenjaKorisnik.AutoSize = true;
            this.radioButton_ekonomskaRjesenjaKorisnik.Location = new System.Drawing.Point(17, 57);
            this.radioButton_ekonomskaRjesenjaKorisnik.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_ekonomskaRjesenjaKorisnik.Name = "radioButton_ekonomskaRjesenjaKorisnik";
            this.radioButton_ekonomskaRjesenjaKorisnik.Size = new System.Drawing.Size(137, 19);
            this.radioButton_ekonomskaRjesenjaKorisnik.TabIndex = 1;
            this.radioButton_ekonomskaRjesenjaKorisnik.TabStop = true;
            this.radioButton_ekonomskaRjesenjaKorisnik.Text = "Ekonomska rješenja";
            this.radioButton_ekonomskaRjesenjaKorisnik.UseVisualStyleBackColor = true;
            this.radioButton_ekonomskaRjesenjaKorisnik.CheckedChanged += new System.EventHandler(this.radioButton_ekonomskaRjesenjaKorisnik_CheckedChanged);
            // 
            // radioButton_pravnaRjesenjaKorisnik
            // 
            this.radioButton_pravnaRjesenjaKorisnik.AutoSize = true;
            this.radioButton_pravnaRjesenjaKorisnik.Location = new System.Drawing.Point(17, 31);
            this.radioButton_pravnaRjesenjaKorisnik.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton_pravnaRjesenjaKorisnik.Name = "radioButton_pravnaRjesenjaKorisnik";
            this.radioButton_pravnaRjesenjaKorisnik.Size = new System.Drawing.Size(110, 19);
            this.radioButton_pravnaRjesenjaKorisnik.TabIndex = 0;
            this.radioButton_pravnaRjesenjaKorisnik.TabStop = true;
            this.radioButton_pravnaRjesenjaKorisnik.Text = "Pravna rješenja";
            this.radioButton_pravnaRjesenjaKorisnik.UseVisualStyleBackColor = true;
            this.radioButton_pravnaRjesenjaKorisnik.CheckedChanged += new System.EventHandler(this.radioButton_pravnaRjesenjaKorisnik_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Psihoterapijski napredak";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(18, 153);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(644, 85);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nalazi sistematskih pregleda";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(18, 39);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(644, 84);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.groupBox_obavjestOZahtjevimaKorisniku);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(688, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zahtjevi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Maroon;
            this.label7.Location = new System.Drawing.Point(36, 209);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(588, 45);
            this.label7.TabIndex = 3;
            this.label7.Text = "Note: Podnošenje zahtjeva koristite ukoliko želite dodatne termine, ili ukoliko d" +
    "o sada niste dobili dodjeljen \r\nraspored za termine koji su uključeni u vaš prog" +
    "ram. \r\n\r\n";
            // 
            // groupBox_obavjestOZahtjevimaKorisniku
            // 
            this.groupBox_obavjestOZahtjevimaKorisniku.BackColor = System.Drawing.Color.OldLace;
            this.groupBox_obavjestOZahtjevimaKorisniku.Location = new System.Drawing.Point(18, 250);
            this.groupBox_obavjestOZahtjevimaKorisniku.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_obavjestOZahtjevimaKorisniku.Name = "groupBox_obavjestOZahtjevimaKorisniku";
            this.groupBox_obavjestOZahtjevimaKorisniku.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_obavjestOZahtjevimaKorisniku.Size = new System.Drawing.Size(640, 154);
            this.groupBox_obavjestOZahtjevimaKorisniku.TabIndex = 2;
            this.groupBox_obavjestOZahtjevimaKorisniku.TabStop = false;
            this.groupBox_obavjestOZahtjevimaKorisniku.Text = "Obavjesti o odobravanju/odbijanju podnesenih zahtjeva";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox_zahtjeviZaAnonimnogKorisnika);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.checkBox4);
            this.groupBox2.Controls.Add(this.checkBox3);
            this.groupBox2.Location = new System.Drawing.Point(15, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(651, 199);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Podnošenje zahtjeva";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox_standardniTermini);
            this.groupBox5.Controls.Add(this.checkBox_dodatniTermini);
            this.groupBox5.Location = new System.Drawing.Point(276, 39);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(354, 119);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Vrsta zahtjeva";
            // 
            // checkBox_standardniTermini
            // 
            this.checkBox_standardniTermini.AutoSize = true;
            this.checkBox_standardniTermini.Location = new System.Drawing.Point(27, 65);
            this.checkBox_standardniTermini.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_standardniTermini.Name = "checkBox_standardniTermini";
            this.checkBox_standardniTermini.Size = new System.Drawing.Size(323, 19);
            this.checkBox_standardniTermini.TabIndex = 1;
            this.checkBox_standardniTermini.Text = "Želim standardne termine koji mi trebaju biti dodjeljeni";
            this.checkBox_standardniTermini.UseVisualStyleBackColor = true;
            // 
            // checkBox_dodatniTermini
            // 
            this.checkBox_dodatniTermini.AutoSize = true;
            this.checkBox_dodatniTermini.Location = new System.Drawing.Point(27, 38);
            this.checkBox_dodatniTermini.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_dodatniTermini.Name = "checkBox_dodatniTermini";
            this.checkBox_dodatniTermini.Size = new System.Drawing.Size(259, 19);
            this.checkBox_dodatniTermini.TabIndex = 0;
            this.checkBox_dodatniTermini.Text = "Želim dodatne termine za označene opcije";
            this.checkBox_dodatniTermini.UseVisualStyleBackColor = true;
            // 
            // groupBox_zahtjeviZaAnonimnogKorisnika
            // 
            this.groupBox_zahtjeviZaAnonimnogKorisnika.Controls.Add(this.checkBox1);
            this.groupBox_zahtjeviZaAnonimnogKorisnika.Controls.Add(this.checkBox2);
            this.groupBox_zahtjeviZaAnonimnogKorisnika.Location = new System.Drawing.Point(18, 86);
            this.groupBox_zahtjeviZaAnonimnogKorisnika.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox_zahtjeviZaAnonimnogKorisnika.Name = "groupBox_zahtjeviZaAnonimnogKorisnika";
            this.groupBox_zahtjeviZaAnonimnogKorisnika.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox_zahtjeviZaAnonimnogKorisnika.Size = new System.Drawing.Size(202, 71);
            this.groupBox_zahtjeviZaAnonimnogKorisnika.TabIndex = 7;
            this.groupBox_zahtjeviZaAnonimnogKorisnika.TabStop = false;
            this.groupBox_zahtjeviZaAnonimnogKorisnika.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(7, 16);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(162, 19);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Zahtjev za pravnu pomoć";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(7, 43);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(189, 19);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Zahtjev za ekonomsku pomoć";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 165);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 29);
            this.button2.TabIndex = 4;
            this.button2.Text = "Podnesi zahtjev";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(18, 66);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(188, 19);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "Zahtjev za medicinsku pomoć";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(18, 39);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(184, 19);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "Zahtjev za psihološku pomoć";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(688, 391);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Web";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.webBrowser1);
            this.groupBox4.Location = new System.Drawing.Point(20, 36);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(647, 364);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Web pretraživanje";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(4, 18);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(24, 23);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(639, 342);
            this.webBrowser1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage4.Size = new System.Drawing.Size(688, 391);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Iskustva prethodnih korisnika";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage5.Size = new System.Drawing.Size(688, 391);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Pomoć";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // linkLabel_logOutKorisnik
            // 
            this.linkLabel_logOutKorisnik.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel_logOutKorisnik.AutoSize = true;
            this.linkLabel_logOutKorisnik.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_logOutKorisnik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel_logOutKorisnik.ForeColor = System.Drawing.Color.MidnightBlue;
            this.linkLabel_logOutKorisnik.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel_logOutKorisnik.LinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabel_logOutKorisnik.Location = new System.Drawing.Point(790, 14);
            this.linkLabel_logOutKorisnik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel_logOutKorisnik.Name = "linkLabel_logOutKorisnik";
            this.linkLabel_logOutKorisnik.Size = new System.Drawing.Size(57, 15);
            this.linkLabel_logOutKorisnik.TabIndex = 6;
            this.linkLabel_logOutKorisnik.TabStop = true;
            this.linkLabel_logOutKorisnik.Text = "Log Out";
            this.linkLabel_logOutKorisnik.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel_logOutKorisnik.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_logOutKorisnik_LinkClicked);
            // 
            // KorisnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SafeHouse.Properties.Resources.Background_69;
            this.ClientSize = new System.Drawing.Size(852, 445);
            this.Controls.Add(this.linkLabel_logOutKorisnik);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KorisnikForm";
            this.Text = "Korisnik";
            this.Load += new System.EventHandler(this.Korisnik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox_zahtjeviZaAnonimnogKorisnika.ResumeLayout(false);
            this.groupBox_zahtjeviZaAnonimnogKorisnika.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RadioButton radioButton_ekonomskaRjesenjaKorisnik;
        private System.Windows.Forms.RadioButton radioButton_pravnaRjesenjaKorisnik;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox_obavjestOZahtjevimaKorisniku;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.LinkLabel linkLabel_logOutKorisnik;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox_standardniTermini;
        private System.Windows.Forms.CheckBox checkBox_dodatniTermini;
        private System.Windows.Forms.GroupBox groupBox_zahtjeviZaAnonimnogKorisnika;
    }
}