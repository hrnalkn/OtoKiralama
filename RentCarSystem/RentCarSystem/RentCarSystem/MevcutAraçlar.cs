using RentCarSystem.DAL;
using RentCarSystem.ENTITY;
using RentCarSystem.MODELLER;
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
    public partial class MevcutAraçlar : Form
    {
        int aracID;
        public MevcutAraçlar()
        {
            InitializeComponent();
            aracListdataGrid.DataSource = HelperAraclar.GetAraclar();
            this.aracListdataGrid.Columns["AracID"].Visible = false;
            araciEklebtn.MouseEnter += OnmauseEnterAraciEklebtn;
            araciEklebtn.MouseLeave += OnmauseLeaveAraciEklebtn;
            button2.MouseEnter += OnmauseEnterbutton2;
            button2.MouseLeave += OnmauseLeavebutton2;
            silbtn.MouseEnter += OnmauseEntersilbtn;
            silbtn.MouseLeave += OnmauseLeavesilbtn;
            duzenlebtn.MouseEnter += OnmauseEnterduzenlebtn;
            duzenlebtn.MouseLeave += OnmauseLeaveduzenlebtn;
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

        private void OnmauseEntersilbtn(object sender, EventArgs e)
        {
            silbtn.BackColor = Color.Red;
        }
        private void OnmauseLeavesilbtn(object sender, EventArgs e)
        {
            silbtn.BackColor = Color.White;
        }
        private void OnmauseEnterduzenlebtn(object sender, EventArgs e)
        {
            duzenlebtn.BackColor = Color.Green;
        }
        private void OnmauseLeaveduzenlebtn(object sender, EventArgs e)
        {
            duzenlebtn.BackColor = Color.White;
        }


        private void silbtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Bu işlem geri alınamaz. Silmek istediğinize emin misiniz?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                AraclarModel al = new AraclarModel();

                al.AracID = Convert.ToInt32(aracListdataGrid.CurrentRow.Cells[0].Value);
                al.Plaka = aracListdataGrid.CurrentRow.Cells[1].Value.ToString();
                al.Marka = aracListdataGrid.CurrentRow.Cells[2].Value.ToString();
                al.Seri = aracListdataGrid.CurrentRow.Cells[3].Value.ToString();
                al.Model_Yıl = aracListdataGrid.CurrentRow.Cells[4].Value.ToString();
                al.Km = Convert.ToInt32(aracListdataGrid.CurrentRow.Cells[5].Value.ToString());
                al.Vites = aracListdataGrid.CurrentRow.Cells[6].Value.ToString();
                al.Yakıt = aracListdataGrid.CurrentRow.Cells[7].Value.ToString();


                AraclarListesi a = new AraclarListesi();
                a.AracID = al.AracID;
                a.Plaka = al.Plaka;
                a.Marka = al.Marka;
                a.Seri = al.Seri;
                a.Model_Yıl = al.Model_Yıl;
                a.Km = al.Km;
                a.Vites = al.Vites;
                a.Yakıt = al.Yakıt;

                var status = HelperAraclar.AracCud(a, EntityState.Deleted);
                MessageBox.Show("Silme işlemi gerçekleşti.");
                aracListdataGrid.DataSource = HelperMusteriler.GetMusteriler();
                this.aracListdataGrid.Columns["AracID"].Visible = false;

            }
            else
            {
                return;
            }

        }

        private void MevcutAraçlar_Load(object sender, EventArgs e)
        {

        }

        private void duzenlebtn_Click(object sender, EventArgs e)
        {
            aracID = Convert.ToInt32(aracListdataGrid.CurrentRow.Cells[0].Value);
            plakaTxt.Text = aracListdataGrid.CurrentRow.Cells[1].Value.ToString();
            markaTxt.Text = aracListdataGrid.CurrentRow.Cells[2].Value.ToString();
            seriTxt.Text = aracListdataGrid.CurrentRow.Cells[3].Value.ToString();
            modelTxt.Text = aracListdataGrid.CurrentRow.Cells[4].Value.ToString();
            kmTxt.Text = aracListdataGrid.CurrentRow.Cells[5].Value.ToString();
            ucretTxt.Text = aracListdataGrid.CurrentRow.Cells[8].Value.ToString();

        }

        private void araciEklebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(plakaTxt.Text) == false && plakaTxt.Text.Count() >= 8 && string.IsNullOrWhiteSpace(plakaTxt.Text) == false)
                {
                    if (string.IsNullOrEmpty(markaTxt.Text) == false && int.TryParse(markaTxt.Text, out int a) == false && string.IsNullOrWhiteSpace(markaTxt.Text) == false)
                    {
                        if (string.IsNullOrEmpty(seriTxt.Text) == false && int.TryParse(seriTxt.Text, out int b) == false && string.IsNullOrWhiteSpace(seriTxt.Text) == false)
                        {

                            if (string.IsNullOrEmpty(modelTxt.Text) == false && int.TryParse(modelTxt.Text, out int f) && f < 2020 && f > 1920 && string.IsNullOrWhiteSpace(modelTxt.Text) == false)
                            {

                                if (string.IsNullOrEmpty(kmTxt.Text) == false && int.TryParse(kmTxt.Text, out int c) && string.IsNullOrWhiteSpace(kmTxt.Text) == false)
                                {

                                    if (vitesCombo.SelectedItem.ToString() != "--Vites Tipi--")
                                    {
                                        if (yakitCombo.SelectedItem.ToString() != "--Yakıt Tipi--")
                                        {
                                            if (string.IsNullOrEmpty(ucretTxt.Text) == false && int.TryParse(ucretTxt.Text, out int d) && string.IsNullOrWhiteSpace(ucretTxt.Text) == false)
                                            {
                                                var arac = new AraclarListesi
                                                {
                                                    AracID = aracID,
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
                                                var status = HelperAraclar.AracCud(arac, EntityState.Modified);
                                                MessageBox.Show("Araç başarılı bir şekişlde düzenlendi!", "Araç Kaydı Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                aracListdataGrid.DataSource = HelperAraclar.GetAraclar();
                                                this.aracListdataGrid.Columns["AracID"].Visible = false;
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

        private void PlakaAraTxt_TextChanged(object sender, EventArgs e)
        {
            List<AraclarModel> aracList = HelperAraclar.GetAraclar();
            aracListdataGrid.DataSource = aracList.Where(q => q.Plaka.Contains(PlakaAraTxt.Text) == true).ToList();
        }

        private void ModelAraTxt_TextChanged(object sender, EventArgs e)
        {
            List<AraclarModel> aracList = HelperAraclar.GetAraclar();
            aracListdataGrid.DataSource = aracList.Where(q => q.Marka.ToLower().Contains(ModelAraTxt.Text) == true).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
