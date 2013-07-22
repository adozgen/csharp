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
    public partial class sfiredegistir : Form
    {
        public mainform mfrm;
        public index indx;
        public sfiredegistir()
        {
            mfrm = new mainform();
            indx = new index();
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

            OleDbCommand cm = new OleDbCommand();
            cm.Connection = bag;
            cm.CommandText = "Update users SET parola= '" + textBox2.Text + "'Where id="+Convert.ToInt32(label1.Text)+"";
            cm.ExecuteNonQuery();
            bag.Close();
            MessageBox.Show("Şifreniz başarıyla değiştirildi!");
            this.Close();
            
            


        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            mfrm.Close();
        }

        private void sfiredegistir_Load(object sender, EventArgs e)
        {
            
        }
    }
}
