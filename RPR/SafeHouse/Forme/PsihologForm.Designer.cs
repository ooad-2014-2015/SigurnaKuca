namespace SafeHouse
{
    partial class PsihologForm
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
            this.label_imePsiholog = new System.Windows.Forms.Label();
            this.label_prezimePsiholog = new System.Windows.Forms.Label();
            this.button_prikaziRasporedPsiholog = new System.Windows.Forms.Button();
            this.listBox_listaPacijenataPsiholog = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBox_licneBiljeskePsiholog = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_azurirajPodatkePsiholog = new System.Windows.Forms.Button();
            this.richTextBox_nalaziSistematskogPsiholog = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBox_novaDijagnozaPsiholog = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox_napredakTerapijePsiholog = new System.Windows.Forms.RichTextBox();
            this.button_dodatniTerminPsiholog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_imePsiholog
            // 
            this.label_imePsiholog.AutoSize = true;
            this.label_imePsiholog.Location = new System.Drawing.Point(9, 173);
            this.label_imePsiholog.Name = "label_imePsiholog";
            this.label_imePsiholog.Size = new System.Drawing.Size(24, 13);
            this.label_imePsiholog.TabIndex = 1;
            this.label_imePsiholog.Text = "Ime";
            // 
            // label_prezimePsiholog
            // 
            this.label_prezimePsiholog.AutoSize = true;
            this.label_prezimePsiholog.Location = new System.Drawing.Point(9, 199);
            this.label_prezimePsiholog.Name = "label_prezimePsiholog";
            this.label_prezimePsiholog.Size = new System.Drawing.Size(44, 13);
            this.label_prezimePsiholog.TabIndex = 2;
            this.label_prezimePsiholog.Text = "Prezime";
            // 
            // button_prikaziRasporedPsiholog
            // 
            this.button_prikaziRasporedPsiholog.Location = new System.Drawing.Point(12, 323);
            this.button_prikaziRasporedPsiholog.Name = "button_prikaziRasporedPsiholog";
            this.button_prikaziRasporedPsiholog.Size = new System.Drawing.Size(103, 35);
            this.button_prikaziRasporedPsiholog.TabIndex = 3;
            this.button_prikaziRasporedPsiholog.Text = "Pogledaj raspored";
            this.button_prikaziRasporedPsiholog.UseVisualStyleBackColor = true;
            // 
            // listBox_listaPacijenataPsiholog
            // 
            this.listBox_listaPacijenataPsiholog.FormattingEnabled = true;
            this.listBox_listaPacijenataPsiholog.Location = new System.Drawing.Point(172, 45);
            this.listBox_listaPacijenataPsiholog.Name = "listBox_listaPacijenataPsiholog";
            this.listBox_listaPacijenataPsiholog.Size = new System.Drawing.Size(159, 355);
            this.listBox_listaPacijenataPsiholog.TabIndex = 4;
            this.listBox_listaPacijenataPsiholog.SelectedIndexChanged += new System.EventHandler(this.listBox_listaPacijenataPsiholog_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lista pacijenata";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(935, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(45, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Log Out";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.richTextBox_licneBiljeskePsiholog);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button_azurirajPodatkePsiholog);
            this.groupBox1.Controls.Add(this.richTextBox_nalaziSistematskogPsiholog);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.richTextBox_novaDijagnozaPsiholog);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.richTextBox_napredakTerapijePsiholog);
            this.groupBox1.Location = new System.Drawing.Point(337, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 381);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opšti podaci o pacijentu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(203, 264);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Lične bilješke";
            // 
            // richTextBox_licneBiljeskePsiholog
            // 
            this.richTextBox_licneBiljeskePsiholog.Location = new System.Drawing.Point(206, 280);
            this.richTextBox_licneBiljeskePsiholog.Name = "richTextBox_licneBiljeskePsiholog";
            this.richTextBox_licneBiljeskePsiholog.Size = new System.Drawing.Size(429, 94);
            this.richTextBox_licneBiljeskePsiholog.TabIndex = 7;
            this.richTextBox_licneBiljeskePsiholog.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(203, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Dijagnoza nove terapije";
            // 
            // button_azurirajPodatkePsiholog
            // 
            this.button_azurirajPodatkePsiholog.Location = new System.Drawing.Point(537, 134);
            this.button_azurirajPodatkePsiholog.Name = "button_azurirajPodatkePsiholog";
            this.button_azurirajPodatkePsiholog.Size = new System.Drawing.Size(100, 27);
            this.button_azurirajPodatkePsiholog.TabIndex = 5;
            this.button_azurirajPodatkePsiholog.Text = "Ažuriraj podatke";
            this.button_azurirajPodatkePsiholog.UseVisualStyleBackColor = true;
            this.button_azurirajPodatkePsiholog.Click += new System.EventHandler(this.button_azurirajPodatkePsiholog_Click);
            // 
            // richTextBox_nalaziSistematskogPsiholog
            // 
            this.richTextBox_nalaziSistematskogPsiholog.Location = new System.Drawing.Point(204, 174);
            this.richTextBox_nalaziSistematskogPsiholog.Name = "richTextBox_nalaziSistematskogPsiholog";
            this.richTextBox_nalaziSistematskogPsiholog.Size = new System.Drawing.Size(432, 77);
            this.richTextBox_nalaziSistematskogPsiholog.TabIndex = 4;
            this.richTextBox_nalaziSistematskogPsiholog.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nalazi sistematskog pregleda";
            // 
            // richTextBox_novaDijagnozaPsiholog
            // 
            this.richTextBox_novaDijagnozaPsiholog.Location = new System.Drawing.Point(204, 45);
            this.richTextBox_novaDijagnozaPsiholog.Name = "richTextBox_novaDijagnozaPsiholog";
            this.richTextBox_novaDijagnozaPsiholog.Size = new System.Drawing.Size(433, 83);
            this.richTextBox_novaDijagnozaPsiholog.TabIndex = 2;
            this.richTextBox_novaDijagnozaPsiholog.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Podaci o napretku terapije";
            // 
            // richTextBox_napredakTerapijePsiholog
            // 
            this.richTextBox_napredakTerapijePsiholog.Location = new System.Drawing.Point(11, 44);
            this.richTextBox_napredakTerapijePsiholog.Name = "richTextBox_napredakTerapijePsiholog";
            this.richTextBox_napredakTerapijePsiholog.Size = new System.Drawing.Size(184, 330);
            this.richTextBox_napredakTerapijePsiholog.TabIndex = 0;
            this.richTextBox_napredakTerapijePsiholog.Text = "";
            // 
            // button_dodatniTerminPsiholog
            // 
            this.button_dodatniTerminPsiholog.Location = new System.Drawing.Point(12, 364);
            this.button_dodatniTerminPsiholog.Name = "button_dodatniTerminPsiholog";
            this.button_dodatniTerminPsiholog.Size = new System.Drawing.Size(103, 35);
            this.button_dodatniTerminPsiholog.TabIndex = 8;
            this.button_dodatniTerminPsiholog.Text = "Zahtjev za dodatni termin";
            this.button_dodatniTerminPsiholog.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SafeHouse.Properties.Resources.Serviciil_de_psihologie_cabinet_individual_4916121_1271249488;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 146);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PsihologForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 411);
            this.Controls.Add(this.button_dodatniTerminPsiholog);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox_listaPacijenataPsiholog);
            this.Controls.Add(this.button_prikaziRasporedPsiholog);
            this.Controls.Add(this.label_prezimePsiholog);
            this.Controls.Add(this.label_imePsiholog);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PsihologForm";
            this.Text = "Psiholog";
            this.Load += new System.EventHandler(this.PsihologForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_imePsiholog;
        private System.Windows.Forms.Label label_prezimePsiholog;
        private System.Windows.Forms.Button button_prikaziRasporedPsiholog;
        private System.Windows.Forms.ListBox listBox_listaPacijenataPsiholog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox_napredakTerapijePsiholog;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox richTextBox_licneBiljeskePsiholog;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_azurirajPodatkePsiholog;
        private System.Windows.Forms.RichTextBox richTextBox_nalaziSistematskogPsiholog;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBox_novaDijagnozaPsiholog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_dodatniTerminPsiholog;
    }
}