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
    public partial class Müsteri_Ekle : Form
    {
        public Müsteri_Ekle()
        {
            InitializeComponent();
            ekleBtn.MouseEnter += OnmauseEnterEkleBtn;
            ekleBtn.MouseLeave += OnmauseLeaveEkleBtn;
            button2.MouseEnter += OnmauseEnterButton2;
            button2.MouseLeave += OnmauseLeaveButton2;
        }
        private void OnmauseEnterButton2(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }
        private void OnmauseLeaveButton2(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }
        private void OnmauseEnterEkleBtn(object sender, EventArgs e)
        {
            ekleBtn.BackColor = Color.Green;
        }
        private void OnmauseLeaveEkleBtn(object sender, EventArgs e)
        {
            ekleBtn.BackColor = Color.White;
        }


        private void Müsteri_Ekle_Load(object sender, EventArgs e)
        {
            cinsiyetCombo.Text = "--Cinsiyet--";
        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ekleBtn_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (HelperMusteriler.MusteriKontrol(tcTxt.Text))
                {
                    if (string.IsNullOrEmpty(tcTxt.Text) == false && string.IsNullOrWhiteSpace(tcTxt.Text) == false && Int64.TryParse(tcTxt.Text, out long i) && tcTxt.Text.Count() == 11)
                    {

                        if (string.IsNullOrEmpty(adTxt.Text) == false && string.IsNullOrWhiteSpace(adTxt.Text) == false && string.IsNullOrWhiteSpace(soyadTxt.Text) == false && string.IsNullOrEmpty(soyadTxt.Text) == false && int.TryParse(adTxt.Text, out int na) == false && int.TryParse(soyadTxt.Text, out int c) == false)
                        {
                            var x = telefonTxt.Text.Count();
                            if (x == 14)
                            {
                                if (string.IsNullOrEmpty(adresTxt.Text) == false && string.IsNullOrWhiteSpace(adresTxt.Text) == false && int.TryParse(adresTxt.Text, out int b) == false)
                                {
                                    if (string.IsNullOrEmpty(mailTxt.Text) == false && string.IsNullOrWhiteSpace(mailTxt.Text) == false && int.TryParse(mailTxt.Text, out int gf) == false)
                                    {
                                        if (cinsiyetCombo.SelectedItem.ToString() != "--Cinsiyet--")
                                        {
                                            if (string.IsNullOrEmpty(ehliyetNoTxt.Text) == false && string.IsNullOrWhiteSpace(ehliyetNoTxt.Text) == false && int.TryParse(ehliyetNoTxt.Text, out int gfc) && ehliyetNoTxt.Text.Count() == 6)
                                            {


                                                var musteri = new Musteriler
                                                {
                                                    TcNO = tcTxt.Text,
                                                    Ad = adTxt.Text,
                                                    Soyad = soyadTxt.Text,
                                                    Telefon = telefonTxt.Text,
                                                    Adres = adresTxt.Text,
                                                    Email = mailTxt.Text,
                                                    Cinsiyet = cinsiyetCombo.SelectedItem.ToString(),
                                                    EhliyetNo = Convert.ToInt32(ehliyetNoTxt.Text),
                                                };
                                                var status = HelperMusteriler.MusteriCud(musteri, EntityState.Added);
                                                MessageBox.Show("Müşteri başarılı bir şekişlde oluşturuldu!", "Kayıt Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                this.Close();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Ehliyet No yu kontol edin ve tekrar deneyin. \nEhliyet No 6 haneli ve sadece olmalı ve sadece Rakam içermelidir. !", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                            }
                                        }
                                        else
                                        {
                                            MessageBox.Show("Lütfen cinsiyet seçimi yapın.!", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Geçersiz Mail. \nLütfen bilgileri kontrol edin !", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Geçersiz Adres. \nLütfen bilgileri kontrol edin !", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                }
                            }
                            else
                            {
                                MessageBox.Show("Lütfen telefon numarasını dogru girdiğinizden emin olarak tekrar deneyin.", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                        else
                        {

                            MessageBox.Show("Ad ve Soyad kısımları boş bırakılamaz", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show(" TC kimlik No bilgilerini kontrol edin !  \n!", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Girilen TC kimlik No ile kayıt bulunmaktadır. \n!", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Cinsiyet çimi yapın. \nLütfen bilgileri kontrol edin !", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



        }
    }
}
