using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;

namespace StorageApp
{
    public partial class Skladiste_Dodaj : UserControl
    {
        public string Spol_Proizvoda { get; set; }
        public Skladiste_Dodaj()
        {
            InitializeComponent();
        }

        private void Velicina_Proiz_box_TextChanged(object sender, EventArgs e)
        {
            Text = Velicina_Proiz_box.Text;
        }

        private void Dodaj_Proiz_btn_Click(object sender, EventArgs e)
        {

            if (Spol_btn_M.Checked)
            {
                Spol_Proizvoda = Spol_btn_M.Text;
            }
            if (Spol_Btn_Z.Checked)
            {
                 Spol_Proizvoda = Spol_Btn_Z.Text;
            }
            
            string Naziv_Proizvoda = Naziv_Proiz_Box.Text;
            int Velicina_Proizvoda = 0;
            int Kolicina_Proizvoda = 0;
            int Cijena_Proizvoda = 0;
            Int32.TryParse(Velicina_Proiz_box.Text,out Velicina_Proizvoda);
            Int32.TryParse(Kolicina_Proiz_box.Text, out Kolicina_Proizvoda);
            Int32.TryParse(Cijena_Proiz_box.Text, out Cijena_Proizvoda);
            string Detalj_Proizvoda = Detalj_Proiz_box.Text;
            ProizvodDB DB = new ProizvodDB();
            if (Velicina_Proizvoda == 0 || Kolicina_Proizvoda == 0 || Cijena_Proizvoda == 0)
            {
                MessageBox.Show("Neuspješan unos proizvoda. Provjeri Velicinu,Kolicinu ili cijenu proizvoda!");

            }
            else
            {
                DB.unosProizvoda(Naziv_Proizvoda, Velicina_Proizvoda, Spol_Proizvoda, Detalj_Proizvoda, Cijena_Proizvoda, Kolicina_Proizvoda);
                MessageBox.Show($"Uspješno je unešen proizvod {Naziv_Proizvoda}, Velicina {Velicina_Proizvoda}, Spol {Spol_Proizvoda}, Detalj {Detalj_Proizvoda}, Kolicina {Kolicina_Proizvoda}, Cijena {Cijena_Proizvoda} ");

            }
        }

        private void Naziv_Proiz_Box_TextChanged(object sender, EventArgs e)
        {
            Text = Naziv_Proiz_Box.Text;
        }


        private void Detalj_Proiz_box_TextChanged(object sender, EventArgs e)
        {
            Text = Detalj_Proiz_box.Text;
        }

        private void Kolicina_Proiz_box_TextChanged(object sender, EventArgs e)
        {
            Text = Kolicina_Proiz_box.Text;
        }

        private void Cijena_Proiz_box_TextChanged(object sender, EventArgs e)
        {
            Text = Cijena_Proiz_box.Text;
        }
    }
}
