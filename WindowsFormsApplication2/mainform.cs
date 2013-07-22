using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication2
{
    public partial class mainform : Form
    {
        public int omer = 1;
        public int nail = 2;
        public personelListe pliste;
        public makinaListe mliste;
        public Form1 frm1;
        public mainform()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\projelerim\\MTS.accdb");
        public void baglan()
        {
            if (bag.State == ConnectionState.Closed)
            {
                bag.Open();
            }
        }
        private void mainform_Load(object sender, EventArgs e)
        {
            if ((kulid.Text == omer.ToString()) || kulid.Text==nail.ToString() ){
                kullanıcıİşlemleriToolStripMenuItem.Visible = false;
            }
            else
            {
                adminİşlemleriToolStripMenuItem.Visible = false;
            }
        }

        private void makinaListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void yeniKakinaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void makinaAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            makinaListe mliste = new makinaListe();
            mliste.Show();

        }

        private void yeniPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            frm3.Show();
        }

        private void personelListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pliste = new personelListe();
            pliste.Show();
        }

        private void personelAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pliste = new personelListe();
            pliste.ShowDialog();
            
        }

        private void şifreyiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfiredegistir sfrdgstr = new sfiredegistir();
            sfrdgstr.Show();
            sfrdgstr.label1.Text = kulid.Text;
            sfrdgstr.textBox1.Text = kul_ad.Text;
        }

        private void yeniÜyeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            yeniuye yuye = new yeniuye();
            yuye.Show();
        }

        private void şifremiDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfiredegistir sfrdgstr = new sfiredegistir();
            sfrdgstr.Show();
            sfrdgstr.label1.Text = kulid.Text;
            sfrdgstr.textBox1.Text = kul_ad.Text;
        }

        private void makinaListesiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mliste = new makinaListe();
            mliste.ShowDialog();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
