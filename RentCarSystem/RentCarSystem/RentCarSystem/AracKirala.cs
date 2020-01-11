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
    public partial class AracKirala : Form
    {
        int aracID;
        int musteriID;
        int teslimID = 0;
        int islemiptalId = 0;
        DateTime araccıkıs;
        DateTime aracteslim;
        string ehliyetno;
        int tUcret;


        public AracKirala()
        {
            InitializeComponent();
            tcTxt.Enabled = false;
            adTxt.Enabled = false;
            soyadTxt.Enabled = false;
            telefonTxt.Enabled = false;
            adresTxt.Enabled = false;
            markaTxt.Enabled = false;
            seriTxt.Enabled = false;
            modelTxt.Enabled = false;
            ucretTxt.Enabled = false;
            plakaTxt.Enabled = false;
            vitesTxt.Enabled = false;
            yakitTxt.Enabled = false;
            kmTxt.Enabled = false;
            ehliyetNoTxt.Enabled = false;
            textBox1.Enabled = false;
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker2.MinDate = DateTime.Now;


            sozlesmeguncellebtn.MouseEnter += OnmauseEnterMusteriSozlesmeguncellebtn;
            sozlesmeguncellebtn.MouseLeave += OnmauseLeaveMusteriSozlesmeguncellebtn;
            sozlesmeKaydetbtn.MouseEnter += OnmauseEnterMusteriSozlesmeKaydetbtn;
            sozlesmeKaydetbtn.MouseLeave += OnmauseLeaveMusteriSozlesmeKaydetbtn;
            hesaplabtn.MouseEnter += OnmauseEnterMusteriHesaplabtn;
            hesaplabtn.MouseLeave += OnmauseLeaveMusteriHesaplabtn;
            sozlesmeEklebtn.MouseEnter += OnmauseEntersozlesmeEklebtn;
            sozlesmeEklebtn.MouseLeave += OnmauseLeavesozlesmeEklebtn;

        }

        private void OnmauseEnterMusteriSozlesmeguncellebtn(object sender, EventArgs e)
        {
            sozlesmeguncellebtn.BackColor = Color.Green;
        }
        private void OnmauseLeaveMusteriSozlesmeguncellebtn(object sender, EventArgs e)
        {
            sozlesmeguncellebtn.BackColor = Color.White;
        }
        private void OnmauseEntersozlesmeEklebtn(object sender, EventArgs e)
        {
            sozlesmeEklebtn.BackColor = Color.Green;
        }
        private void OnmauseLeavesozlesmeEklebtn(object sender, EventArgs e)
        {
            sozlesmeEklebtn.BackColor = Color.White;
        }
        private void OnmauseEnterMusteriSozlesmeKaydetbtn(object sender, EventArgs e)
        {
            sozlesmeKaydetbtn.BackColor = Color.Green;
        }
        private void OnmauseLeaveMusteriSozlesmeKaydetbtn(object sender, EventArgs e)
        {
            sozlesmeKaydetbtn.BackColor = Color.White;
        }
        private void OnmauseEnterMusteriHesaplabtn(object sender, EventArgs e)
        {
            hesaplabtn.BackColor = Color.Green;
        }
        private void OnmauseLeaveMusteriHesaplabtn(object sender, EventArgs e)
        {
            hesaplabtn.BackColor = Color.White;
        }
        private void musterilerCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (AracKiralamaEntities db = new AracKiralamaEntities())
            {
                if (musterilerCombo.SelectedItem.ToString() != "")
                {
                    musterilerCombo.Text = "--Müşteri Seçimi Yapın--";
                    Musteriler musteri = db.Musteriler.FirstOrDefault(m => m.Ad == musterilerCombo.SelectedItem.ToString());
                    musteriID = musteri.MusteriID;
                    tcTxt.Text = musteri.TcNO;
                    adTxt.Text = musteri.Ad;
                    soyadTxt.Text = musteri.Soyad;
                    telefonTxt.Text = musteri.Telefon;
                    adresTxt.Text = musteri.Adres;
                    ehliyetNoTxt.Text = musteri.EhliyetNo.ToString();
                }
                if (musterilerCombo.SelectedItem.ToString() == "")
                {
                    tcTxt.Clear();
                    adTxt.Clear();
                    soyadTxt.Clear();
                    telefonTxt.Clear();
                    adresTxt.Clear();
                }
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (AracKiralamaEntities db = new AracKiralamaEntities())
            {
                if (araclarCombo.Items.Count <= 1)
                {
                    MessageBox.Show("Kiralanacak uygun araç bulunmamaktadır ! ");
                }
                if (araclarCombo.SelectedItem.ToString() != "")
                {

                    AraclarListesi araclar = db.AraclarListesi.FirstOrDefault(a => a.Seri == araclarCombo.SelectedItem.ToString());
                    aracID = araclar.AracID;
                    markaTxt.Text = araclar.Marka;
                    seriTxt.Text = araclar.Seri;
                    modelTxt.Text = araclar.Model_Yıl;
                    ucretTxt.Text = araclar.KiraUcreti.ToString();
                    kmTxt.Text = araclar.Km.ToString();
                    vitesTxt.Text = araclar.Vites;
                    yakitTxt.Text = araclar.Yakıt;
                    plakaTxt.Text = araclar.Plaka;
                }

                if (araclarCombo.SelectedItem.ToString() == "")
                {
                    markaTxt.Clear();
                    seriTxt.Clear();
                    modelTxt.Clear();
                    ucretTxt.Clear();

                }

                var teslim = db.AraclarListesi.Where(s => s.Seri == araclarCombo.SelectedItem.ToString()).ToList();
                int teslimID = 0;
                foreach (AraclarListesi item in teslim)
                {
                    teslimID = item.AracID;
                }
                List<AraclarListesi> aa = HelperAraclar.GetAracById(teslimID);
                AraclarListesi arac2 = new AraclarListesi();
                foreach (AraclarListesi item in aa)
                {
                    arac2 = item;
                }
                List<KiralamaIslemleri> islem = HelperIslem.GetIslemById(teslimID);
                KiralamaIslemleri arac = new KiralamaIslemleri();
                foreach (KiralamaIslemleri item in islem)
                {
                    arac = item;
                }
                if (arac2.Durum == "Rezerve")
                {

                    if (DateTime.Now < arac.AracCıkısTarihi)
                    {
                        MessageBox.Show($"Seçtiginiz araç Bir başka müsteri tarafından rezerve edilmiştir. Aracı en fazla:{arac.AracCıkısTarihi} ne kadar alabilirsiniz.", "Araç Rezerve edilmiş !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dateTimePicker1.MinDate = DateTime.Now;
                        dateTimePicker1.MaxDate = arac.AracCıkısTarihi;
                        dateTimePicker2.MinDate = dateTimePicker1.Value;
                        dateTimePicker2.MaxDate = arac.AracCıkısTarihi;

                    }



                }





            }
        }
        private void AracKirala_Load(object sender, EventArgs e)
        {
            aracKiraladataGrid.DataSource = HelperIslem.GetIslemler();
            musterilerCombo.DataSource = HelperMusteriler.GetMusterilerAdı();
            araclarCombo.DataSource = HelperAraclar.GetAracSeri();
            this.aracKiraladataGrid.Columns["aracID"].Visible = false;
            this.aracKiraladataGrid.Columns["musteriID"].Visible = false;
            this.aracKiraladataGrid.Columns["IslemID"].Visible = false;
            this.aracKiraladataGrid.Columns["Vites"].Visible = false;
            this.aracKiraladataGrid.Columns["Yakıt"].Visible = false;
            this.aracKiraladataGrid.Columns["Km"].Visible = false;
            this.aracKiraladataGrid.Columns["Adres"].Visible = false;
            this.aracKiraladataGrid.Columns["Vites"].Visible = false;
            this.aracKiraladataGrid.Columns["Model"].Visible = false;
            this.aracKiraladataGrid.Columns["KiraUcreti"].Visible = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            musterilerCombo.DataSource = HelperMusteriler.GetMusterilerAdı();

        }
        IslemModel a;
        private void sozlesmeKaydetbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (hesaplananUcret.Text != "0")
                {
                    if (string.IsNullOrEmpty(ehliyetNoTxt.Text) == false && Int64.TryParse(ehliyetNoTxt.Text, out long v))
                    {

                        var islem = new KiralamaIslemleri
                        {
                            AracID = aracID,
                            MusteriID = musteriID,
                            AracCıkısTarihi = dateTimePicker1.Value,
                            AracTeslimTarihi = dateTimePicker2.Value,
                            ToplamUcret = Convert.ToInt32(hesaplananUcret.Text),

                        };

                        var status = HelperIslem.IslemCud(islem, EntityState.Added);
                        MessageBox.Show("İşlem başarılı bir şekişlde oluşturuldu!", "Kayıt Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var arac = new AraclarListesi
                        {
                            AracID = aracID,
                            Plaka = plakaTxt.Text,
                            Marka = markaTxt.Text,
                            Seri = seriTxt.Text,
                            Model_Yıl = modelTxt.Text,
                            Km = Convert.ToInt32(kmTxt.Text),
                            Vites = vitesTxt.Text,
                            Yakıt = yakitTxt.Text,
                            KiraUcreti = Convert.ToInt32(ucretTxt.Text),
                            Durum = "Kiralandı"
                        };

                        var status2 = HelperAraclar.AracCud(arac, EntityState.Modified);

                        var toplam = new GenelToplam
                        {

                            GenelToplamUcret = Convert.ToInt32(hesaplananUcret.Text),

                        };

                        var status3 = HelperGenelToplam.ToplamcCud(toplam, EntityState.Added);

                        aracKiraladataGrid.DataSource = HelperIslem.GetIslemler();
                        this.aracKiraladataGrid.Columns["aracID"].Visible = false;
                        this.aracKiraladataGrid.Columns["musteriID"].Visible = false;
                        this.aracKiraladataGrid.Columns["IslemID"].Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("Geçersiz giriş. \nLütfen bilgileri kontrol edin !", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Kiralama işlemini kaydetmeden önce lütfen ücret hesaplamasını yapın ! ");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lütfen Ehliyet numaranızı kontrol edin ! . \nLütfen bilgileri kontrol edin !", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }



        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void hesaplabtn_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(ucretTxt.Text) == false)
            {
                DateTime bTarih = Convert.ToDateTime(dateTimePicker1.Text);
                DateTime kTarih = Convert.ToDateTime(dateTimePicker2.Text);
                TimeSpan Sonuc = kTarih - bTarih;
                int gun = (Convert.ToInt32(Sonuc.TotalDays));
                int ucret = Convert.ToInt32(ucretTxt.Text);
                int UcretHesaplanan = (gun * ucret);
                hesaplananUcret.Text = UcretHesaplanan.ToString();
                if (gun == 0)
                {
                    UcretHesaplanan = Convert.ToInt32(ucretTxt.Text);
                    hesaplananUcret.Text = UcretHesaplanan.ToString();

                }
            }
            else
            {
                MessageBox.Show("Lütfen önce kiralamak istediginiz aracı seçin !", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }





        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
            if (dateTimePicker1.Value > DateTime.Now)
            {
                sozlesmeKaydetbtn.Enabled = false;
                rezervebtn.Enabled = true;

            }
            else
            {
                rezervebtn.Enabled = false;

                sozlesmeKaydetbtn.Enabled = true;
            }
        }

        private void aracKiraladataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sozlesmeguncellebtn_Click(object sender, EventArgs e)
        {
            rezervebtn.Enabled = false;
            sozlesmeKaydetbtn.Enabled = false;
            hesaplananUcret.Text = "0";
            tcTxt.Text = aracKiraladataGrid.CurrentRow.Cells[3].Value.ToString();
            adTxt.Text = aracKiraladataGrid.CurrentRow.Cells[4].Value.ToString();
            soyadTxt.Text = aracKiraladataGrid.CurrentRow.Cells[5].Value.ToString();
            telefonTxt.Text = aracKiraladataGrid.CurrentRow.Cells[6].Value.ToString();
            adresTxt.Text = aracKiraladataGrid.CurrentRow.Cells[7].Value.ToString();
            ehliyetNoTxt.Text = aracKiraladataGrid.CurrentRow.Cells[9].Value.ToString();
            plakaTxt.Text = aracKiraladataGrid.CurrentRow.Cells[8].Value.ToString();
            markaTxt.Text = aracKiraladataGrid.CurrentRow.Cells[9].Value.ToString();
            seriTxt.Text = aracKiraladataGrid.CurrentRow.Cells[10].Value.ToString();
            modelTxt.Text = aracKiraladataGrid.CurrentRow.Cells[11].Value.ToString();
            kmTxt.Text = aracKiraladataGrid.CurrentRow.Cells[12].Value.ToString();
            vitesTxt.Text = aracKiraladataGrid.CurrentRow.Cells[14].Value.ToString();
            yakitTxt.Text = aracKiraladataGrid.CurrentRow.Cells[15].Value.ToString();
            ucretTxt.Text = aracKiraladataGrid.CurrentRow.Cells[16].Value.ToString();
            ehliyetNoTxt.Text = aracKiraladataGrid.CurrentRow.Cells[13].Value.ToString();

        }

        private void sozlesmeEklebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (hesaplananUcret.Text != "0")
                {
                    if (string.IsNullOrEmpty(ehliyetNoTxt.Text) == false && string.IsNullOrWhiteSpace(ehliyetNoTxt.Text) == false && int.TryParse(ehliyetNoTxt.Text, out int a))
                    {

                        var islem = new KiralamaIslemleri
                        {
                            IslemID = Convert.ToInt32(aracKiraladataGrid.CurrentRow.Cells[0].Value),
                            AracID = Convert.ToInt32(aracKiraladataGrid.CurrentRow.Cells[1].Value),
                            MusteriID = Convert.ToInt32(aracKiraladataGrid.CurrentRow.Cells[2].Value),
                            AracCıkısTarihi = dateTimePicker1.Value,
                            AracTeslimTarihi = dateTimePicker2.Value,
                            ToplamUcret = Convert.ToInt32(hesaplananUcret.Text),

                        };
                        var status = HelperIslem.IslemCud(islem, EntityState.Modified);
                        MessageBox.Show("Müşteri başarılı bir şekişlde düzenlendi!", "Kayıt Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        aracKiraladataGrid.DataSource = HelperIslem.GetIslemler();
                        this.aracKiraladataGrid.Columns["aracID"].Visible = false;
                        this.aracKiraladataGrid.Columns["musteriID"].Visible = false;
                        this.aracKiraladataGrid.Columns["IslemID"].Visible = false;
                        rezervebtn.Enabled = false;
                        dateTimePicker1.Value = DateTime.Now;
                        sozlesmeKaydetbtn.Enabled = true;
                        tcTxt.Clear();
                        adTxt.Clear();
                        soyadTxt.Clear();
                        telefonTxt.Clear();
                        adresTxt.Clear();
                        ehliyetNoTxt.Clear();
                        plakaTxt.Clear();
                        markaTxt.Clear();
                        seriTxt.Clear();
                        modelTxt.Clear();
                        kmTxt.Clear();
                        vitesTxt.Clear();
                        yakitTxt.Clear();
                        ucretTxt.Clear();
                        textBox1.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Ehliyet No yu kontrol edin. \nLütfen bilgileri kontrol edin !", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Kiralama işlemini kaydetmeden önce lütfen ücret hesaplamasını yapın ! ","HATA !",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ehliyet No yu kontrol edin. \nLütfen bilgileri kontrol edin !", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }

        }

        private void rezervebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (hesaplananUcret.Text != "0")
                {
                    if (string.IsNullOrEmpty(ehliyetNoTxt.Text) == false && Int64.TryParse(ehliyetNoTxt.Text, out long v))
                    {

                        var islem = new KiralamaIslemleri
                        {
                            AracID = aracID,
                            MusteriID = musteriID,
                            AracCıkısTarihi = dateTimePicker1.Value,
                            AracTeslimTarihi = dateTimePicker2.Value,
                            ToplamUcret = Convert.ToInt32(hesaplananUcret.Text),

                        };

                        var status = HelperIslem.IslemCud(islem, EntityState.Added);
                        MessageBox.Show("Müşteri başarılı bir şekişlde oluşturuldu!", "Kayıt Başarılı !", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        var arac = new AraclarListesi
                        {
                            AracID = aracID,
                            Plaka = plakaTxt.Text,
                            Marka = markaTxt.Text,
                            Seri = seriTxt.Text,
                            Model_Yıl = modelTxt.Text,
                            Km = Convert.ToInt32(kmTxt.Text),
                            Vites = vitesTxt.Text,
                            Yakıt = yakitTxt.Text,
                            KiraUcreti = Convert.ToInt32(ucretTxt.Text),
                            Durum = "Rezerve"
                        };

                        var status2 = HelperAraclar.AracCud(arac, EntityState.Modified);

                        var toplam = new GenelToplam
                        {

                            GenelToplamUcret = Convert.ToInt32(hesaplananUcret.Text),

                        };

                        var status3 = HelperGenelToplam.ToplamcCud(toplam, EntityState.Added);
                        aracKiraladataGrid.DataSource = HelperIslem.GetIslemler();
                        this.aracKiraladataGrid.Columns["aracID"].Visible = false;
                        this.aracKiraladataGrid.Columns["musteriID"].Visible = false;
                        this.aracKiraladataGrid.Columns["IslemID"].Visible = false;

                    }
                    else
                    {
                        MessageBox.Show("Geçersiz giriş. \nLütfen bilgileri kontrol edin !", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
                else
                {
                    MessageBox.Show("Rezervasyon işlemini kaydetmeden önce lütfen ücret hesaplamasını yapın ! ","HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Geçersiz giriş. \nLütfen bilgileri kontrol edin !", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) == false)
            {
                using (var db = new AracKiralamaEntities())
                {
                    var teslim = db.AraclarListesi.Where(s => s.Seri == textBox1.Text).ToList();

                    foreach (AraclarListesi item in teslim)
                    {
                        teslimID = item.AracID;


                    }

                    List<KiralamaIslemleri> islem = HelperIslem.GetIslemById(teslimID);
                    KiralamaIslemleri arac = new KiralamaIslemleri();
                    foreach (KiralamaIslemleri item in islem)
                    {
                        arac = item;
                        islemiptalId = item.IslemID;
                        araccıkıs = item.AracCıkısTarihi;
                        aracteslim = item.AracTeslimTarihi;
                        tUcret = item.ToplamUcret;

                    }
                    if (islem.Count() > 1)
                    {
                        var arac2 = new AraclarListesi
                        {
                            AracID = teslimID,
                            Plaka = plakaTxt.Text,
                            Marka = markaTxt.Text,
                            Seri = seriTxt.Text,
                            Model_Yıl = modelTxt.Text,
                            Km = Convert.ToInt32(kmTxt.Text),
                            Vites = vitesTxt.Text,
                            Yakıt = yakitTxt.Text,
                            KiraUcreti = Convert.ToInt32(ucretTxt.Text),
                            Durum = "Kiralandı"
                        };

                        var arac3 = new KiralamaIslemleri
                        {
                            AracID = teslimID,
                            IslemID = islemiptalId,
                            AracCıkısTarihi = araccıkıs,
                            ToplamUcret = tUcret,
                        };

                        var status2 = HelperAraclar.AracCud(arac2, EntityState.Modified);
                        var status3 = HelperIslem.IslemCud(arac, EntityState.Deleted);
                        aracKiraladataGrid.DataSource = HelperIslem.GetIslemler();
                        this.aracKiraladataGrid.Columns["aracID"].Visible = false;
                        this.aracKiraladataGrid.Columns["musteriID"].Visible = false;
                        this.aracKiraladataGrid.Columns["IslemID"].Visible = false;
                    }
                    else if (islem.Count() == 1)
                    {
                        var arac2 = new AraclarListesi
                        {
                            AracID = teslimID,
                            Plaka = plakaTxt.Text,
                            Marka = markaTxt.Text,
                            Seri = seriTxt.Text,
                            Model_Yıl = modelTxt.Text,
                            Km = Convert.ToInt32(kmTxt.Text),
                            Vites = vitesTxt.Text,
                            Yakıt = yakitTxt.Text,
                            KiraUcreti = Convert.ToInt32(ucretTxt.Text),
                            Durum = "Uygun"
                        };
                        var status2 = HelperAraclar.AracCud(arac2, EntityState.Modified);
                        var status3 = HelperIslem.IslemCud(arac, EntityState.Deleted);
                        aracKiraladataGrid.DataSource = HelperIslem.GetIslemler();
                        this.aracKiraladataGrid.Columns["aracID"].Visible = false;
                        this.aracKiraladataGrid.Columns["musteriID"].Visible = false;
                        this.aracKiraladataGrid.Columns["IslemID"].Visible = false;
                    }

                    MessageBox.Show("Araç başarılı bir şekilde teslim edildi !","İşlem Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);


                }
            }
            else
            {
                MessageBox.Show("Lütfen ilk önce Teslim edilecek aracı listeden seçin ve daha sonra onayla butonuna basın.", "HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void aracTeslimCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (AracKiralamaEntities db = new AracKiralamaEntities())
            {

                string aranan = textBox1.Text;
                for (int i = 0; i <= aracKiraladataGrid.Rows.Count - 1; i++)
                {
                    foreach (DataGridViewRow row in aracKiraladataGrid.Rows)
                    {
                        foreach (DataGridViewCell cell in aracKiraladataGrid.Rows[i].Cells)
                        {
                            if (cell.Value != null)
                            {
                                if (cell.Value.ToString().ToUpper() == aranan)
                                {
                                    aracID = Convert.ToInt32(aracKiraladataGrid.CurrentRow.Cells[1].Value);
                                    musteriID = Convert.ToInt32(aracKiraladataGrid.CurrentRow.Cells[2].Value);
                                    tcTxt.Text = aracKiraladataGrid.CurrentRow.Cells[3].Value.ToString();
                                    adTxt.Text = aracKiraladataGrid.CurrentRow.Cells[4].Value.ToString();
                                    soyadTxt.Text = aracKiraladataGrid.CurrentRow.Cells[5].Value.ToString();
                                    telefonTxt.Text = aracKiraladataGrid.CurrentRow.Cells[6].Value.ToString();
                                    adresTxt.Text = aracKiraladataGrid.CurrentRow.Cells[7].Value.ToString();
                                    ehliyetNoTxt.Text = aracKiraladataGrid.CurrentRow.Cells[8].Value.ToString();

                                    break;
                                }
                            }
                        }
                    }
                }

                if (araclarCombo.Items.Count <= 1)
                {
                    MessageBox.Show("Teslim edilecek uygun araç bulunmamaktadır ! ");
                }

                AraclarListesi araclar = db.AraclarListesi.FirstOrDefault(a => a.Seri == textBox1.Text);
                aracID = araclar.AracID;
                markaTxt.Text = araclar.Marka;
                seriTxt.Text = araclar.Seri;
                modelTxt.Text = araclar.Model_Yıl;
                ucretTxt.Text = araclar.KiraUcreti.ToString();
                kmTxt.Text = araclar.Km.ToString();
                vitesTxt.Text = araclar.Vites;
                yakitTxt.Text = araclar.Yakıt;
                plakaTxt.Text = araclar.Plaka;




            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (AracKiralamaEntities db = new AracKiralamaEntities())
            {
                textBox1.Text = aracKiraladataGrid.CurrentRow.Cells[10].Value.ToString();
                string aranan = textBox1.Text;
                for (int i = 0; i <= aracKiraladataGrid.Rows.Count - 1; i++)
                {
                    foreach (DataGridViewRow row in aracKiraladataGrid.Rows)
                    {
                        foreach (DataGridViewCell cell in aracKiraladataGrid.Rows[i].Cells)
                        {
                            if (cell.Value != null)
                            {
                                if (cell.Value.ToString().ToUpper() == aranan)
                                {
                                    aracID = Convert.ToInt32(aracKiraladataGrid.CurrentRow.Cells[1].Value);
                                    musteriID = Convert.ToInt32(aracKiraladataGrid.CurrentRow.Cells[2].Value);
                                    tcTxt.Text = aracKiraladataGrid.CurrentRow.Cells[3].Value.ToString();
                                    adTxt.Text = aracKiraladataGrid.CurrentRow.Cells[4].Value.ToString();
                                    soyadTxt.Text = aracKiraladataGrid.CurrentRow.Cells[5].Value.ToString();
                                    telefonTxt.Text = aracKiraladataGrid.CurrentRow.Cells[6].Value.ToString();
                                    adresTxt.Text = aracKiraladataGrid.CurrentRow.Cells[7].Value.ToString();
                                    ehliyetNoTxt.Text = aracKiraladataGrid.CurrentRow.Cells[13].Value.ToString();

                                    break;
                                }
                            }
                        }
                    }
                }

                if (araclarCombo.Items.Count <= 1)
                {
                    MessageBox.Show("Teslim edilecek uygun araç bulunmamaktadır ! ","HATA !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                AraclarListesi araclar = db.AraclarListesi.FirstOrDefault(a => a.Seri == textBox1.Text);
                aracID = araclar.AracID;
                markaTxt.Text = araclar.Marka;
                seriTxt.Text = araclar.Seri;
                modelTxt.Text = araclar.Model_Yıl;
                ucretTxt.Text = araclar.KiraUcreti.ToString();
                kmTxt.Text = araclar.Km.ToString();
                vitesTxt.Text = araclar.Vites;
                yakitTxt.Text = araclar.Yakıt;
                plakaTxt.Text = araclar.Plaka;


            }




        }
    }
}
