namespace SafeHouse
{
    partial class PravnikForm
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
            this.button_pregledRasporedaPravnik = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox_listaKorisnikaPravnik = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_azurirajRjesenjePravnik = new System.Windows.Forms.Button();
            this.richTextBox_licneBiljeskePravnik = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox_historijaRjesenjaPravnik = new System.Windows.Forms.RichTextBox();
            this.richTextBox_prijedlogRjesenja = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox_opisProblemaPravnik = new System.Windows.Forms.RichTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 120);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_pregledRasporedaPravnik
            // 
            this.button_pregledRasporedaPravnik.Location = new System.Drawing.Point(6, 302);
            this.button_pregledRasporedaPravnik.Name = "button_pregledRasporedaPravnik";
            this.button_pregledRasporedaPravnik.Size = new System.Drawing.Size(107, 24);
            this.button_pregledRasporedaPravnik.TabIndex = 1;
            this.button_pregledRasporedaPravnik.Text = "Pregled rasporeda";
            this.button_pregledRasporedaPravnik.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prezime";
            // 
            // listBox_listaKorisnikaPravnik
            // 
            this.listBox_listaKorisnikaPravnik.FormattingEnabled = true;
            this.listBox_listaKorisnikaPravnik.Location = new System.Drawing.Point(162, 37);
            this.listBox_listaKorisnikaPravnik.Name = "listBox_listaKorisnikaPravnik";
            this.listBox_listaKorisnikaPravnik.Size = new System.Drawing.Size(143, 290);
            this.listBox_listaKorisnikaPravnik.TabIndex = 4;
            this.listBox_listaKorisnikaPravnik.SelectedIndexChanged += new System.EventHandler(this.listBox_listaKorisnikaPravnik_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lista korisnika";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_azurirajRjesenjePravnik);
            this.groupBox1.Controls.Add(this.richTextBox_licneBiljeskePravnik);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.richTextBox_historijaRjesenjaPravnik);
            this.groupBox1.Controls.Add(this.richTextBox_prijedlogRjesenja);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.richTextBox_opisProblemaPravnik);
            this.groupBox1.Location = new System.Drawing.Point(327, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 311);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opšti podaci o korisniku";
            // 
            // button_azurirajRjesenjePravnik
            // 
            this.button_azurirajRjesenjePravnik.Location = new System.Drawing.Point(436, 108);
            this.button_azurirajRjesenjePravnik.Name = "button_azurirajRjesenjePravnik";
            this.button_azurirajRjesenjePravnik.Size = new System.Drawing.Size(100, 24);
            this.button_azurirajRjesenjePravnik.TabIndex = 8;
            this.button_azurirajRjesenjePravnik.Text = "Ažuriraj rješenje";
            this.button_azurirajRjesenjePravnik.UseVisualStyleBackColor = true;
            this.button_azurirajRjesenjePravnik.Click += new System.EventHandler(this.button_azurirajRjesenjePravnik_Click);
            // 
            // richTextBox_licneBiljeskePravnik
            // 
            this.richTextBox_licneBiljeskePravnik.Location = new System.Drawing.Point(200, 239);
            this.richTextBox_licneBiljeskePravnik.Name = "richTextBox_licneBiljeskePravnik";
            this.richTextBox_licneBiljeskePravnik.Size = new System.Drawing.Size(339, 66);
            this.richTextBox_licneBiljeskePravnik.TabIndex = 7;
            this.richTextBox_licneBiljeskePravnik.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Lične bilješke";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Historija rješenja";
            // 
            // richTextBox_historijaRjesenjaPravnik
            // 
            this.richTextBox_historijaRjesenjaPravnik.Location = new System.Drawing.Point(200, 150);
            this.richTextBox_historijaRjesenjaPravnik.Name = "richTextBox_historijaRjesenjaPravnik";
            this.richTextBox_historijaRjesenjaPravnik.Size = new System.Drawing.Size(339, 70);
            this.richTextBox_historijaRjesenjaPravnik.TabIndex = 4;
            this.richTextBox_historijaRjesenjaPravnik.Text = "";
            // 
            // richTextBox_prijedlogRjesenja
            // 
            this.richTextBox_prijedlogRjesenja.Location = new System.Drawing.Point(197, 36);
            this.richTextBox_prijedlogRjesenja.Name = "richTextBox_prijedlogRjesenja";
            this.richTextBox_prijedlogRjesenja.Size = new System.Drawing.Size(339, 66);
            this.richTextBox_prijedlogRjesenja.TabIndex = 3;
            this.richTextBox_prijedlogRjesenja.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(194, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Prijedlog rješenja";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Opis problema";
            // 
            // richTextBox_opisProblemaPravnik
            // 
            this.richTextBox_opisProblemaPravnik.Location = new System.Drawing.Point(17, 36);
            this.richTextBox_opisProblemaPravnik.Name = "richTextBox_opisProblemaPravnik";
            this.richTextBox_opisProblemaPravnik.Size = new System.Drawing.Size(150, 269);
            this.richTextBox_opisProblemaPravnik.TabIndex = 0;
            this.richTextBox_opisProblemaPravnik.Text = "";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(827, 5);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 13);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // PravnikForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 344);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_listaKorisnikaPravnik);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_pregledRasporedaPravnik);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PravnikForm";
            this.Text = "Pravnik";
            this.Load += new System.EventHandler(this.PravnikForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_pregledRasporedaPravnik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox_listaKorisnikaPravnik;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox_licneBiljeskePravnik;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox_historijaRjesenjaPravnik;
        private System.Windows.Forms.RichTextBox richTextBox_prijedlogRjesenja;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox_opisProblemaPravnik;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button button_azurirajRjesenjePravnik;
    }
}