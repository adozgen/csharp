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
    public partial class Form1 : Form
    {
        public makinaListe mliste;
        String m_sorgu = "SELECT * FROM makina";
        public personelListe pliste = new personelListe();
        public Form1()
        {
            mliste = new makinaListe();
            InitializeComponent();
            
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\projelerim\\MTS.accdb");
        OleDbCommand kmt = new OleDbCommand();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı eklemek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                if (dt.Text.Trim() != "" && mtxtdsino.Text.Trim() != "" && mtxtmarka.Text.Trim() != "" && mcbxbirim.Text.Trim() != "" && mcbxc_yer.Text.Trim() != "" && mtxtaciklama.Text.Trim() != "" && ptxtadsoyad.Text.Trim() != "" & pcbxpzsyn.Text.Trim() != "" & pcbxtayin_pozsyn.Text.Trim() != "")
                {
                    
                    
                    
                        
                        bag.Open();

                        kmt.Connection = bag;
                        kmt.CommandText = "Insert Into makina(mtarih,dsi_no,marka,birim,c_yer,aciklama,p_isim,p_pozisyon,p_t_pozisyonu) Values('" + dt.Text + "','" + mtxtdsino.Text + "','" + mtxtmarka.Text + "','" + mcbxbirim.Text + "','" + mcbxc_yer.Text + "','" + mtxtaciklama.Text + "','" + ptxtadsoyad.Text + "','" + pcbxpzsyn.Text + "','" + pcbxtayin_pozsyn.Text + "')";
                        kmt.ExecuteNonQuery();               
                        pliste.displayrecords(m_sorgu);
                        makinaListe mliste = new makinaListe();
                        mliste.Show();
                        this.Hide();
                    
                  
                        bag.Close();
                        this.Close();

                    }
                    //catch (Exception)
                    //{

                    //    MessageBox.Show("kayıtlı ögrenci girişi yapıldı");
                    //    bag.Close();
                    //    this.Close();
                    //}




                
                else MessageBox.Show("lütfen boş alanları doldurunuz!");
            }
        }
           
            


        private void btngüncelle_Click(object sender, EventArgs e)
        {
      

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txttc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
            
        }

        private void txtad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txttc_MouseEnter(object sender, EventArgs e)
        {
        }

        private void txtadres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtadres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txttel_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void txtaidat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void txtokulno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
        }

        private void cbsinif_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && e.KeyChar != (char)08)
            {
                e.Handled = true;
            }
            
        }

        private void dt_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("değişikliği kaydetmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                if (dt.Text.Trim() != "" && mtxtdsino.Text.Trim() != "" && mtxtmarka.Text.Trim() != "" && mcbxbirim.Text.Trim() != "" && mcbxc_yer.Text.Trim() != "" && mtxtaciklama.Text.Trim() != "" && ptxtadsoyad.Text.Trim() != "" & pcbxpzsyn.Text.Trim() != "" & pcbxtayin_pozsyn.Text.Trim() != "")
                {




                    bag.Open();
                    makinaListe mliste = new makinaListe();
                    mliste.Show();


                    kmt.Connection = bag;

                    kmt.CommandText = "Update makina SET mtarih='" + dt.Text + "', dsi_no= '" + mtxtdsino.Text + "', marka='" + mtxtmarka.Text + "', birim ='" + mcbxbirim.Text + "',c_yer='" + mcbxc_yer.Text + "',aciklama='" + mtxtaciklama.Text + "',p_isim='" + ptxtadsoyad.Text + "',p_pozisyon='" + pcbxpzsyn.Text + "',p_t_pozisyonu='" + pcbxtayin_pozsyn.Text + "'where id=" + Convert.ToInt32(mtxtid.Text) + "";


                    kmt.ExecuteNonQuery();
                    mliste.displayrecords(m_sorgu);
                    bag.Close();
                    MessageBox.Show("değişiklikler kaydedildi");
                    this.Close();

                }
                //catch (Exception)
                //{

                    //    MessageBox.Show("kayıtlı ögrenci girişi yapıldı");
                //    bag.Close();
                //    this.Close();
                //}





                else MessageBox.Show("lütfen boş alanları doldurunuz!");
            }



        }

        private void mtxtdsino_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtxtaciklama_TextChanged(object sender, EventArgs e)
        {
        }

        private void ptxtadsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ptxtadsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void mcbxc_yer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        

        private void mcbxc_yer_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
