using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StorageApp
{
    public partial class Narudzbe_Kreiraj : UserControl
    {
        public event EventHandler OnButtonClicked;
        public Narudzbe_Kreiraj()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(OnButtonClicked != null)
            {
                OnButtonClicked(sender, e);
            }
                
        }
    }
}
