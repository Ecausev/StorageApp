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
    public partial class ucProizvodi : UserControl
    {
        private ProizvodDB _proizvodiDb = new ProizvodDB();

        public event EventHandler OnSelectProduct;

        public event EventHandler<ProductSelectedEventArgs> OnProductSelected;

        public Proizvodi SelectedProduct
        {   get
            {
                if (dataGridView1.SelectedRows.Count != 1)
                {
                    return null;
                }
                    

                return (Proizvodi)dataGridView1.SelectedRows[0].DataBoundItem;
            }
        }

        public ucProizvodi()
        {
            InitializeComponent();

            dataGridView1.DataSource = _proizvodiDb.Id_Proizvoda;
        }

        /// <summary>
        /// prvi dio dizanja eventa u kontroli proizvodi.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                RaiseOnSelectProduct(); // prvi event 
                RaiseOnProductSelected(SelectedProduct); //drugi event 
            }
        }

        /// <summary>
        /// provjerava da li je selektiran produkt
        /// ako je, onda brise event argumente. ?
        /// </summary>
        private void RaiseOnSelectProduct()
        {
            if(OnSelectProduct != null)
            {
                OnSelectProduct(this, EventArgs.Empty);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        private void RaiseOnProductSelected(Proizvodi product)
        {
            if (OnProductSelected != null)
            {
                OnProductSelected(this, new ProductSelectedEventArgs()
                {
                    SelectedProduct = product
                });
            }
        }
    }
}
