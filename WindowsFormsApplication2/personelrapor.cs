﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class personelrapor : Form
    {
        public personelrapor()
        {
            InitializeComponent();
        }

        private void personelrapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'MTSDataSet.personel' table. You can move, or remove it, as needed.
            //this.personelTableAdapter.Fill(this.MTSDataSet.personel);

            this.reportViewer1.RefreshReport();
        }
    }
}
