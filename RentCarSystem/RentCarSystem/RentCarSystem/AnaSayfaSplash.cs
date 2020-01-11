using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace RentCarSystem
{
    public partial class AnaSayfaSplash : Form
    {

        public AnaSayfaSplash()
        {
            InitializeComponent();
            timer1.Enabled = true;
            label1.Text = "    YÜKLENİYOR ...    ";
            label1.ForeColor = Color.Yellow;

            SoundPlayer player = new SoundPlayer();

            string path = Application.StartupPath.ToString() + "\\SplashSound.wav"; // Ses dosyası Bin\\Debug içindeki yeri. Dosyayı Debug içinden aldım.
            player.SoundLocation = path;
            player.Play(); 

        }

        private void AnaSayfaSplash_Load(object sender, EventArgs e)
        {



        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = label1.Text.Substring(1) + label1.Text.Substring(0, 1);
        }
    }
}
