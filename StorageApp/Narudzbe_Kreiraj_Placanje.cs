﻿using System;
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
    public partial class Narudzbe_Kreiraj_Placanje : UserControl
    {

        private ProizvodDB _proizvodiDb = new ProizvodDB();

        public Narudzbe_Kreiraj_Placanje()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProizvodiSelectForm frm = new ProizvodiSelectForm();
            frm.SetData(_proizvodiDb.GetProducts());
            

            if(frm.ShowDialog() == DialogResult.OK)
            {
                listView1.Items.Add(frm.SelectedProduct.Proizvod);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //list narudzba add item
        }
    }
}
