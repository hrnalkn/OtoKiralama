namespace RentCarSystem
{
    partial class GirisEkrani
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GirisEkrani));
            this.label1 = new System.Windows.Forms.Label();
            this.kullanıcıAdıTxt = new System.Windows.Forms.TextBox();
            this.sifreTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgrlamaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dogrulamaTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.girisbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(95, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı          :";
            // 
            // kullanıcıAdıTxt
            // 
            this.kullanıcıAdıTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcıAdıTxt.Location = new System.Drawing.Point(235, 69);
            this.kullanıcıAdıTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kullanıcıAdıTxt.Name = "kullanıcıAdıTxt";
            this.kullanıcıAdıTxt.Size = new System.Drawing.Size(121, 26);
            this.kullanıcıAdıTxt.TabIndex = 3;
            // 
            // sifreTxt
            // 
            this.sifreTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sifreTxt.Location = new System.Drawing.Point(236, 110);
            this.sifreTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sifreTxt.Name = "sifreTxt";
            this.sifreTxt.PasswordChar = '*';
            this.sifreTxt.Size = new System.Drawing.Size(120, 26);
            this.sifreTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(95, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Şifre                        :";
            // 
            // dgrlamaTxt
            // 
            this.dgrlamaTxt.Location = new System.Drawing.Point(236, 150);
            this.dgrlamaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgrlamaTxt.Name = "dgrlamaTxt";
            this.dgrlamaTxt.Size = new System.Drawing.Size(51, 22);
            this.dgrlamaTxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(95, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dogrulama Kodu :";
            // 
            // dogrulamaTxt
            // 
            this.dogrulamaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dogrulamaTxt.Location = new System.Drawing.Point(293, 150);
            this.dogrulamaTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dogrulamaTxt.Name = "dogrulamaTxt";
            this.dogrulamaTxt.Size = new System.Drawing.Size(63, 24);
            this.dogrulamaTxt.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = global::RentCarSystem.Properties.Resources.icons8_x_24;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(134, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 47);
            this.button1.TabIndex = 9;
            this.button1.Text = "İptal";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(189, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Giriş Yap";
            // 
            // girisbtn
            // 
            this.girisbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.girisbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisbtn.Image = global::RentCarSystem.Properties.Resources.icons8_login_rounded_24;
            this.girisbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.girisbtn.Location = new System.Drawing.Point(248, 197);
            this.girisbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.girisbtn.Name = "girisbtn";
            this.girisbtn.Size = new System.Drawing.Size(108, 47);
            this.girisbtn.TabIndex = 2;
            this.girisbtn.Text = "Giriş";
            this.girisbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.girisbtn.UseVisualStyleBackColor = true;
            this.girisbtn.Click += new System.EventHandler(this.girisbtn_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(476, 272);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dogrulamaTxt);
            this.Controls.Add(this.dgrlamaTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sifreTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kullanıcıAdıTxt);
            this.Controls.Add(this.girisbtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "GirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris Ekrani";
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kullanıcıAdıTxt;
        private System.Windows.Forms.TextBox sifreTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dgrlamaTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dogrulamaTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button girisbtn;
    }
}