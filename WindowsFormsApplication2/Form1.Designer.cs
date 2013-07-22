namespace WindowsFormsApplication2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pcbxtayin_pozsyn = new System.Windows.Forms.ComboBox();
            this.pcbxpzsyn = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ptxtadsoyad = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtaciklama = new System.Windows.Forms.TextBox();
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.mcbxc_yer = new System.Windows.Forms.ComboBox();
            this.mcbxbirim = new System.Windows.Forms.ComboBox();
            this.mtxtid = new System.Windows.Forms.TextBox();
            this.mtxtmarka = new System.Windows.Forms.TextBox();
            this.mtxtdsino = new System.Windows.Forms.TextBox();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox2.Controls.Add(this.pcbxtayin_pozsyn);
            this.groupBox2.Controls.Add(this.pcbxpzsyn);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.ptxtadsoyad);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(542, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 164);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "aracı kullanan personele ait bilgiler";
            // 
            // pcbxtayin_pozsyn
            // 
            this.pcbxtayin_pozsyn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pcbxtayin_pozsyn.FormattingEnabled = true;
            this.pcbxtayin_pozsyn.Items.AddRange(new object[] {
            "OPERATOR",
            "SOFÖR",
            "MAK.BAK",
            "DIGER"});
            this.pcbxtayin_pozsyn.Location = new System.Drawing.Point(151, 109);
            this.pcbxtayin_pozsyn.Name = "pcbxtayin_pozsyn";
            this.pcbxtayin_pozsyn.Size = new System.Drawing.Size(207, 23);
            this.pcbxtayin_pozsyn.TabIndex = 24;
            // 
            // pcbxpzsyn
            // 
            this.pcbxpzsyn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pcbxpzsyn.FormattingEnabled = true;
            this.pcbxpzsyn.Items.AddRange(new object[] {
            "OPERATOR",
            "BAKIMCI",
            "OPERATÖR-BAKIMCI",
            "DIGER"});
            this.pcbxpzsyn.Location = new System.Drawing.Point(151, 71);
            this.pcbxpzsyn.Name = "pcbxpzsyn";
            this.pcbxpzsyn.Size = new System.Drawing.Size(207, 23);
            this.pcbxpzsyn.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 112);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "tayin pozisyonu";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "pozisyonu";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 15);
            this.label14.TabIndex = 14;
            this.label14.Text = "ad soyad";
            // 
            // ptxtadsoyad
            // 
            this.ptxtadsoyad.Location = new System.Drawing.Point(151, 39);
            this.ptxtadsoyad.Name = "ptxtadsoyad";
            this.ptxtadsoyad.Size = new System.Drawing.Size(207, 23);
            this.ptxtadsoyad.TabIndex = 3;
            this.ptxtadsoyad.TextChanged += new System.EventHandler(this.ptxtadsoyad_TextChanged);
            this.ptxtadsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ptxtadsoyad_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mtxtaciklama);
            this.groupBox1.Controls.Add(this.dt);
            this.groupBox1.Controls.Add(this.mcbxc_yer);
            this.groupBox1.Controls.Add(this.mcbxbirim);
            this.groupBox1.Controls.Add(this.mtxtid);
            this.groupBox1.Controls.Add(this.mtxtmarka);
            this.groupBox1.Controls.Add(this.mtxtdsino);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(74, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 375);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "makinaya ait bilgiler";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(230, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "yetkiniz dışında alan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "açıklama";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "çalıştığı yer";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "birimi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "cinsi markası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "dsi no";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "işe başlama tarihi";
            // 
            // mtxtaciklama
            // 
            this.mtxtaciklama.Location = new System.Drawing.Point(179, 288);
            this.mtxtaciklama.Multiline = true;
            this.mtxtaciklama.Name = "mtxtaciklama";
            this.mtxtaciklama.Size = new System.Drawing.Size(199, 70);
            this.mtxtaciklama.TabIndex = 6;
            this.mtxtaciklama.TextChanged += new System.EventHandler(this.mtxtaciklama_TextChanged);
            // 
            // dt
            // 
            this.dt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt.Location = new System.Drawing.Point(179, 45);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(161, 23);
            this.dt.TabIndex = 5;
            this.dt.ValueChanged += new System.EventHandler(this.dt_ValueChanged);
            // 
            // mcbxc_yer
            // 
            this.mcbxc_yer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcbxc_yer.FormattingEnabled = true;
            this.mcbxc_yer.Items.AddRange(new object[] {
            "SAMSUN/ARIZALI",
            "TERME",
            "SAMSUN",
            "ATÖLYE",
            "ORDU",
            "KÜRTÜN-ATAKUM",
            "ÇARSAMBA",
            "VEZIRKÖPRÜ",
            "BAFRA/ARIZALI",
            "ATAKUM",
            "BAFRA",
            "DIGER"});
            this.mcbxc_yer.Location = new System.Drawing.Point(179, 228);
            this.mcbxc_yer.Name = "mcbxc_yer";
            this.mcbxc_yer.Size = new System.Drawing.Size(199, 23);
            this.mcbxc_yer.TabIndex = 4;
            this.mcbxc_yer.SelectedIndexChanged += new System.EventHandler(this.mcbxc_yer_SelectedIndexChanged);
            this.mcbxc_yer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mcbxc_yer_KeyPress);
            // 
            // mcbxbirim
            // 
            this.mcbxbirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mcbxbirim.FormattingEnabled = true;
            this.mcbxbirim.Items.AddRange(new object[] {
            "71.SUBE",
            "71.SUBE/CRSMBA",
            "DIGER"});
            this.mcbxbirim.Location = new System.Drawing.Point(179, 181);
            this.mcbxbirim.Name = "mcbxbirim";
            this.mcbxbirim.Size = new System.Drawing.Size(199, 23);
            this.mcbxbirim.TabIndex = 3;
            // 
            // mtxtid
            // 
            this.mtxtid.Location = new System.Drawing.Point(179, 13);
            this.mtxtid.Name = "mtxtid";
            this.mtxtid.ReadOnly = true;
            this.mtxtid.Size = new System.Drawing.Size(45, 23);
            this.mtxtid.TabIndex = 2;
            // 
            // mtxtmarka
            // 
            this.mtxtmarka.Location = new System.Drawing.Point(179, 135);
            this.mtxtmarka.Name = "mtxtmarka";
            this.mtxtmarka.Size = new System.Drawing.Size(199, 23);
            this.mtxtmarka.TabIndex = 1;
            // 
            // mtxtdsino
            // 
            this.mtxtdsino.Location = new System.Drawing.Point(179, 93);
            this.mtxtdsino.Name = "mtxtdsino";
            this.mtxtdsino.Size = new System.Drawing.Size(199, 23);
            this.mtxtdsino.TabIndex = 0;
            this.mtxtdsino.TextChanged += new System.EventHandler(this.mtxtdsino_TextChanged);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngüncelle.Image = global::WindowsFormsApplication2.Properties.Resources.Actualiser;
            this.btngüncelle.Location = new System.Drawing.Point(744, 257);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(124, 47);
            this.btngüncelle.TabIndex = 5;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Lucida Handwriting", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkaydet.Image = global::WindowsFormsApplication2.Properties.Resources.Validé;
            this.btnkaydet.Location = new System.Drawing.Point(559, 257);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(125, 50);
            this.btnkaydet.TabIndex = 4;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(992, 494);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MAKİNA EKLEME FORMU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox pcbxtayin_pozsyn;
        public System.Windows.Forms.ComboBox pcbxpzsyn;
        public System.Windows.Forms.TextBox ptxtadsoyad;
        public System.Windows.Forms.TextBox mtxtaciklama;
        public System.Windows.Forms.DateTimePicker dt;
        public System.Windows.Forms.ComboBox mcbxc_yer;
        public System.Windows.Forms.ComboBox mcbxbirim;
        public System.Windows.Forms.TextBox mtxtmarka;
        public System.Windows.Forms.TextBox mtxtdsino;
        public System.Windows.Forms.TextBox mtxtid;
        private System.Windows.Forms.Button btngüncelle;
        public System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.Label label8;
    }
}

