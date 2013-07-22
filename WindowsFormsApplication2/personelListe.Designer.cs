namespace WindowsFormsApplication2
{
    partial class personelListe
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(personelListe));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pozisyonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpozisyonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fgoreviDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idurumuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hyiliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniPersonelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mTSDataSet = new WindowsFormsApplication2.MTSDataSet();
            this.personelTableAdapter = new WindowsFormsApplication2.MTSDataSetTableAdapters.personelTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.isimDataGridViewTextBoxColumn,
            this.pozisyonDataGridViewTextBoxColumn,
            this.tpozisyonDataGridViewTextBoxColumn,
            this.fgoreviDataGridViewTextBoxColumn,
            this.birimiDataGridViewTextBoxColumn,
            this.idurumuDataGridViewTextBoxColumn,
            this.hyiliDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.personelBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(17, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(948, 287);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // isimDataGridViewTextBoxColumn
            // 
            this.isimDataGridViewTextBoxColumn.DataPropertyName = "isim";
            this.isimDataGridViewTextBoxColumn.HeaderText = "isim";
            this.isimDataGridViewTextBoxColumn.Name = "isimDataGridViewTextBoxColumn";
            // 
            // pozisyonDataGridViewTextBoxColumn
            // 
            this.pozisyonDataGridViewTextBoxColumn.DataPropertyName = "pozisyon";
            this.pozisyonDataGridViewTextBoxColumn.HeaderText = "pozisyon";
            this.pozisyonDataGridViewTextBoxColumn.Name = "pozisyonDataGridViewTextBoxColumn";
            // 
            // tpozisyonDataGridViewTextBoxColumn
            // 
            this.tpozisyonDataGridViewTextBoxColumn.DataPropertyName = "t_pozisyon";
            this.tpozisyonDataGridViewTextBoxColumn.HeaderText = "t_pozisyon";
            this.tpozisyonDataGridViewTextBoxColumn.Name = "tpozisyonDataGridViewTextBoxColumn";
            // 
            // fgoreviDataGridViewTextBoxColumn
            // 
            this.fgoreviDataGridViewTextBoxColumn.DataPropertyName = "f_gorevi";
            this.fgoreviDataGridViewTextBoxColumn.HeaderText = "f_gorevi";
            this.fgoreviDataGridViewTextBoxColumn.Name = "fgoreviDataGridViewTextBoxColumn";
            // 
            // birimiDataGridViewTextBoxColumn
            // 
            this.birimiDataGridViewTextBoxColumn.DataPropertyName = "birimi";
            this.birimiDataGridViewTextBoxColumn.HeaderText = "birimi";
            this.birimiDataGridViewTextBoxColumn.Name = "birimiDataGridViewTextBoxColumn";
            // 
            // idurumuDataGridViewTextBoxColumn
            // 
            this.idurumuDataGridViewTextBoxColumn.DataPropertyName = "i_durumu";
            this.idurumuDataGridViewTextBoxColumn.HeaderText = "i_durumu";
            this.idurumuDataGridViewTextBoxColumn.Name = "idurumuDataGridViewTextBoxColumn";
            // 
            // hyiliDataGridViewTextBoxColumn
            // 
            this.hyiliDataGridViewTextBoxColumn.DataPropertyName = "h_yili";
            this.hyiliDataGridViewTextBoxColumn.HeaderText = "h_yili";
            this.hyiliDataGridViewTextBoxColumn.Name = "hyiliDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.NavajoWhite;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniPersonelToolStripMenuItem,
            this.personelDüzenleToolStripMenuItem,
            this.personelSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // yeniPersonelToolStripMenuItem
            // 
            this.yeniPersonelToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeniPersonelToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources._11;
            this.yeniPersonelToolStripMenuItem.Name = "yeniPersonelToolStripMenuItem";
            this.yeniPersonelToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.yeniPersonelToolStripMenuItem.Text = "personel ekle";
            this.yeniPersonelToolStripMenuItem.Click += new System.EventHandler(this.yeniPersonelToolStripMenuItem_Click);
            // 
            // personelDüzenleToolStripMenuItem
            // 
            this.personelDüzenleToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelDüzenleToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources._001_061;
            this.personelDüzenleToolStripMenuItem.Name = "personelDüzenleToolStripMenuItem";
            this.personelDüzenleToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.personelDüzenleToolStripMenuItem.Text = "personel düzenle";
            this.personelDüzenleToolStripMenuItem.Click += new System.EventHandler(this.personelDüzenleToolStripMenuItem_Click);
            // 
            // personelSilToolStripMenuItem
            // 
            this.personelSilToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelSilToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.iconexcel;
            this.personelSilToolStripMenuItem.Name = "personelSilToolStripMenuItem";
            this.personelSilToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.personelSilToolStripMenuItem.Text = "personel sil";
            this.personelSilToolStripMenuItem.Click += new System.EventHandler(this.personelSilToolStripMenuItem_Click);
            // 
            // personelBindingSource
            // 
            this.personelBindingSource.DataMember = "personel";
            this.personelBindingSource.DataSource = this.mTSDataSet;
            // 
            // mTSDataSet
            // 
            this.mTSDataSet.DataSetName = "MTSDataSet";
            this.mTSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelTableAdapter
            // 
            this.personelTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(314, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 41;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(17, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(260, 21);
            this.checkBox1.TabIndex = 37;
            this.checkBox1.Text = "personel ismine göre arama";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(17, 127);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(276, 21);
            this.checkBox3.TabIndex = 39;
            this.checkBox3.Text = "personel görevine göre arama";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(314, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 40;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(17, 70);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(252, 21);
            this.checkBox2.TabIndex = 38;
            this.checkBox2.Text = "personel pozisyonuna göre ";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(314, 127);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(130, 20);
            this.textBox3.TabIndex = 42;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::WindowsFormsApplication2.Properties.Resources.Actualiser;
            this.button4.Location = new System.Drawing.Point(441, 221);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 43);
            this.button4.TabIndex = 44;
            this.button4.Text = "TÜM LİSTE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WindowsFormsApplication2.Properties.Resources._001_06;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(838, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 31);
            this.button1.TabIndex = 46;
            this.button1.Text = "RAPORLA";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(789, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "tüm verileri raporla";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Imprimante;
            this.pictureBox1.Location = new System.Drawing.Point(632, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(146, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication2.Properties.Resources.Search__2_;
            this.pictureBox2.Location = new System.Drawing.Point(474, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 159);
            this.pictureBox2.TabIndex = 48;
            this.pictureBox2.TabStop = false;
            // 
            // personelListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(993, 558);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "personelListe";
            this.Text = "PERSONEL İLE İLGİLİ İŞLEMLER";
            this.Load += new System.EventHandler(this.personelListe_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MTSDataSet mTSDataSet;
        private System.Windows.Forms.BindingSource personelBindingSource;
        private MTSDataSetTableAdapters.personelTableAdapter personelTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pozisyonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpozisyonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fgoreviDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idurumuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hyiliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniPersonelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelSilToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}