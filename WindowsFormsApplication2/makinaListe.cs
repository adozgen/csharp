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

    public partial class makinaListe : Form
    {
        public Form1 frm1;
        String m_sorgu = "SELECT * FROM makina";
        public personelListe pliste = new personelListe();
        public makinaListe()
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
        
        public void displayrecords(String srgu)
        {

            baglan();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(srgu, bag);
            da.Fill(dt);
            dataGridView1.DataSource = dt.DefaultView;

        }
      
        
        
        
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            makinaservis servis = new makinaservis();
            makrapor2 dnm = new makrapor2();
            List<makinaservis.makinakayıtlar> liste = new List<makinaservis.makinakayıtlar>();
            int k = dataGridView1.Rows.Count;
            for (int i = 0; i < k - 1; i++)
            {
                makinaservis.makinakayıtlar item = new makinaservis.makinakayıtlar();
                item.mtarih = dataGridView1.Rows[i].Cells[1].Value.ToString();
                item.dsi_no = dataGridView1.Rows[i].Cells[2].Value.ToString();       
                item.p_isim = dataGridView1.Rows[i].Cells[7].Value.ToString();
                item.p_pozisyon = dataGridView1.Rows[i].Cells[8].Value.ToString();
                item.p_t_pozisyonu = dataGridView1.Rows[i].Cells[9].Value.ToString();
                liste.Add(item);


            }
            dnm.makinaBindingSource.DataSource = liste.ToArray();
            dnm.reportViewer1.Refresh();
            dnm.Show();
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            makinaservis servis = new makinaservis();
            makinarapor mrpr = new makinarapor();
            List <makinaservis.makinakayıtlar> liste = new List <makinaservis.makinakayıtlar>();
            int k = dataGridView1.Rows.Count;
            for (int i = 0; i < k - 1; i++)
            {
                makinaservis.makinakayıtlar item = new makinaservis.makinakayıtlar();

                item.mtarih = dataGridView1.Rows[i].Cells[1].Value.ToString();
                item.dsi_no = dataGridView1.Rows[i].Cells[2].Value.ToString();
                item.marka = dataGridView1.Rows[i].Cells[3].Value.ToString();
                item.birim = dataGridView1.Rows[i].Cells[4].Value.ToString();
                item.c_yer = dataGridView1.Rows[i].Cells[5].Value.ToString();
                item.aciklama = dataGridView1.Rows[i].Cells[6].Value.ToString();
                item.p_isim = dataGridView1.Rows[i].Cells[7].Value.ToString();
                item.p_pozisyon = dataGridView1.Rows[i].Cells[8].Value.ToString();
                liste.Add(item);


            }
            mrpr.makinaBindingSource.DataSource = liste.ToArray();
            mrpr.reportViewer1.Refresh();
            mrpr.Show();
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            baglan();
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from makina where mtarih Like '%" + textBox2.Text + "%'", bag);
            adp.Fill(dt);
            dataGridView1.DataSource = dt;
            bag.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            baglan();
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from makina where marka Like '%" + textBox3.Text + "%'", bag);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglan();
            DataTable dt = new DataTable();
            OleDbDataAdapter adp = new OleDbDataAdapter("select * from makina where dsi_no Like '%" + textBox1.Text + "%'", bag);
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

        private void button4_Click(object sender, EventArgs e)
        {
            displayrecords(m_sorgu);
        }

        private void makinaListe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mTSDataSet1.makina' table. You can move, or remove it, as needed.
            //this.makinaTableAdapter.Fill(this.mTSDataSet1.makina);
            // TODO: This line of code loads data into the 'mTSDataSet1.makina' table. You can move, or remove it, as needed.
            //this.makinaTableAdapter.Fill(this.mTSDataSet1.makina);
            // TODO: This line of code loads data into the 'mTSDataSet.makina' table. You can move, or remove it, as needed.
            
            
            //baglan();
            //displayrecords(m_sorgu);
            this.dataGridView1.DataSource = null;
            
            
        }

        private void yeniKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1= new Form1();
            frm1.Show();
            this.Close();
        }

        private void kaydıDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1=new Form1();
            frm1.Show();
            frm1.mtxtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm1.dt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm1.mtxtdsino.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm1.mtxtmarka.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            frm1.mcbxbirim.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            frm1.mcbxc_yer.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            frm1.mtxtaciklama.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            frm1.ptxtadsoyad.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            frm1.pcbxpzsyn.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            frm1.pcbxtayin_pozsyn.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();


            this.Close();
            

        }

        private void kaydıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baglan();

            DataTable dt = new DataTable();
            DialogResult dugmesec;
            dugmesec = MessageBox.Show(this, "silmek istediğinize eminmisiniz?", "kayıt sil", MessageBoxButtons.YesNo);
            if (dugmesec == DialogResult.Yes)
            {
                OleDbDataAdapter da = new OleDbDataAdapter("delete from makina where id =" + dataGridView1.CurrentRow.Cells[0].Value + "", bag);
                da.Fill(dt);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
                da.Update(dt);
                displayrecords(m_sorgu);
                bag.Close();
            }
        }

        

        

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
           

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            
           
                
        
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridViewRow dgvrow = dataGridView1.Rows[e.RowIndex];
            if (e.Value != null && e.Value.Equals("SAMSUN/ARIZALI"))
            {
                //dataGridView1.CurrentR  SelectionBackColor = Color.Purple; 
                //e.CellStyle.ForeColor = Color.Red;
                dgvrow.DefaultCellStyle.BackColor = Color.Red;
                dgvrow.DefaultCellStyle.SelectionBackColor = Color.Red;
            }
            else if (e.Value != null && e.Value.Equals("BAFRA/ARIZALI"))
            {
                //e.CellStyle.ForeColor = Color.Red;
                dgvrow.DefaultCellStyle.BackColor = Color.Red;
                dgvrow.DefaultCellStyle.SelectionBackColor = Color.Red;
            }
            
            

   
  
        }

        private void dataGridView1_RowDefaultCellStyleChanged(object sender, DataGridViewRowEventArgs e)
        {

        }
        }
    }

