﻿
namespace BankaOtomasyonu
{
    partial class login
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
            this.yoneticibutton = new System.Windows.Forms.Button();
            this.musteributton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 19.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(178, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "BERFİNBANK";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(73, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "HOŞGELDİNİZ";
            // 
            // yoneticibutton
            // 
            this.yoneticibutton.BackColor = System.Drawing.Color.PowderBlue;
            this.yoneticibutton.Location = new System.Drawing.Point(79, 178);
            this.yoneticibutton.Name = "yoneticibutton";
            this.yoneticibutton.Size = new System.Drawing.Size(215, 90);
            this.yoneticibutton.TabIndex = 2;
            this.yoneticibutton.Text = "YÖNETİCİ \r\nGİRİŞİ\r\n";
            this.yoneticibutton.UseVisualStyleBackColor = false;
            this.yoneticibutton.Click += new System.EventHandler(this.yoneticibutton_Click);
            // 
            // musteributton
            // 
            this.musteributton.BackColor = System.Drawing.Color.PowderBlue;
            this.musteributton.Location = new System.Drawing.Point(79, 292);
            this.musteributton.Name = "musteributton";
            this.musteributton.Size = new System.Drawing.Size(215, 90);
            this.musteributton.TabIndex = 3;
            this.musteributton.Text = "MÜŞTERİ\r\nGİRİŞİ";
            this.musteributton.UseVisualStyleBackColor = false;
            this.musteributton.Click += new System.EventHandler(this.musteributton_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(686, 465);
            this.Controls.Add(this.musteributton);
            this.Controls.Add(this.yoneticibutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.Text = ",";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button yoneticibutton;
        private System.Windows.Forms.Button musteributton;
    }
}