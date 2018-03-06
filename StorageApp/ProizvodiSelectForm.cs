using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageApp
{
    public partial class ProizvodiSelectForm : Form
    {
        private ProizvodDB _proizvodiDb = new ProizvodDB();


        public Proizvodi SelectedProduct { get; set; }

        public ProizvodiSelectForm()
        {

            InitializeComponent();
        }
               

        private void ucProizvodi1_Load(object sender, EventArgs e)
        {

        }

        private void ucProizvodi1_OnSelectProduct(object sender, EventArgs e)
        {
            //Samo demo
           // Proizvodi selected = ucProizvodi1.SelectedProduct; // 1 način
            Proizvodi selected2 = ((ucProizvodi)sender).SelectedProduct; // 2 način
        }

        private void ucProizvodi1_OnProductSelected(object sender, ProductSelectedEventArgs e)
        {
            SelectedProduct = e.SelectedProduct;
            DialogResult = DialogResult.OK;
        }

        public void SetData(List<Proizvodi> data)
        {

            ucProizvodi1.SetData(data);
        }
    }
}
