using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication2
{
    class personelservis
    {
        public class personelkayıtlar
        {
            private int _id;
            public int id
            {
                get { return _id; }
                set { _id = value; }
            }
            private String _isim;
            public String isim
            {
                get { return _isim; }
                set { _isim = value; }
            }
            private String _pozisyon;
            public String pozisyon
            {
                get { return _pozisyon; }
                set { _pozisyon = value; }
            }
            private String _t_pozisyon;
            public String t_pozisyon
            {
                get { return _t_pozisyon; }
                set { _t_pozisyon = value; }
            }
            private String _f_gorevi;
            public String f_gorevi
            {
                get { return _f_gorevi; }
                set { _f_gorevi = value; }
            }
            private String _birimi;
            public String birimi
            {
                get { return _birimi; }
                set { _birimi = value; }
            }
            private String _i_durumu;
            public String i_durumu
            {
                get { return _i_durumu; }
                set { _i_durumu = value; }
            }
            private String _h_yili;
            public String h_yili
            {
                get { return _h_yili; }
                set { _h_yili = value; }
            }
            private String _aciklama;
            public String aciklama
            {
                get { return _aciklama; }
                set { _aciklama = value; }
            }
        }
    }
}

