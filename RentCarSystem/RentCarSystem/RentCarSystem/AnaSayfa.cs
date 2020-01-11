using RentCarSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentCarSystem
{
    public partial class AnaSayfa : Form
    {
        int yon;
        public AnaSayfa()
        {
            Thread t = new Thread(new ThreadStart(StartForm));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
            musteriEklebtn.MouseEnter += OnmauseEnterMusteriEklebtn;
            musteriEklebtn.MouseLeave += OnmauseLeaveMusteriEklebtn;
            mustetilerbtn.MouseEnter += OnmauseEnterMustetilerbtn;
            mustetilerbtn.MouseLeave += OnmauseLeaveMustetilerbtn;
            arackaydetbtn.MouseEnter += OnmauseEnterArackaydetbtn;
            arackaydetbtn.MouseLeave += OnmauseLeaveArackaydetbtn;
            araclistesibtn.MouseEnter += OnmauseEnterAraclistesibtn;
            araclistesibtn.MouseLeave += OnmauseLeaveAraclistesibtn;
            arackiralabtn.MouseEnter += OnmauseEnterArackiralabtn;
            arackiralabtn.MouseLeave += OnmauseLeaveArackiralabtn;
            raporbtn.MouseEnter += OnmauseEnterRaporbtn;
            raporbtn.MouseLeave += OnmauseLeaveRaporbtn;
            cikisbtn.MouseEnter += OnmauseEnterCikisbtn;
            cikisbtn.MouseLeave += OnmauseLeaveCikisbtn;
            timer1.Interval = 1;
            yon = 0;
        }
        public void StartForm()
        {
            Application.Run(new AnaSayfaSplash());
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void cikisbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Müşteriler musteriler = new Müşteriler();
            musteriler.Show();
        }
        private void musteriEklebtn_Click(object sender, EventArgs e)
        {
            Müsteri_Ekle musteriEkle = new Müsteri_Ekle();
            musteriEkle.Show();
        }
        private void arackaydetbtn_Click(object sender, EventArgs e)
        {
            AracKayıt arackaydet = new AracKayıt();
            arackaydet.Show();
        }
        private void araclistesibtn_Click(object sender, EventArgs e)
        {
            MevcutAraçlar araçlar = new MevcutAraçlar();
            araçlar.Show();
        }
        private void arackiralabtn_Click(object sender, EventArgs e)
        {
            AracKirala arackirala = new AracKirala();
            arackirala.Show();
        }
        private void raporbtn_Click(object sender, EventArgs e)
        {
            Rapor rapor = new Rapor();
            rapor.Show();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (yon == 0 && label2.Location.X > -551)
            {
                label2.Location = new Point(label2.Location.X - 2, label2.Location.Y);
            }
            if (yon == 0 && label2.Location.X < -550)
            {
                yon = 1;
            }
            if (yon == 1 && label2.Location.X + 305 < 910)
            {
                label2.Location = new Point(727, 439);
                yon = 0;
            }
        }
        private void OnmauseEnterMusteriEklebtn(object sender, EventArgs e)
        {
            musteriEklebtn.BackColor = Color.Green;
        }
        private void OnmauseLeaveMusteriEklebtn(object sender, EventArgs e)
        {
            musteriEklebtn.BackColor = Color.White;
        }
        private void OnmauseEnterMustetilerbtn(object sender, EventArgs e)
        {
            mustetilerbtn.BackColor = Color.Green;
        }
        private void OnmauseLeaveMustetilerbtn(object sender, EventArgs e)
        {
            mustetilerbtn.BackColor = Color.White;
        }
        private void OnmauseEnterArackaydetbtn(object sender, EventArgs e)
        {
            arackaydetbtn.BackColor = Color.Green;
        }
        private void OnmauseLeaveArackaydetbtn(object sender, EventArgs e)
        {
            arackaydetbtn.BackColor = Color.White;
        }
        private void OnmauseEnterAraclistesibtn(object sender, EventArgs e)
        {
            araclistesibtn.BackColor = Color.Green;
        }
        private void OnmauseLeaveAraclistesibtn(object sender, EventArgs e)
        {
            araclistesibtn.BackColor = Color.White;
        }
        private void OnmauseEnterArackiralabtn(object sender, EventArgs e)
        {
            arackiralabtn.BackColor = Color.Green;
        }
        private void OnmauseLeaveArackiralabtn(object sender, EventArgs e)
        {
            arackiralabtn.BackColor = Color.White;
        }
        private void OnmauseEnterRaporbtn(object sender, EventArgs e)
        {
            raporbtn.BackColor = Color.Green;
        }
        private void OnmauseLeaveRaporbtn(object sender, EventArgs e)
        {
            raporbtn.BackColor = Color.White;
        }
        private void OnmauseEnterCikisbtn(object sender, EventArgs e)
        {
            cikisbtn.BackColor = Color.Red;
        }
        private void OnmauseLeaveCikisbtn(object sender, EventArgs e)
        {
            cikisbtn.BackColor = Color.White;
        }
    }
}
