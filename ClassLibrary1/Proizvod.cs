using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   
    public class ProizvodDB
    {
        public int Id_Proizvoda { get; set; }
        public Proizvodi unosProizvoda(string naziv_P, int velicina_P, string spol_P, string detalj_P, int cijena_P, int kolicina_P)
        {
            Proizvodi proizvod = new Proizvodi();
            Skladište skladiste = new Skladište();

            proizvod.Proizvod = naziv_P;
            proizvod.Velicina = velicina_P;
            proizvod.Spol = spol_P;
            proizvod.Detalj = detalj_P;
            proizvod.Cijena = cijena_P;
            skladiste.Kolicina = kolicina_P;
            using (WarehouseDBEntities ctx = new WarehouseDBEntities())
            {
                Id_Proizvoda = ctx.Proizvodi.OrderByDescending(x => x.ID_Proizvoda).First().ID_Proizvoda + 1;
            }
            skladiste.ID_Proizvoda = Id_Proizvoda;

            using (WarehouseDBEntities ctx = new WarehouseDBEntities())
            {
                proizvod = ctx.Proizvodi.Add(proizvod);
                ctx.SaveChanges();
                skladiste = ctx.Skladište.Add(skladiste);
                ctx.SaveChanges();
            }
            return proizvod;
        }
    }
}
