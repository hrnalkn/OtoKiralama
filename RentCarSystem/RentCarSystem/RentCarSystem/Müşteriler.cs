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
    public partial class Müşteriler : Form
    {
        int MusteriID;
        public Müşteriler()
        {
            InitializeComponent();
            ekleBtn.MouseEnter += OnmauseEnterEklebtn;
            ekleBtn.MouseLeave += OnmauseLeaveEklebtn;
            button2.MouseEnter += OnmauseEnterButton2;
            button2.MouseLeave += OnmauseLeaveButton2;
            silbtn.MouseEnter += OnmauseEnterSilbtn;
            silbtn.MouseLeave += OnmauseLeaveSilbtn;
            duzenlebtn.MouseEnter += OnmauseEnterDuzenlebtn;
            duzenlebtn.MouseLeave += OnmauseLeaveDuzenlebtn;

        }
        private void OnmauseEnterEklebtn(object sender, EventArgs e)
        {
            ekleBtn.BackColor = Color.Green;
        }
        private void OnmauseLeaveEklebtn(object sender, EventArgs e)
        {
            ekleBtn.BackColor = Color.White;
        }
        private void OnmauseEnterButton2(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
        }
        private void OnmauseLeaveButton2(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }

        private void OnmauseEnterSilbtn(object sender, EventArgs e)
        {
            silbtn.BackColor = Color.Red;
        }
        private void OnmauseLeaveSilbtn(object sender, EventArgs e)
        {
            silbtn.BackColor = Color.White;
        }
        private void OnmauseEnterDuzenlebtn(object sender, EventArgs e)
        {
            duzenlebtn.BackColor = Color.Green;
        }
        private void OnmauseLeaveDuzenlebtn(object sender, EventArgs e)
        {
            duzenlebtn.BackColor = Color.White;
        }

        private void Müşteriler_Load(object sender, EventArgs e)
        {
            using (AracKiralamaEntities db = new AracKiralamaEntities())
            {
                musteriListdataGrid.DataSource = HelperMusteriler.GetMusteriler();
                musteriListdataGrid.Columns["MusteriID"].Visible = false;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            List<MusterilerModel> musteriList = HelperMusteriler.GetMusteriler();
            musteriListdataGrid.DataSource = musteriList.Where(q => q.TcNO.Contains(tcNoTxt.Text) == true).ToList();
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bu işlem geri alınamaz. Silmek istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                MusterilerModel ml = new MusterilerModel();

                ml.MusteriID = Convert.ToInt32(musteriListdataGrid.CurrentRow.Cells[0].Value);
                ml.TcNO = musteriListdataGrid.CurrentRow.Cells[1].Value.ToString();
                ml.Ad = musteriListdataGrid.CurrentRow.Cells[2].Value.ToString();
                ml.Soyad = musteriListdataGrid.CurrentRow.Cells[3].Value.ToString();
                ml.Telefon = musteriListdataGrid.CurrentRow.Cells[4].Value.ToString();
                ml.Adres = musteriListdataGrid.CurrentRow.Cells[5].Value.ToString();
                ml.Email = musteriListdataGrid.CurrentRow.Cells[6].Value.ToString();
                ml.Cinsiyet = musteriListdataGrid.CurrentRow.Cells[7].Value.ToString();
                ml.EhliyetNo = Convert.ToInt32(musteriListdataGrid.CurrentRow.Cells[8].Value);


                Musteriler m = new Musteriler();
                m.MusteriID = ml.MusteriID;
                m.TcNO = ml.TcNO;
                m.Ad = ml.Ad;
                m.Soyad = ml.Soyad;
                m.Telefon = ml.Telefon;
                m.Adres = ml.Adres;
                m.Email = ml.Email;
                m.Cinsiyet = ml.Cinsiyet;
                m.EhliyetNo = ml.EhliyetNo;

                var status = HelperMusteriler.MusteriCud(m, EntityState.Deleted);
                MessageBox.Show("Silme işlemi gerçekleşti.");
                musteriListdataGrid.DataSource = HelperMusteriler.GetMusteriler();
                musteriListdataGrid.Columns["MusteriID"].Visible = false;
            }
            else
            {
                return;
            }


        }

        private void duzenlebtn_Click(object sender, EventArgs e)
        {
            tcTxt.Text = musteriListdataGrid.CurrentRow.Cells[1].Value.ToString();
            adTxt.Text = musteriListdataGrid.CurrentRow.Cells[2].Value.ToString();
            soyadTxt.Text = musteriListdataGrid.CurrentRow.Cells[3].Value.ToString();
            telefonTxt.Text = musteriListdataGrid.CurrentRow.Cells[4].Value.ToString();
            adresTxt.Text = musteriListdataGrid.CurrentRow.Cells[5].Value.ToString();
            mailTxt.Text = musteriListdataGrid.CurrentRow.Cells[6].Value.ToString();
            MusteriID = Convert.ToInt32(musteriListdataGrid.CurrentRow.Cells[0].Value);
            ehliyetNoTxt.Text = musteriListdataGrid.CurrentRow.Cells[8].Value.ToString();

        }

        private void ekleBtn_Click(object sender, EventArgs e)
        {
            try
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
                                                MusteriID = MusteriID,
                                                TcNO = tcTxt.Text,
                                                Ad = adTxt.Text,
                                                Soyad = soyadTxt.Text,
                                                Telefon = telefonTxt.Text,
                                                Adres = adresTxt.Text,
                                                Email = mailTxt.Text,
                                                Cinsiyet = cinsiyetCombo.SelectedItem.ToString(),
                                                EhliyetNo = Convert.ToInt32(ehliyetNoTxt.Text)
                                            };
                                            var status = HelperMusteriler.MusteriCud(musteri, EntityState.Modified);
                                            MessageBox.Show("Müşteri başarılı bir şekişlde düzenlendi!", "İşlem Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                            tcTxt.Clear();
                                            adTxt.Clear();
                                            soyadTxt.Clear();
                                            telefonTxt.Clear();
                                            adresTxt.Clear();
                                            mailTxt.Clear();
                                            cinsiyetCombo.ResetText();
                                            musteriListdataGrid.DataSource = HelperMusteriler.GetMusteriler();
                                            musteriListdataGrid.Columns["MusteriID"].Visible = false;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Ehliyet No yu kontol edin ve tekrar deneyin. \nEhliyet No 6 haneli ve sadece olmalı ve sadece Rakam içermelidir. !", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Lütfen Cinsiyet Seçimi yapın !", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            catch (Exception)
            {
                MessageBox.Show("Geçersiz giriş. \nLütfen bilgileri kontrol edin !", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void musteriListdataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<MusterilerModel> musteriList = HelperMusteriler.GetMusteriler();
            musteriListdataGrid.DataSource = musteriList.Where(q => q.Ad.ToLower().Contains(textBox1.Text) == true).ToList();
        }
    }
}
