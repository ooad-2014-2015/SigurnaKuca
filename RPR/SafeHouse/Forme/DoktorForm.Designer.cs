namespace SafeHouse
{
    partial class DoktorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxImeDok = new System.Windows.Forms.TextBox();
            this.textBoxPrezimeDok = new System.Windows.Forms.TextBox();
            this.textBoxOpisDok = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Opis:";
            // 
            // textBoxImeDok
            // 
            this.textBoxImeDok.Location = new System.Drawing.Point(120, 28);
            this.textBoxImeDok.Name = "textBoxImeDok";
            this.textBoxImeDok.Size = new System.Drawing.Size(125, 20);
            this.textBoxImeDok.TabIndex = 3;
            // 
            // textBoxPrezimeDok
            // 
            this.textBoxPrezimeDok.Location = new System.Drawing.Point(120, 64);
            this.textBoxPrezimeDok.Name = "textBoxPrezimeDok";
            this.textBoxPrezimeDok.Size = new System.Drawing.Size(125, 20);
            this.textBoxPrezimeDok.TabIndex = 4;
            // 
            // textBoxOpisDok
            // 
            this.textBoxOpisDok.Location = new System.Drawing.Point(120, 97);
            this.textBoxOpisDok.Name = "textBoxOpisDok";
            this.textBoxOpisDok.Size = new System.Drawing.Size(125, 20);
            this.textBoxOpisDok.TabIndex = 5;
            // 
            // DoktorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 262);
            this.Controls.Add(this.textBoxOpisDok);
            this.Controls.Add(this.textBoxPrezimeDok);
            this.Controls.Add(this.textBoxImeDok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DoktorForm";
            this.Text = "Doktor";
            this.Load += new System.EventHandler(this.DoktorForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxImeDok;
        private System.Windows.Forms.TextBox textBoxPrezimeDok;
        private System.Windows.Forms.TextBox textBoxOpisDok;
    }
}