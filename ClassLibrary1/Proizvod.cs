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
        public bool proizvod { get; set; }
        public bool velicina { get; set; }

        public Proizvodi unosProizvoda(string naziv_P, int velicina_P, string spol_P, string detalj_P, int cijena_P, int kolicina_P)
        {
            Proizvodi proizvod = new Proizvodi();

            proizvod.Proizvod = naziv_P;
            proizvod.Velicina = velicina_P;
            proizvod.Spol = spol_P;
            proizvod.Detalj = detalj_P;
            proizvod.Cijena = cijena_P;
            proizvod.Qty = kolicina_P;

            //ukoliko se dodaje isti proizvod s istim podacima, samo promjenimo qty za vrijednost qty-a.

            //procistiti kod kao u sljedecem primjeru.
            
            //proizvod = new Proizvodi()
            //{
            //    Proizvod = naziv_P,
            //    Velicina = velicina_P
            //};

            using (WarehouseDBEntities ctx = new WarehouseDBEntities())
            {
                proizvod = ctx.Proizvodi.Add(proizvod);
                ctx.SaveChanges();
            }
            return proizvod;
        }
        public List<Proizvodi> GetProducts()
        {
            List<Proizvodi> proizvodi = new List<Proizvodi>();
            
            using (WarehouseDBEntities ctx = new WarehouseDBEntities())
            {
                proizvodi = ctx.Proizvodi.ToList();
            }
            return proizvodi;
        }

        //public List<Proizvodi> FilteredList()
        //{
        //    List<Proizvodi> proizvodi = new List<Proizvodi>();
        //    using (WarehouseDBEntities ctx = new WarehouseDBEntities())
        //    {
        //        if (proizvod == true)
        //        {
        //            var test = 2;
        //            proizvod = ctx.Proizvodi.Select(x => x.Velicina.Contains(test));
        //        }
        //        proizvodi = ctx.tol
        //    }
        //}
        
    }
}
