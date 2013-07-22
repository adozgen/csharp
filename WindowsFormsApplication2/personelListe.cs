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
    public partial class personelListe : Form
    {
        public Form3 frm3;
      
        public personelListe()
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
        String sorgu = "SELECT * FROM personel";
        public void displayrecords(String srgu)
        {

            baglan();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(srgu, bag);
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

        }


        

        private void personelListe_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mTSDataSet.personel' table. You can move, or remove it, as needed.
            //this.personelTableAdapter.Fill(this.mTSDataSet.personel);
            //displayrecords(sorgu);
            this.dataGridView1.DataSource = null;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayrecords(sorgu);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglan();
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from personel where isim Like '%" + textBox1.Text + "%'", bag);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            bag.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            baglan();
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from personel where pozisyon Like '%" + textBox2.Text + "%'", bag);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            bag.Close();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox2.Enabled = true;
            }
            else
            {
                textBox2.Enabled = false;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            baglan();
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from personel where f_gorevi Like '%" + textBox3.Text + "%'", bag);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            bag.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox3.Enabled = true;
            }
            else
            {
                textBox3.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personelservis servis = new personelservis();
            personelrapor raporum = new personelrapor();

            List<personelservis.personelkayıtlar> liste = new List<personelservis.personelkayıtlar>();
            int kyttoplam;
            kyttoplam = dataGridView1.Rows.Count;

            for (int i = 0; i < kyttoplam - 1; i++)
            {

                personelservis.personelkayıtlar item = new personelservis.personelkayıtlar();
                item.isim = dataGridView1.Rows[i].Cells[1].Value.ToString();
                item.pozisyon = dataGridView1.Rows[i].Cells[2].Value.ToString();
                item.t_pozisyon = dataGridView1.Rows[i].Cells[3].Value.ToString();
                item.f_gorevi = dataGridView1.Rows[i].Cells[4].Value.ToString();
                item.birimi = dataGridView1.Rows[i].Cells[5].Value.ToString();
                item.i_durumu = dataGridView1.Rows[i].Cells[6].Value.ToString();
                item.h_yili = dataGridView1.Rows[i].Cells[7].Value.ToString();
                item.aciklama = dataGridView1.Rows[i].Cells[8].Value.ToString();

                liste.Add(item);
            }
            raporum.personelBindingSource.DataSource = liste.ToArray();
            raporum.reportViewer1.RefreshReport();
            raporum.Show();
            this.Close();
        }

        private void yeniPersonelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm3 = new Form3();
            frm3.Show();
            this.Close();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm3 = new Form3();
            frm3.Show();
            frm3.ptxtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm3.ptxtadsoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm3.pcbxpzsyn.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm3.pcbxtayin_pozsyn.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm3.pcbxfili_gorev.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm3.pcbxbirim.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm3.pcbxizin_durumu.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm3.ptxthizmet_suresi.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm3.ptxtaciklama.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            this.Close();
            
        }

        private void personelSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglan();

            DataTable dt = new DataTable();
            DialogResult dugmesec;
            dugmesec = MessageBox.Show(this, "silmek istediğinize eminmisiniz?", "kayıt sil", MessageBoxButtons.YesNo);
            if (dugmesec == DialogResult.Yes)
            {
                OleDbDataAdapter da = new OleDbDataAdapter("delete from personel where id =" + dataGridView1.CurrentRow.Cells[0].Value + "", bag);
                da.Fill(dt);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
                da.Update(dt);
                displayrecords(sorgu);
                bag.Close();
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
