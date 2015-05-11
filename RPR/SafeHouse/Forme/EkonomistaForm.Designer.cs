namespace SafeHouse
{
    partial class EkonomistaForm
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
            this.label_imeEkonomiste = new System.Windows.Forms.Label();
            this.label_prezimeEkonomiste = new System.Windows.Forms.Label();
            this.button_pregledRasporedaEkonomist = new System.Windows.Forms.Button();
            this.listBox_ListaKorisnikaEkonomist = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox_licneBiljeskeEkonomist = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox_historijaRješenjaEkonomist = new System.Windows.Forms.RichTextBox();
            this.button_azurirajPrijedlogeEkonomist = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox_prijedlogRjesenjaEkonomist = new System.Windows.Forms.RichTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 118);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_imeEkonomiste
            // 
            this.label_imeEkonomiste.AutoSize = true;
            this.label_imeEkonomiste.BackColor = System.Drawing.Color.Transparent;
            this.label_imeEkonomiste.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_imeEkonomiste.Location = new System.Drawing.Point(14, 148);
            this.label_imeEkonomiste.Name = "label_imeEkonomiste";
            this.label_imeEkonomiste.Size = new System.Drawing.Size(28, 14);
            this.label_imeEkonomiste.TabIndex = 1;
            this.label_imeEkonomiste.Text = "Ime";
            // 
            // label_prezimeEkonomiste
            // 
            this.label_prezimeEkonomiste.AutoSize = true;
            this.label_prezimeEkonomiste.BackColor = System.Drawing.Color.Transparent;
            this.label_prezimeEkonomiste.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label_prezimeEkonomiste.Location = new System.Drawing.Point(14, 178);
            this.label_prezimeEkonomiste.Name = "label_prezimeEkonomiste";
            this.label_prezimeEkonomiste.Size = new System.Drawing.Size(49, 14);
            this.label_prezimeEkonomiste.TabIndex = 2;
            this.label_prezimeEkonomiste.Text = "Prezime";
            // 
            // button_pregledRasporedaEkonomist
            // 
            this.button_pregledRasporedaEkonomist.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_pregledRasporedaEkonomist.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button_pregledRasporedaEkonomist.Location = new System.Drawing.Point(17, 327);
            this.button_pregledRasporedaEkonomist.Name = "button_pregledRasporedaEkonomist";
            this.button_pregledRasporedaEkonomist.Size = new System.Drawing.Size(91, 33);
            this.button_pregledRasporedaEkonomist.TabIndex = 3;
            this.button_pregledRasporedaEkonomist.Text = "Raspored";
            this.button_pregledRasporedaEkonomist.UseVisualStyleBackColor = true;
            // 
            // listBox_ListaKorisnikaEkonomist
            // 
            this.listBox_ListaKorisnikaEkonomist.FormattingEnabled = true;
            this.listBox_ListaKorisnikaEkonomist.ItemHeight = 14;
            this.listBox_ListaKorisnikaEkonomist.Location = new System.Drawing.Point(160, 48);
            this.listBox_ListaKorisnikaEkonomist.Name = "listBox_ListaKorisnikaEkonomist";
            this.listBox_ListaKorisnikaEkonomist.Size = new System.Drawing.Size(136, 312);
            this.listBox_ListaKorisnikaEkonomist.TabIndex = 4;
            this.listBox_ListaKorisnikaEkonomist.SelectedIndexChanged += new System.EventHandler(this.listBox_ListaKorisnikaEkonomist_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lista postojećih korisnika";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.GhostWhite;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.richTextBox_licneBiljeskeEkonomist);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.richTextBox_historijaRješenjaEkonomist);
            this.groupBox1.Controls.Add(this.button_azurirajPrijedlogeEkonomist);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.richTextBox_prijedlogRjesenjaEkonomist);
            this.groupBox1.Location = new System.Drawing.Point(303, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 334);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opšti podaci o korisniku";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "Lične bilješke";
            // 
            // richTextBox_licneBiljeskeEkonomist
            // 
            this.richTextBox_licneBiljeskeEkonomist.Location = new System.Drawing.Point(222, 218);
            this.richTextBox_licneBiljeskeEkonomist.Name = "richTextBox_licneBiljeskeEkonomist";
            this.richTextBox_licneBiljeskeEkonomist.Size = new System.Drawing.Size(312, 108);
            this.richTextBox_licneBiljeskeEkonomist.TabIndex = 5;
            this.richTextBox_licneBiljeskeEkonomist.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Historija rješenja";
            // 
            // richTextBox_historijaRješenjaEkonomist
            // 
            this.richTextBox_historijaRješenjaEkonomist.Location = new System.Drawing.Point(17, 46);
            this.richTextBox_historijaRješenjaEkonomist.Name = "richTextBox_historijaRješenjaEkonomist";
            this.richTextBox_historijaRješenjaEkonomist.Size = new System.Drawing.Size(180, 281);
            this.richTextBox_historijaRješenjaEkonomist.TabIndex = 3;
            this.richTextBox_historijaRješenjaEkonomist.Text = "";
            // 
            // button_azurirajPrijedlogeEkonomist
            // 
            this.button_azurirajPrijedlogeEkonomist.Location = new System.Drawing.Point(412, 152);
            this.button_azurirajPrijedlogeEkonomist.Name = "button_azurirajPrijedlogeEkonomist";
            this.button_azurirajPrijedlogeEkonomist.Size = new System.Drawing.Size(122, 27);
            this.button_azurirajPrijedlogeEkonomist.TabIndex = 2;
            this.button_azurirajPrijedlogeEkonomist.Text = "Ažuriraj prijedloge";
            this.button_azurirajPrijedlogeEkonomist.UseVisualStyleBackColor = true;
            this.button_azurirajPrijedlogeEkonomist.Click += new System.EventHandler(this.button_azurirajPrijedlogeEkonomist_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 14);
            this.label4.TabIndex = 1;
            this.label4.Text = "Prijedlog rješenja";
            // 
            // richTextBox_prijedlogRjesenjaEkonomist
            // 
            this.richTextBox_prijedlogRjesenjaEkonomist.Location = new System.Drawing.Point(222, 46);
            this.richTextBox_prijedlogRjesenjaEkonomist.Name = "richTextBox_prijedlogRjesenjaEkonomist";
            this.richTextBox_prijedlogRjesenjaEkonomist.Size = new System.Drawing.Size(312, 100);
            this.richTextBox_prijedlogRjesenjaEkonomist.TabIndex = 0;
            this.richTextBox_prijedlogRjesenjaEkonomist.Text = "";
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.MediumBlue;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.MidnightBlue;
            this.linkLabel1.Location = new System.Drawing.Point(793, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(57, 14);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // EkonomistaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SafeHouse.Properties.Resources.Background_69;
            this.ClientSize = new System.Drawing.Size(860, 374);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_ListaKorisnikaEkonomist);
            this.Controls.Add(this.button_pregledRasporedaEkonomist);
            this.Controls.Add(this.label_prezimeEkonomiste);
            this.Controls.Add(this.label_imeEkonomiste);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "EkonomistaForm";
            this.Text = "Ekonomista";
            this.Load += new System.EventHandler(this.EkonomistaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_imeEkonomiste;
        private System.Windows.Forms.Label label_prezimeEkonomiste;
        private System.Windows.Forms.Button button_pregledRasporedaEkonomist;
        private System.Windows.Forms.ListBox listBox_ListaKorisnikaEkonomist;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox_licneBiljeskeEkonomist;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox_historijaRješenjaEkonomist;
        private System.Windows.Forms.Button button_azurirajPrijedlogeEkonomist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox_prijedlogRjesenjaEkonomist;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}