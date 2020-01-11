using RentCarSystem.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarSystem.MODELLER
{
    class AraclarModel
    {
        public int AracID { get; set; }
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Seri { get; set; }
        public string Model_Yıl { get; set; }
        public int Km { get; set; }
        public string Vites { get; set; }
        public string Yakıt { get; set; }
        public int KiraUcreti { get; set; }
        public string Durum { get; set; }

        public virtual KiralamaIslemleri KiralamaIslemleri { get; set; }


    }
}
