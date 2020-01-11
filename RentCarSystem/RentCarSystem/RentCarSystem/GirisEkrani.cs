using RentCarSystem.ENTITY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarSystem
{
    public partial class GirisEkrani : Form
    {
        int catcha;
        static Random rand = new Random();
        string userName;
        string password;
        public GirisEkrani()
        {
            InitializeComponent();
            dgrlamaTxt.Enabled = false;
            catcha = rand.Next(1000, 9999);
            dgrlamaTxt.Text = catcha.ToString();
            girisbtn.MouseEnter += OnmauseEnterGirisbtn;
            girisbtn.MouseLeave += OnmauseLeaveGirisbtn;
            button1.MouseEnter += OnmauseEnterButton1;
            button1.MouseLeave += OnmauseLeaveButton1;
        }
        private void GirisEkrani_Load(object sender, EventArgs e)
        {
        }
        private void OnmauseEnterGirisbtn(object sender, EventArgs e)
        {
            girisbtn.BackColor = Color.Green;
        }
        private void OnmauseLeaveGirisbtn(object sender, EventArgs e)
        {
            girisbtn.BackColor = Color.White;
        }
        private void OnmauseEnterButton1(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
        }
        private void OnmauseLeaveButton1(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }
        private void girisbtn_Click(object sender, EventArgs e)
        {
            using (AracKiralamaEntities db = new AracKiralamaEntities())
            {
                userName = kullanıcıAdıTxt.Text;
                password = sifreTxt.Text;
                var user = db.Kullanıcılar.FirstOrDefault(usr => usr.KullanıcıAdı == userName && usr.Sifre == password);
                try
                {
                    if (user != null)
                    {
                        if (Convert.ToInt32(dogrulamaTxt.Text) == catcha)
                        {
                            MessageBox.Show("Giriş başarılı !", "Rent A Car System Login Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            AnaSayfa anasayfa = new AnaSayfa();
                            anasayfa.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Giriş başarısız!\nLütfen bilgilerinizi kontrol edin !", "Rent A Car System Login Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            kullanıcıAdıTxt.Clear();
                            sifreTxt.Clear();
                            dogrulamaTxt.Clear();
                            catcha = rand.Next(1000, 9999);
                            dgrlamaTxt.Text = catcha.ToString();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giriş başarısız !\nLütfen bilgilerinizi kontrol edin !", "Rent A Car System Login Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        kullanıcıAdıTxt.Clear();
                        sifreTxt.Clear();
                        dogrulamaTxt.Clear();
                        catcha = rand.Next(1000, 9999);
                        dgrlamaTxt.Text = catcha.ToString();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Giriş başarısız !\nLütfen bilgilerinizi kontrol edin !", "Rent A Car System Login Panel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kullanıcıAdıTxt.Clear();
                    sifreTxt.Clear();
                    dogrulamaTxt.Clear();
                    catcha = rand.Next(1000, 9999);
                    dgrlamaTxt.Text = catcha.ToString();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
