using RentCarSystem.ENTITY;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarSystem.DAL
{
    class HelperMusteriler
    {
        public static bool MusteriKontrol(string tc)
        {
            using (var ce = new AracKiralamaEntities())
            {
                if (ce.Musteriler.Any(x => x.TcNO == tc))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }


        }
        public static List<MusterilerModel> GetMusteriler()
        {
            using (var ce = new AracKiralamaEntities())
            {
                return ce.Musteriler.Select(p => new MusterilerModel
                {
                    MusteriID = p.MusteriID,
                    TcNO = p.TcNO,
                    Ad = p.Ad,
                    Soyad = p.Soyad,
                    Telefon = p.Telefon,
                    Adres = p.Adres,
                    Email = p.Email,
                    Cinsiyet = p.Cinsiyet,
                    EhliyetNo=p.EhliyetNo


                }).ToList();
            }
        }
        public static List<string> GetMusterilerAdı()
        {
            using (var ce = new AracKiralamaEntities())
            {
                List<MusterilerModel> list = new List<MusterilerModel>();
                list= ce.Musteriler.Select(p => new MusterilerModel
                {
                    Ad = p.Ad,

                }).ToList();

                List<string> list2 = new List<string>();
                list2.Add("");
                foreach (MusterilerModel item in list)
                {
                    list2.Add(item.Ad);
                }


                return list2;
            }
        }
        public static bool MusteriCud(Musteriler musteriler, EntityState entityState)
        {
            using (var ce = new AracKiralamaEntities())
            {
                ce.Entry(musteriler).State = entityState;
                return ce.SaveChanges() > 0;
            }
        }
        public static List<MusterilerModel> GetMusterilerByTcNo(string TcNo)
        {
            using (var ce = new AracKiralamaEntities())
            {
                return GetMusteriler().Where(pr => pr.TcNO == TcNo).ToList();
            }
        }
        


    }



}

