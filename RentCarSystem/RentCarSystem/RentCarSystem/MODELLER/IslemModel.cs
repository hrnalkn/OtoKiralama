using RentCarSystem.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarSystem.DAL
{
    class IslemModel
    {

        public int IslemID { get; set; }
        public int aracID { get; set; }
        public int musteriID { get; set; }
        public string TC { get; set; }
        public string Adı { get; set; }
        public string Soyadı { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Plaka { get; set; }
        public string AracMarka { get; set; }
        public string Araçseri { get; set; }
        public string Model { get; set; }
        public int Km { get; set; }
        public int EhliyetNo { get; set; }

        public string Vites { get; set; }
        public string Yakıt { get; set; }
        public int KiraUcreti { get; set; }
        public string Durum { get; set; }
        public System.DateTime AracCıkısTarihi { get; set; }
        public System.DateTime AracTeslimTarihi { get; set; }
        public int ToplamUcret { get; set; }

        
    }
}
