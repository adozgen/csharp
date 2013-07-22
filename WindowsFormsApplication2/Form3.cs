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
    
    public partial class Form3 : Form
    {
        String sorgu = "select * from personel";
        public personelListe pliste;
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new System.Data.OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\projelerim\\MTS.accdb");
        OleDbCommand kmt = new System.Data.OleDb.OleDbCommand();

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Kaydı eklemek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                if (ptxtadsoyad.Text.Trim() != "" && pcbxpzsyn.Text.Trim() != "" && pcbxtayin_pozsyn.Text.Trim() != "" && pcbxfili_gorev.Text.Trim() != "" && pcbxbirim.Text.Trim() != "" && pcbxizin_durumu.Text.Trim() != "" && ptxthizmet_suresi.Text.Trim() != "" & ptxtaciklama.Text.Trim() != "")
                {
                    
                    
                    
                        
                         bag.Open();

                        kmt.Connection = bag;
                        kmt.CommandText = "Insert Into personel(isim,pozisyon,t_pozisyon,f_gorevi,birimi,i_durumu,h_yili,aciklama) Values('" + ptxtadsoyad.Text + "','" + pcbxpzsyn.Text + "','" + pcbxtayin_pozsyn.Text + "','" + pcbxfili_gorev.Text + "','" + pcbxbirim.Text + "','" + pcbxizin_durumu.Text + "','" + ptxthizmet_suresi.Text + "','" + ptxtaciklama.Text + "')";
                        kmt.ExecuteNonQuery();
                        pliste = new personelListe();
                        pliste.displayrecords(sorgu);
                        pliste.Show();
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
            DialogResult cevap;
            cevap = MessageBox.Show("değişikliği kaydetmek istediğinizden emin misiniz?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                if (ptxtadsoyad.Text.Trim() != "" && pcbxpzsyn.Text.Trim() != "" && pcbxtayin_pozsyn.Text.Trim() != "" && pcbxfili_gorev.Text.Trim() != "" && pcbxbirim.Text.Trim() != "" && pcbxizin_durumu.Text.Trim() != "" && ptxthizmet_suresi.Text.Trim() != "" & ptxtaciklama.Text.Trim() != "")
                {




                    bag.Open();
                    personelListe mliste = new personelListe();
                    mliste.Show();


                    kmt.Connection = bag;

                    kmt.CommandText = "Update personel SET isim='" + ptxtadsoyad.Text + "', pozisyon= '" + pcbxpzsyn.Text + "', t_pozisyon='" + pcbxtayin_pozsyn.Text + "', f_gorevi ='" + pcbxfili_gorev.Text + "',birimi='" + pcbxbirim.Text + "',i_durumu='" + pcbxizin_durumu.Text + "',h_yili='" + ptxthizmet_suresi.Text + "',aciklama='" + ptxtaciklama.Text + "'where id=" + Convert.ToInt32(ptxtid.Text) + "";


                    kmt.ExecuteNonQuery();
                    mliste.displayrecords(sorgu);
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

        private void ptxtadsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptxtadsoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }
        }
    }


