using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class makinarapor : Form
    {
        public makinarapor()
        {
            InitializeComponent();
        }

        private void makinarapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MTSDataSet1.makina' table. You can move, or remove it, as needed.
            this.makinaTableAdapter.Fill(this.MTSDataSet1.makina);

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
