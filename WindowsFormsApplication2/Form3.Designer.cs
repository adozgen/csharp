namespace WindowsFormsApplication2
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pcbxizin_durumu = new System.Windows.Forms.ComboBox();
            this.pcbxbirim = new System.Windows.Forms.ComboBox();
            this.pcbxfili_gorev = new System.Windows.Forms.ComboBox();
            this.pcbxtayin_pozsyn = new System.Windows.Forms.ComboBox();
            this.pcbxpzsyn = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ptxtaciklama = new System.Windows.Forms.TextBox();
            this.ptxthizmet_suresi = new System.Windows.Forms.TextBox();
            this.ptxtid = new System.Windows.Forms.TextBox();
            this.ptxtadsoyad = new System.Windows.Forms.TextBox();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.btngüncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.pcbxizin_durumu);
            this.groupBox2.Controls.Add(this.pcbxbirim);
            this.groupBox2.Controls.Add(this.pcbxfili_gorev);
            this.groupBox2.Controls.Add(this.pcbxtayin_pozsyn);
            this.groupBox2.Controls.Add(this.pcbxpzsyn);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.ptxtaciklama);
            this.groupBox2.Controls.Add(this.ptxthizmet_suresi);
            this.groupBox2.Controls.Add(this.ptxtid);
            this.groupBox2.Controls.Add(this.ptxtadsoyad);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(831, 289);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "personele ait bilgiler";
            // 
            // pcbxizin_durumu
            // 
            this.pcbxizin_durumu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pcbxizin_durumu.FormattingEnabled = true;
            this.pcbxizin_durumu.Items.AddRange(new object[] {
            "1 GUN",
            "2 GUN",
            "3 GUN",
            "4 GUN",
            "5 GUN",
            "6 GUN",
            "7 GUN",
            "8 GUN",
            "9 GUN",
            "10 GUN",
            "11 GUN",
            "12 GUN",
            "13 GUN",
            "14 GUN",
            "15 GUN",
            "16 GUN",
            "17 GUN",
            "18 GUN",
            "19 GUN",
            "20 GUN",
            "21 GUN",
            "22 GUN",
            "23 GUN",
            "24 GUN",
            "25 GUN",
            "26 GUN",
            "27 GUN",
            "28 GUN",
            "29 GUN",
            "30 GUN",
            "31 GUN",
            "DIGER"});
            this.pcbxizin_durumu.Location = new System.Drawing.Point(568, 39);
            this.pcbxizin_durumu.Name = "pcbxizin_durumu";
            this.pcbxizin_durumu.Size = new System.Drawing.Size(207, 23);
            this.pcbxizin_durumu.TabIndex = 27;
            // 
            // pcbxbirim
            // 
            this.pcbxbirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pcbxbirim.FormattingEnabled = true;
            this.pcbxbirim.Items.AddRange(new object[] {
            "71.SUBE",
            "71.SUBE/CRSMBA",
            "DIGER"});
            this.pcbxbirim.Location = new System.Drawing.Point(157, 233);
            this.pcbxbirim.Name = "pcbxbirim";
            this.pcbxbirim.Size = new System.Drawing.Size(207, 23);
            this.pcbxbirim.TabIndex = 26;
            // 
            // pcbxfili_gorev
            // 
            this.pcbxfili_gorev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pcbxfili_gorev.FormattingEnabled = true;
            this.pcbxfili_gorev.Items.AddRange(new object[] {
            "MAK.BASMUH.",
            "MAK.MUH.",
            "MAK.TEK.",
            "BT TEKNISYEN-AYNIYATCI",
            "PUVANTOR",
            "YEDEK PARCA TEKN.",
            "AMBAR ISCISI",
            "DOZ.OPR.",
            "PAL.EKS.OPR.",
            "PAL.EKS.OPR(BEKO)",
            "LAS.TEK.OPR",
            "MOT.GREY.OPR.",
            "MAK.BAK.",
            "TREYLER.OPR",
            "SOFOR",
            "AKARYAKITCI",
            "DIGER"});
            this.pcbxfili_gorev.Location = new System.Drawing.Point(157, 181);
            this.pcbxfili_gorev.Name = "pcbxfili_gorev";
            this.pcbxfili_gorev.Size = new System.Drawing.Size(207, 23);
            this.pcbxfili_gorev.TabIndex = 25;
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
            this.pcbxtayin_pozsyn.Location = new System.Drawing.Point(157, 135);
            this.pcbxtayin_pozsyn.Name = "pcbxtayin_pozsyn";
            this.pcbxtayin_pozsyn.Size = new System.Drawing.Size(207, 23);
            this.pcbxtayin_pozsyn.TabIndex = 24;
            // 
            // pcbxpzsyn
            // 
            this.pcbxpzsyn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pcbxpzsyn.FormattingEnabled = true;
            this.pcbxpzsyn.Items.AddRange(new object[] {
            "MAK. MÜH.",
            "MAK. TEKNR",
            "TEKNISYEN",
            "AMBAR ISCISI",
            "BEKCI",
            "DOZ. OPR.",
            "EKS .OPR",
            "MOT.GREY.OPR.",
            "MAK. BAK.",
            "TREYLER.OPR",
            "SOFOR",
            "ALET.OPR",
            "DIGER"});
            this.pcbxpzsyn.Location = new System.Drawing.Point(157, 86);
            this.pcbxpzsyn.Name = "pcbxpzsyn";
            this.pcbxpzsyn.Size = new System.Drawing.Size(207, 23);
            this.pcbxpzsyn.TabIndex = 23;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(412, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 15);
            this.label16.TabIndex = 22;
            this.label16.Text = "kalan izin durumu";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 233);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 15);
            this.label15.TabIndex = 21;
            this.label15.Text = "birimi";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "açıklama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(411, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "hizmet süresi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "fiili görevi";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 15);
            this.label11.TabIndex = 17;
            this.label11.Text = "id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 135);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 15);
            this.label12.TabIndex = 16;
            this.label12.Text = "tayin pozisyonu";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 86);
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
            // ptxtaciklama
            // 
            this.ptxtaciklama.Location = new System.Drawing.Point(571, 177);
            this.ptxtaciklama.Multiline = true;
            this.ptxtaciklama.Name = "ptxtaciklama";
            this.ptxtaciklama.Size = new System.Drawing.Size(204, 76);
            this.ptxtaciklama.TabIndex = 7;
            // 
            // ptxthizmet_suresi
            // 
            this.ptxthizmet_suresi.Location = new System.Drawing.Point(568, 112);
            this.ptxthizmet_suresi.Name = "ptxthizmet_suresi";
            this.ptxthizmet_suresi.Size = new System.Drawing.Size(207, 23);
            this.ptxthizmet_suresi.TabIndex = 6;
            // 
            // ptxtid
            // 
            this.ptxtid.Location = new System.Drawing.Point(157, 13);
            this.ptxtid.Name = "ptxtid";
            this.ptxtid.ReadOnly = true;
            this.ptxtid.Size = new System.Drawing.Size(33, 23);
            this.ptxtid.TabIndex = 5;
            // 
            // ptxtadsoyad
            // 
            this.ptxtadsoyad.Location = new System.Drawing.Point(157, 42);
            this.ptxtadsoyad.Name = "ptxtadsoyad";
            this.ptxtadsoyad.Size = new System.Drawing.Size(207, 23);
            this.ptxtadsoyad.TabIndex = 3;
            this.ptxtadsoyad.TextChanged += new System.EventHandler(this.ptxtadsoyad_TextChanged);
            this.ptxtadsoyad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ptxtadsoyad_KeyPress);
            // 
            // btnkaydet
            // 
            this.btnkaydet.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkaydet.Image = global::WindowsFormsApplication2.Properties.Resources._001_061;
            this.btnkaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkaydet.Location = new System.Drawing.Point(309, 364);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(100, 46);
            this.btnkaydet.TabIndex = 5;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.button1_Click);
            // 
            // btngüncelle
            // 
            this.btngüncelle.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngüncelle.Image = global::WindowsFormsApplication2.Properties.Resources.Actualiser;
            this.btngüncelle.Location = new System.Drawing.Point(460, 364);
            this.btngüncelle.Name = "btngüncelle";
            this.btngüncelle.Size = new System.Drawing.Size(99, 46);
            this.btngüncelle.TabIndex = 6;
            this.btngüncelle.Text = "GÜNCELLE";
            this.btngüncelle.UseVisualStyleBackColor = true;
            this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(196, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "yetkiniz dışında alan";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.ClientSize = new System.Drawing.Size(913, 475);
            this.Controls.Add(this.btngüncelle);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "PERSONEL KAYIT EKLEME FORMU";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnkaydet;
        public System.Windows.Forms.ComboBox pcbxizin_durumu;
        public System.Windows.Forms.ComboBox pcbxbirim;
        public System.Windows.Forms.ComboBox pcbxfili_gorev;
        public System.Windows.Forms.ComboBox pcbxtayin_pozsyn;
        public System.Windows.Forms.ComboBox pcbxpzsyn;
        public System.Windows.Forms.TextBox ptxtaciklama;
        public System.Windows.Forms.TextBox ptxthizmet_suresi;
        public System.Windows.Forms.TextBox ptxtid;
        public System.Windows.Forms.TextBox ptxtadsoyad;
        private System.Windows.Forms.Button btngüncelle;
        private System.Windows.Forms.Label label1;
    }
}