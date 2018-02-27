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
                    return null;

                return (Proizvodi)dataGridView1.SelectedRows[0].DataBoundItem;
            }
        }

        private void RaiseOnSelectProduct()
        {
            if(OnSelectProduct != null)
            {
                OnSelectProduct(this, EventArgs.Empty);
            }
        }
        
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

        public ucProizvodi()
        {
            InitializeComponent();
            
            dataGridView1.DataSource = _proizvodiDb.GetAll();
        }
        

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                RaiseOnSelectProduct();
                RaiseOnProductSelected(SelectedProduct);
            }
        }
    }
}
