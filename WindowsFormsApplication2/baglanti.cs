using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace WindowsFormsApplication2
{
    public class baglanti
    {
        OleDbConnection connection;
        public bool baglanti_kontrol()
        {
            try
            {
                connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\projelerim\\MTS.accdb");
                connection.Open();
                return true;
            }
            catch(Exception)
            {
                return false;
 
            }
           
        
        }
    }
}
