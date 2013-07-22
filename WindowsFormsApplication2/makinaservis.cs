using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class makinaservis
    {
        public class makinakayıtlar
        {
            private int _id;
            public int id
            {
                get { return _id; }
                set { _id = value; }
            }
           
            private string _dsi_no;
            public string dsi_no
            {
                get { return _dsi_no; }
                set { _dsi_no = value; }
            }
            private string _mtarih;
            public string mtarih
            {
                get { return _mtarih; }
                set { _mtarih = value; }
            }
            private string _marka;
            public string marka
            {
                get { return _marka; }
                set { _marka = value; }
            }
            private string _birim;
            public string birim
            {
                get { return _birim; }
                set { _birim = value; }
            }
            private string _c_yer;
            public string c_yer
            {
                get { return _c_yer; }
                set { _c_yer = value; }
            }
            private string _aciklama;
            public string aciklama
            {
                get { return _aciklama; }
                set { _aciklama = value; }
            }
            private string _p_isim;
            public string p_isim
            {
                get { return _p_isim; }
                set { _p_isim = value; }
            }
            private string _p_pozisyon;
            public string p_pozisyon
            {
                get { return _p_pozisyon; }
                set { _p_pozisyon = value; }
            }
            private string _p_t_pozisyon;
            public string p_t_pozisyonu
            {
                get { return _p_t_pozisyon; }
                set { _p_t_pozisyon = value; }
            }

        }
    }
}

