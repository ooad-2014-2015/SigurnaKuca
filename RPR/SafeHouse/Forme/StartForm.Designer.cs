﻿namespace SafeHouse
{
    partial class StartForm
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
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.username_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.prijava_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(276, 76);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(61, 13);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Username: ";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(276, 106);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(59, 13);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password: ";
            // 
            // username_textbox
            // 
            this.username_textbox.Location = new System.Drawing.Point(343, 69);
            this.username_textbox.Name = "username_textbox";
            this.username_textbox.Size = new System.Drawing.Size(120, 20);
            this.username_textbox.TabIndex = 2;
            this.username_textbox.TextChanged += new System.EventHandler(this.username_textbox_TextChanged);
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(343, 99);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(120, 20);
            this.password_textbox.TabIndex = 3;
            this.password_textbox.UseSystemPasswordChar = true;
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            // 
            // prijava_button
            // 
            this.prijava_button.Location = new System.Drawing.Point(392, 141);
            this.prijava_button.Name = "prijava_button";
            this.prijava_button.Size = new System.Drawing.Size(103, 28);
            this.prijava_button.TabIndex = 4;
            this.prijava_button.Text = "Prijavi se";
            this.prijava_button.UseVisualStyleBackColor = true;
            this.prijava_button.Click += new System.EventHandler(this.prijava_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 25);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartForm
            // 
            this.AcceptButton = this.prijava_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 282);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prijava_button);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.username_textbox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Name = "StartForm";
            this.Text = "StartForm";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox username_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Button prijava_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button button1;
    }
}