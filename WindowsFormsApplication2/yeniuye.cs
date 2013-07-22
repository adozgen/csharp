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
    public partial class yeniuye : Form
    {
        public yeniuye()
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
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM users", bag);
            da.Fill(dt);
            DataRow r = dt.NewRow();
            r[1] = textBox1.Text;
            r[2] = textBox2.Text;
            dt.Rows.Add(r);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            da.Update(dt);
            bag.Close();
            MessageBox.Show("yeni üye kaydı başarıyla tamamlandı!");
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
