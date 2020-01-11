using RentCarSystem.DAL;
using RentCarSystem.ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarSystem
{
    public partial class AracKayıt : Form
    {
        public AracKayıt()
        {
            InitializeComponent();
            vitesCombo.Text = "--Vites Tipi--";
            yakitCombo.Text = "--Yakıt Tipi--";
            araciEklebtn.MouseEnter += OnmauseEnterAraciEklebtn;
            araciEklebtn.MouseLeave += OnmauseLeaveAraciEklebtn;
            button2.MouseEnter += OnmauseEnterbutton2;
            button2.MouseLeave += OnmauseLeavebutton2;
        }
        private void OnmauseEnterAraciEklebtn(object sender, EventArgs e)
        {
            araciEklebtn.BackColor = Color.Green;
        }
        private void OnmauseLeaveAraciEklebtn(object sender, EventArgs e)
        {
            araciEklebtn.BackColor = Color.White;
        }
        private void OnmauseEnterbutton2(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }
        private void OnmauseLeavebutton2(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void araciEklebtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(plakaTxt.Text) == false && plakaTxt.Text.Count() >= 8 && string.IsNullOrWhiteSpace(plakaTxt.Text) == false)
                {
                    if (string.IsNullOrEmpty(markaTxt.Text) == false && int.TryParse(markaTxt.Text, out int a) == false && string.IsNullOrWhiteSpace(markaTxt.Text)==false)
                    {
                        if (string.IsNullOrEmpty(seriTxt.Text) == false && int.TryParse(seriTxt.Text, out int b) == false && string.IsNullOrWhiteSpace(seriTxt.Text)==false)
                        {

                            if (string.IsNullOrEmpty(modelTxt.Text) == false && int.TryParse(modelTxt.Text, out int f) && f < 2020 && f > 1920 && string.IsNullOrWhiteSpace(modelTxt.Text)==false)
                            {

                                if (string.IsNullOrEmpty(kmTxt.Text) == false && int.TryParse(kmTxt.Text, out int c) && string.IsNullOrWhiteSpace(kmTxt.Text)==false)
                                {
                                   
                                    if (vitesCombo.SelectedItem.ToString() != "--Vites Tipi--")
                                    {
                                        if (yakitCombo.SelectedItem.ToString() != "--Yakıt Tipi--")
                                        {
                                            if (string.IsNullOrEmpty(ucretTxt.Text) == false && int.TryParse(ucretTxt.Text, out int d) && string.IsNullOrWhiteSpace(ucretTxt.Text)==false)
                                            {
                                                var arac = new AraclarListesi
                                                {

                                                    Plaka = plakaTxt.Text,
                                                    Marka = markaTxt.Text,
                                                    Seri = seriTxt.Text,
                                                    Model_Yıl = modelTxt.Text,
                                                    Km = Convert.ToInt32(kmTxt.Text),
                                                    Vites = vitesCombo.SelectedItem.ToString(),
                                                    Yakıt = yakitCombo.SelectedItem.ToString(),
                                                    KiraUcreti = Convert.ToInt32(ucretTxt.Text),
                                                    Durum = "Uygun"

                                                };
                                                var status = HelperAraclar.AracCud(arac, EntityState.Added);
                                                MessageBox.Show("Araç başarılı bir şekişlde eklendi!", "Araç Kaydı Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Araç kira ücreti boş bırakılamaz veya 0 olamaz. !!", "Hata ! !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Aracın Yakıt Tipini Seçin !!", "Hata ! !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Aracın Vites Tipini Seçin !!", "Hata ! !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Aracın Km bilgileri kontrol edin !!", "Format Hatası ! !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                            }
                            else
                            {
                                MessageBox.Show("Aracın Model(YIL) bilgileri kontrol edin. Araç Modeli(Yıl) boş olmamalı ve 1920 ile 2020 arasında olmaıdır. !!", "HATA ! !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                        else
                        {
                            MessageBox.Show("Aracın Serisine ait bilgileri kontrol edin !!", "HATA ! !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Araç Markası bilgisini kontrol edin !!", "HATA ! !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Plaka Bilgisini Kontrol edin !", "Geçersiz Plaka!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Yakıt veya Vites bilgilerini kontrol edin.. \nLütfen bilgileri kontrol edin !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void AracKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
