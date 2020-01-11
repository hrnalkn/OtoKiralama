namespace RentCarSystem
{
    partial class AracKayıt
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
            this.Plaka = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.araciEklebtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.plakaTxt = new System.Windows.Forms.TextBox();
            this.markaTxt = new System.Windows.Forms.TextBox();
            this.seriTxt = new System.Windows.Forms.TextBox();
            this.modelTxt = new System.Windows.Forms.TextBox();
            this.vitesCombo = new System.Windows.Forms.ComboBox();
            this.yakitCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.kmTxt = new System.Windows.Forms.TextBox();
            this.ucretTxt = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Plaka
            // 
            this.Plaka.AutoSize = true;
            this.Plaka.Location = new System.Drawing.Point(91, 64);
            this.Plaka.Name = "Plaka";
            this.Plaka.Size = new System.Drawing.Size(43, 17);
            this.Plaka.TabIndex = 0;
            this.Plaka.Text = "Plaka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Marka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seri";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Model(Yıl)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(91, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Vites";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Yakıt";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(275, 412);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 55);
            this.button2.TabIndex = 28;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::RentCarSystem.Properties.Resources.hiclipart_com;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(336, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 261);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // araciEklebtn
            // 
            this.araciEklebtn.BackgroundImage = global::RentCarSystem.Properties.Resources.icons8_car_rental_30;
            this.araciEklebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.araciEklebtn.Location = new System.Drawing.Point(168, 386);
            this.araciEklebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.araciEklebtn.Name = "araciEklebtn";
            this.araciEklebtn.Size = new System.Drawing.Size(100, 81);
            this.araciEklebtn.TabIndex = 15;
            this.araciEklebtn.Text = "Aracı Ekle";
            this.araciEklebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.araciEklebtn.UseVisualStyleBackColor = true;
            this.araciEklebtn.Click += new System.EventHandler(this.araciEklebtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 348);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "Kira Ücreti";
            // 
            // plakaTxt
            // 
            this.plakaTxt.Location = new System.Drawing.Point(181, 64);
            this.plakaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.plakaTxt.Name = "plakaTxt";
            this.plakaTxt.Size = new System.Drawing.Size(100, 22);
            this.plakaTxt.TabIndex = 31;
            // 
            // markaTxt
            // 
            this.markaTxt.Location = new System.Drawing.Point(181, 98);
            this.markaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.markaTxt.Name = "markaTxt";
            this.markaTxt.Size = new System.Drawing.Size(100, 22);
            this.markaTxt.TabIndex = 32;
            // 
            // seriTxt
            // 
            this.seriTxt.Location = new System.Drawing.Point(181, 137);
            this.seriTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seriTxt.Name = "seriTxt";
            this.seriTxt.Size = new System.Drawing.Size(100, 22);
            this.seriTxt.TabIndex = 33;
            // 
            // modelTxt
            // 
            this.modelTxt.Location = new System.Drawing.Point(181, 176);
            this.modelTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.Size = new System.Drawing.Size(100, 22);
            this.modelTxt.TabIndex = 34;
            // 
            // vitesCombo
            // 
            this.vitesCombo.FormattingEnabled = true;
            this.vitesCombo.Items.AddRange(new object[] {
            "Manuel",
            "Otomatik"});
            this.vitesCombo.Location = new System.Drawing.Point(181, 260);
            this.vitesCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.vitesCombo.Name = "vitesCombo";
            this.vitesCombo.Size = new System.Drawing.Size(121, 24);
            this.vitesCombo.TabIndex = 36;
            // 
            // yakitCombo
            // 
            this.yakitCombo.FormattingEnabled = true;
            this.yakitCombo.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "LPG",
            "Elektrikli Araç"});
            this.yakitCombo.Location = new System.Drawing.Point(181, 305);
            this.yakitCombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yakitCombo.Name = "yakitCombo";
            this.yakitCombo.Size = new System.Drawing.Size(121, 24);
            this.yakitCombo.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(241, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "TL";
            // 
            // kmTxt
            // 
            this.kmTxt.Location = new System.Drawing.Point(181, 217);
            this.kmTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kmTxt.Name = "kmTxt";
            this.kmTxt.Size = new System.Drawing.Size(100, 22);
            this.kmTxt.TabIndex = 35;
            // 
            // ucretTxt
            // 
            this.ucretTxt.Location = new System.Drawing.Point(181, 345);
            this.ucretTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucretTxt.Mask = "0000";
            this.ucretTxt.Name = "ucretTxt";
            this.ucretTxt.Size = new System.Drawing.Size(53, 22);
            this.ucretTxt.TabIndex = 38;
            // 
            // AracKayıt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(851, 510);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ucretTxt);
            this.Controls.Add(this.yakitCombo);
            this.Controls.Add(this.vitesCombo);
            this.Controls.Add(this.kmTxt);
            this.Controls.Add(this.modelTxt);
            this.Controls.Add(this.seriTxt);
            this.Controls.Add(this.markaTxt);
            this.Controls.Add(this.plakaTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.araciEklebtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Plaka);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "AracKayıt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AracKayıt";
            this.Load += new System.EventHandler(this.AracKayıt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Plaka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button araciEklebtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox plakaTxt;
        private System.Windows.Forms.TextBox markaTxt;
        private System.Windows.Forms.TextBox seriTxt;
        private System.Windows.Forms.TextBox modelTxt;
        private System.Windows.Forms.ComboBox vitesCombo;
        private System.Windows.Forms.ComboBox yakitCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox kmTxt;
        private System.Windows.Forms.MaskedTextBox ucretTxt;
    }
}