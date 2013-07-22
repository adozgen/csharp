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
    public partial class index : Form
    {
        public index()
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

        private void button1_Click(object sender, EventArgs e)
        {
            baglan();
            OleDbCommand cm = new OleDbCommand("SELECT id,k_ad FROM users WHERE k_ad='" + txtkul_adi.Text + "' and parola='" + txtsifre.Text + "'",bag);


            OleDbDataReader dr = cm.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                txtkul_adi.Clear();
                txtsifre.Clear();
                
                mainform mfrm = new mainform();
                mfrm.kulid.Text = dr[0].ToString();
                mfrm.kul_ad.Text = dr[1].ToString();
                this.Hide();
                mfrm.Show();
                



            }
            else
            {
                MessageBox.Show("Giriş işlemi başarısız!");
            }
            bag.Close();
            
        }

        private void index_Load(object sender, EventArgs e)
        {

        }
        
    }
}
