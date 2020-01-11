using RentCarSystem.ENTITY;
using RentCarSystem.MODELLER;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarSystem.DAL
{
    class HelperAraclar
    {
        public static List<AraclarModel> GetAraclar()
        {
            using (var ce = new AracKiralamaEntities())
            {
                return ce.AraclarListesi.Select(p => new AraclarModel
                {
                    AracID = p.AracID,
                    Plaka= p.Plaka,
                    Marka=p.Marka,
                    Seri = p.Seri,
                    Model_Yıl = p.Model_Yıl,
                    Km = p.Km,
                    Vites = p.Vites,
                    Yakıt = p.Yakıt,
                    KiraUcreti=p.KiraUcreti,
                    Durum=p.Durum

                }).ToList();
            }
        }
        public static List<AraclarListesi> GetAracById(int AracId)
        {
            using (var ce = new AracKiralamaEntities())
            {
                return ce.AraclarListesi.Where(cs => cs.AracID == AracId).ToList();
            }
        }
        public static List<string> GetAracSeri()
        {
            using (var db = new AracKiralamaEntities())
            {
                List<AraclarModel> aracList = HelperAraclar.GetAraclar();
                List<AraclarModel> aracList2 = aracList.Where(q => q.Durum!="Kiralandı").ToList();            
                List<AraclarModel> list = aracList2;             
                List<string> list2 = new List<string>();
                list2.Add("");
                foreach (AraclarModel item in list)
                {
                    list2.Add(item.Seri);
                }


                return list2;
            }
        }
        public static List<string> AracTeslim()
        {
            using (var db = new AracKiralamaEntities())
            {
                List<AraclarModel> aracList = HelperAraclar.GetAraclar();
                List<AraclarModel> aracList2 = aracList.Where(q => q.Durum == "Rezerve" || q.Durum=="Kiralandı").ToList();
                List<AraclarModel> list = aracList2;
                List<string> list2 = new List<string>();
                list2.Add("");
                foreach (AraclarModel item in list)
                {
                    list2.Add(item.Seri);
                }


                return list2;
            }
        }
        public static bool AracCud(AraclarListesi araclar, EntityState entityState)
        {
            using (var ce = new AracKiralamaEntities())
            {
                ce.Entry(araclar).State = entityState;
                return ce.SaveChanges() > 0;
            }
        }
    }
}
