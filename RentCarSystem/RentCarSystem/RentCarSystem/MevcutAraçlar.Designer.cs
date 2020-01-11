namespace RentCarSystem
{
    partial class MevcutAraçlar
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
            this.silbtn = new System.Windows.Forms.Button();
            this.duzenlebtn = new System.Windows.Forms.Button();
            this.aracListdataGrid = new System.Windows.Forms.DataGridView();
            this.ucretTxt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.yakitCombo = new System.Windows.Forms.ComboBox();
            this.vitesCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kmTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.modelTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.seriTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.markaTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.plakaTxt = new System.Windows.Forms.TextBox();
            this.Plaka = new System.Windows.Forms.Label();
            this.araciEklebtn = new System.Windows.Forms.Button();
            this.ModelAraTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PlakaAraTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aracListdataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // silbtn
            // 
            this.silbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.silbtn.Location = new System.Drawing.Point(611, 280);
            this.silbtn.Margin = new System.Windows.Forms.Padding(2);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(66, 46);
            this.silbtn.TabIndex = 54;
            this.silbtn.Text = "Sil";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // duzenlebtn
            // 
            this.duzenlebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.duzenlebtn.Location = new System.Drawing.Point(682, 280);
            this.duzenlebtn.Margin = new System.Windows.Forms.Padding(2);
            this.duzenlebtn.Name = "duzenlebtn";
            this.duzenlebtn.Size = new System.Drawing.Size(66, 48);
            this.duzenlebtn.TabIndex = 53;
            this.duzenlebtn.Text = "Düzenle";
            this.duzenlebtn.UseVisualStyleBackColor = true;
            this.duzenlebtn.Click += new System.EventHandler(this.duzenlebtn_Click);
            // 
            // aracListdataGrid
            // 
            this.aracListdataGrid.AllowUserToAddRows = false;
            this.aracListdataGrid.AllowUserToDeleteRows = false;
            this.aracListdataGrid.BackgroundColor = System.Drawing.Color.White;
            this.aracListdataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aracListdataGrid.Location = new System.Drawing.Point(237, 19);
            this.aracListdataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.aracListdataGrid.Name = "aracListdataGrid";
            this.aracListdataGrid.ReadOnly = true;
            this.aracListdataGrid.RowHeadersWidth = 51;
            this.aracListdataGrid.RowTemplate.Height = 24;
            this.aracListdataGrid.Size = new System.Drawing.Size(511, 218);
            this.aracListdataGrid.TabIndex = 52;
            // 
            // ucretTxt
            // 
            this.ucretTxt.Location = new System.Drawing.Point(86, 249);
            this.ucretTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ucretTxt.Name = "ucretTxt";
            this.ucretTxt.Size = new System.Drawing.Size(76, 20);
            this.ucretTxt.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 249);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Kira Ücreti";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(166, 308);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 45);
            this.button2.TabIndex = 70;
            this.button2.Text = "İptal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // yakitCombo
            // 
            this.yakitCombo.FormattingEnabled = true;
            this.yakitCombo.Items.AddRange(new object[] {
            "Benzin",
            "Dizel",
            "LPG"});
            this.yakitCombo.Location = new System.Drawing.Point(86, 216);
            this.yakitCombo.Margin = new System.Windows.Forms.Padding(2);
            this.yakitCombo.Name = "yakitCombo";
            this.yakitCombo.Size = new System.Drawing.Size(92, 21);
            this.yakitCombo.TabIndex = 68;
            // 
            // vitesCombo
            // 
            this.vitesCombo.FormattingEnabled = true;
            this.vitesCombo.Items.AddRange(new object[] {
            "Manuel",
            "Otomatik"});
            this.vitesCombo.Location = new System.Drawing.Point(86, 180);
            this.vitesCombo.Margin = new System.Windows.Forms.Padding(2);
            this.vitesCombo.Name = "vitesCombo";
            this.vitesCombo.Size = new System.Drawing.Size(92, 21);
            this.vitesCombo.TabIndex = 67;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 216);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Yakıt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 180);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 65;
            this.label5.Text = "Vites";
            // 
            // kmTxt
            // 
            this.kmTxt.Location = new System.Drawing.Point(86, 146);
            this.kmTxt.Margin = new System.Windows.Forms.Padding(2);
            this.kmTxt.Name = "kmTxt";
            this.kmTxt.Size = new System.Drawing.Size(76, 20);
            this.kmTxt.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 63;
            this.label4.Text = "Km";
            // 
            // modelTxt
            // 
            this.modelTxt.Location = new System.Drawing.Point(86, 113);
            this.modelTxt.Margin = new System.Windows.Forms.Padding(2);
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.Size = new System.Drawing.Size(76, 20);
            this.modelTxt.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "Model(Yıl)";
            // 
            // seriTxt
            // 
            this.seriTxt.Location = new System.Drawing.Point(86, 81);
            this.seriTxt.Margin = new System.Windows.Forms.Padding(2);
            this.seriTxt.Name = "seriTxt";
            this.seriTxt.Size = new System.Drawing.Size(76, 20);
            this.seriTxt.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "Seri";
            // 
            // markaTxt
            // 
            this.markaTxt.Location = new System.Drawing.Point(86, 50);
            this.markaTxt.Margin = new System.Windows.Forms.Padding(2);
            this.markaTxt.Name = "markaTxt";
            this.markaTxt.Size = new System.Drawing.Size(76, 20);
            this.markaTxt.TabIndex = 58;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 57;
            this.label1.Text = "Marka";
            // 
            // plakaTxt
            // 
            this.plakaTxt.Location = new System.Drawing.Point(86, 18);
            this.plakaTxt.Margin = new System.Windows.Forms.Padding(2);
            this.plakaTxt.Name = "plakaTxt";
            this.plakaTxt.Size = new System.Drawing.Size(76, 20);
            this.plakaTxt.TabIndex = 56;
            // 
            // Plaka
            // 
            this.Plaka.AutoSize = true;
            this.Plaka.Location = new System.Drawing.Point(28, 18);
            this.Plaka.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Plaka.Name = "Plaka";
            this.Plaka.Size = new System.Drawing.Size(34, 13);
            this.Plaka.TabIndex = 55;
            this.Plaka.Text = "Plaka";
            // 
            // araciEklebtn
            // 
            this.araciEklebtn.BackgroundImage = global::RentCarSystem.Properties.Resources.icons8_car_service_48;
            this.araciEklebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.araciEklebtn.Location = new System.Drawing.Point(86, 280);
            this.araciEklebtn.Margin = new System.Windows.Forms.Padding(2);
            this.araciEklebtn.Name = "araciEklebtn";
            this.araciEklebtn.Size = new System.Drawing.Size(75, 73);
            this.araciEklebtn.TabIndex = 69;
            this.araciEklebtn.Text = "Aracı Ekle";
            this.araciEklebtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.araciEklebtn.UseVisualStyleBackColor = true;
            this.araciEklebtn.Click += new System.EventHandler(this.araciEklebtn_Click);
            // 
            // ModelAraTxt
            // 
            this.ModelAraTxt.Location = new System.Drawing.Point(377, 293);
            this.ModelAraTxt.Margin = new System.Windows.Forms.Padding(2);
            this.ModelAraTxt.Name = "ModelAraTxt";
            this.ModelAraTxt.Size = new System.Drawing.Size(106, 20);
            this.ModelAraTxt.TabIndex = 76;
            this.ModelAraTxt.TextChanged += new System.EventHandler(this.ModelAraTxt_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(297, 297);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 75;
            this.label8.Text = "MARKA ARA";
            // 
            // PlakaAraTxt
            // 
            this.PlakaAraTxt.Location = new System.Drawing.Point(377, 265);
            this.PlakaAraTxt.Margin = new System.Windows.Forms.Padding(2);
            this.PlakaAraTxt.Name = "PlakaAraTxt";
            this.PlakaAraTxt.Size = new System.Drawing.Size(106, 20);
            this.PlakaAraTxt.TabIndex = 74;
            this.PlakaAraTxt.TextChanged += new System.EventHandler(this.PlakaAraTxt_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(297, 268);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 13);
            this.label11.TabIndex = 73;
            this.label11.Text = "PLAKA ARA";
            // 
            // MevcutAraçlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(791, 375);
            this.Controls.Add(this.ModelAraTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PlakaAraTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ucretTxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.araciEklebtn);
            this.Controls.Add(this.yakitCombo);
            this.Controls.Add(this.vitesCombo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kmTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.modelTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.seriTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.markaTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plakaTxt);
            this.Controls.Add(this.Plaka);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.duzenlebtn);
            this.Controls.Add(this.aracListdataGrid);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MevcutAraçlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mevcut Araç Listesi";
            this.Load += new System.EventHandler(this.MevcutAraçlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aracListdataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.Button duzenlebtn;
        private System.Windows.Forms.DataGridView aracListdataGrid;
        private System.Windows.Forms.TextBox ucretTxt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button araciEklebtn;
        private System.Windows.Forms.ComboBox yakitCombo;
        private System.Windows.Forms.ComboBox vitesCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kmTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox modelTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox seriTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox markaTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plakaTxt;
        private System.Windows.Forms.Label Plaka;
        private System.Windows.Forms.TextBox ModelAraTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PlakaAraTxt;
        private System.Windows.Forms.Label label11;
    }
}