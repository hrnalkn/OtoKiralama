using RentCarSystem.DAL;
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
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }

        private void Rapor_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = HelperIslem.GetIslemler();
            this.dataGridView1.Columns["aracID"].Visible = false;
            this.dataGridView1.Columns["musteriID"].Visible = false;
            this.dataGridView1.Columns["IslemID"].Visible = false;



            int sum = 0;
            var toplam = HelperGenelToplam.GetTotal();
            foreach (var item in toplam)
            {
                sum+=item.GenelToplamUcret;
            }

            label2.Text = sum.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
