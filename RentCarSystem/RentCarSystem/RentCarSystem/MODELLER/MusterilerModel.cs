using RentCarSystem.ENTITY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarSystem.DAL
{
    class MusterilerModel
    {
        public int MusteriID { get; set; }
        public string TcNO { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public string Cinsiyet { get; set; }
        public int EhliyetNo { get; set; }

    }
}
