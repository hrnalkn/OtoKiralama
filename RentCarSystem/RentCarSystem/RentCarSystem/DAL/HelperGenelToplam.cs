using RentCarSystem.ENTITY;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentCarSystem.DAL
{
    class HelperGenelToplam
    {

        public static List<GenelToplam> GetTotal()
        {
            using (var ce = new AracKiralamaEntities())
            {
                return ce.GenelToplam.ToList();
              

            }
        }
        public static bool ToplamcCud(GenelToplam toplam, EntityState entityState)
        {
            using (var ce = new AracKiralamaEntities())
            {
                ce.Entry(toplam).State = entityState;
                return ce.SaveChanges() > 0;
            }
        }
    }
}
