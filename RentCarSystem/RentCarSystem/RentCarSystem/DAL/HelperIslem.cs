using RentCarSystem.ENTITY;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarSystem.DAL
{
    class HelperIslem
    {
        public static List<IslemModel> GetIslemler()
        {
            using (var ak = new AracKiralamaEntities())
            {
                return ak.KiralamaIslemleri.Select(p => new IslemModel
                {
                    aracID = p.AraclarListesi.AracID,
                    musteriID = p.Musteriler.MusteriID,
                    TC = p.Musteriler.TcNO,
                    Adı = p.Musteriler.Ad,
                    Soyadı = p.Musteriler.Soyad,
                    Telefon = p.Musteriler.Telefon,
                    Adres = p.Musteriler.Adres,
                    EhliyetNo = p.Musteriler.EhliyetNo,
                    Plaka = p.AraclarListesi.Plaka,
                    AracMarka = p.AraclarListesi.Marka,
                    Araçseri = p.AraclarListesi.Seri,
                    Model = p.AraclarListesi.Model_Yıl,
                    Km = p.AraclarListesi.Km,
                    Vites = p.AraclarListesi.Vites,
                    Yakıt = p.AraclarListesi.Yakıt,
                    KiraUcreti = p.AraclarListesi.KiraUcreti,
                    IslemID = p.IslemID,
                    AracCıkısTarihi = p.AracCıkısTarihi,
                    AracTeslimTarihi = p.AracTeslimTarihi,
                    ToplamUcret = p.ToplamUcret,                  
                    Durum="İşlemde"
                     
                    
                }).ToList();
            }
        }
        public static List<KiralamaIslemleri> GetIslemById(int AracId)
        {
            using (var ce = new AracKiralamaEntities())
            {
                return ce.KiralamaIslemleri.Where(cs => cs.AracID == AracId).ToList();
            }
        }

        public static bool IslemCud(KiralamaIslemleri islem, EntityState entityState)
        {
            using (var ce = new AracKiralamaEntities())
            {
                ce.Entry(islem).State = entityState;
                return ce.SaveChanges() > 0;
            }
        }
    }
}
