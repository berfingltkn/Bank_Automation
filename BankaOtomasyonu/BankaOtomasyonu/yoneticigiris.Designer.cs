
namespace BankaOtomasyonu
{
    partial class yoneticigiris
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sifretextBox = new System.Windows.Forms.TextBox();
            this.tctextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yoneticibutton = new System.Windows.Forms.Button();
            this.geributton = new System.Windows.Forms.Button();
            this.sifremiunuttumlabel = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bankaotomasyonuDataSet = new BankaOtomasyonu.bankaotomasyonuDataSet();
            this.hatabilgilabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaotomasyonuDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(121, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "ŞİFRE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(51, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "T.C KİMLİK NO:";
            // 
            // sifretextBox
            // 
            this.sifretextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifretextBox.Location = new System.Drawing.Point(209, 198);
            this.sifretextBox.Name = "sifretextBox";
            this.sifretextBox.Size = new System.Drawing.Size(200, 27);
            this.sifretextBox.TabIndex = 12;
            this.sifretextBox.UseSystemPasswordChar = true;
            // 
            // tctextBox
            // 
            this.tctextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tctextBox.Location = new System.Drawing.Point(209, 148);
            this.tctextBox.Name = "tctextBox";
            this.tctextBox.Size = new System.Drawing.Size(200, 27);
            this.tctextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 29);
            this.label1.TabIndex = 10;
            this.label1.Text = "YÖNETİCİ GİRİŞİ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // yoneticibutton
            // 
            this.yoneticibutton.BackColor = System.Drawing.Color.PowderBlue;
            this.yoneticibutton.Location = new System.Drawing.Point(224, 240);
            this.yoneticibutton.Name = "yoneticibutton";
            this.yoneticibutton.Size = new System.Drawing.Size(168, 38);
            this.yoneticibutton.TabIndex = 9;
            this.yoneticibutton.Text = "GİRİŞ\r\n";
            this.yoneticibutton.UseVisualStyleBackColor = false;
            this.yoneticibutton.Click += new System.EventHandler(this.yoneticibutton_Click);
            // 
            // geributton
            // 
            this.geributton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.geributton.Location = new System.Drawing.Point(12, 401);
            this.geributton.Name = "geributton";
            this.geributton.Size = new System.Drawing.Size(97, 42);
            this.geributton.TabIndex = 15;
            this.geributton.Text = "<--- geri";
            this.geributton.UseVisualStyleBackColor = false;
            this.geributton.Click += new System.EventHandler(this.geributton_Click);
            // 
            // sifremiunuttumlabel
            // 
            this.sifremiunuttumlabel.AutoSize = true;
            this.sifremiunuttumlabel.BackColor = System.Drawing.Color.Turquoise;
            this.sifremiunuttumlabel.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sifremiunuttumlabel.ForeColor = System.Drawing.Color.Red;
            this.sifremiunuttumlabel.Location = new System.Drawing.Point(490, 377);
            this.sifremiunuttumlabel.Name = "sifremiunuttumlabel";
            this.sifremiunuttumlabel.Size = new System.Drawing.Size(144, 23);
            this.sifremiunuttumlabel.TabIndex = 18;
            this.sifremiunuttumlabel.Text = "şifremi unuttum";
            this.sifremiunuttumlabel.Click += new System.EventHandler(this.sifremiunuttumlabel_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.bankaotomasyonuDataSet;
            this.bindingSource1.Position = 0;
            // 
            // bankaotomasyonuDataSet
            // 
            this.bankaotomasyonuDataSet.DataSetName = "bankaotomasyonuDataSet";
            this.bankaotomasyonuDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hatabilgilabel
            // 
            this.hatabilgilabel.AutoSize = true;
            this.hatabilgilabel.BackColor = System.Drawing.Color.Turquoise;
            this.hatabilgilabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hatabilgilabel.ForeColor = System.Drawing.Color.Red;
            this.hatabilgilabel.Location = new System.Drawing.Point(370, 305);
            this.hatabilgilabel.Name = "hatabilgilabel";
            this.hatabilgilabel.Size = new System.Drawing.Size(172, 25);
            this.hatabilgilabel.TabIndex = 20;
            this.hatabilgilabel.Text = "Giriş bilgileri hatalı!";
            // 
            // yoneticigiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(686, 465);
            this.Controls.Add(this.hatabilgilabel);
            this.Controls.Add(this.sifremiunuttumlabel);
            this.Controls.Add(this.geributton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sifretextBox);
            this.Controls.Add(this.tctextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.yoneticibutton);
            this.Name = "yoneticigiris";
            this.Text = "yoneticigiris";
            this.Load += new System.EventHandler(this.yoneticigiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankaotomasyonuDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sifretextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button yoneticibutton;
        private System.Windows.Forms.Button geributton;
        private System.Windows.Forms.Label sifremiunuttumlabel;
        private System.Windows.Forms.BindingSource bindingSource1;
        private bankaotomasyonuDataSet bankaotomasyonuDataSet;
        private System.Windows.Forms.Label hatabilgilabel;
        public System.Windows.Forms.TextBox tctextBox;
    }
}