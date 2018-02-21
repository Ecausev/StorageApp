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
    public partial class MainFrame : Form
    {
        Narudzbe_Kreiraj narudzba_K = new Narudzbe_Kreiraj();
        enum UcType
        {
            Narudzba_kreiraj,
            Narudzba_kreiraj_placanje,
            Narudzba_kupci_pretraga,
            Skladiste_dodaj,
            Skladiste_trazi,
        }
        Dictionary<UcType, Control> _windows = new Dictionary<UcType, Control>();
        public MainFrame()
        {
            InitializeComponent();
            narudzba_K.button1.Click += Button1_Click;
            narudzba_K.OnButtonClicked += Narudzba_K_OnButtonClicked;

            InitUc(UcType.Narudzba_kreiraj, narudzba_K);
            InitUc(UcType.Narudzba_kreiraj_placanje, new Narudzbe_Kreiraj_Placanje());
            InitUc(UcType.Narudzba_kupci_pretraga, new Narudzbe_Kupci_Pretraga());
            InitUc(UcType.Skladiste_dodaj, new Skladiste_Dodaj());
            InitUc(UcType.Skladiste_trazi, new Skladiste_Trazi());


        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Narudzba_K_OnButtonClicked(object sender, EventArgs e)
        {
            ShowWindow(UcType.Narudzba_kreiraj_placanje);
        }

        private void InitUc(UcType type, Control Uc)
        {



            Uc.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(Uc);
            _windows.Add(type, Uc);
        }
        private void HideOtherForms()
        {
            foreach (Control c in MainPanel.Controls)
            {
                c.Hide();
            }
        }

        private void ShowWindow(UcType type)
        {
            HideOtherForms();
            _windows[type].Show();
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void skladisteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindow(UcType.Skladiste_dodaj);
        }

        private void izbrisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindow(UcType.Skladiste_trazi);
        }

        private void noveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowWindow(UcType.Narudzba_kreiraj);
        }

        private void dodajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowWindow(UcType.Narudzba_kupci_pretraga);
        }

        private void prodanoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
