namespace WindowsFormsApplication2
{
    partial class makinaListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(makinaListe));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mtarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsinoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cyerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pisimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ppozisyonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ptpozisyonuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydıDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kaydıSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mTSDataSet1 = new WindowsFormsApplication2.MTSDataSet1();
            this.makinaTableAdapter = new WindowsFormsApplication2.MTSDataSet1TableAdapters.makinaTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.makinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Image = global::WindowsFormsApplication2.Properties.Resources.Actualiser1;
            this.button4.Location = new System.Drawing.Point(464, 220);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 42);
            this.button4.TabIndex = 43;
            this.button4.Text = "TÜM LİSTE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(1107, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 29);
            this.button2.TabIndex = 41;
            this.button2.Text = "RAPORLA";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(1107, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 31);
            this.button1.TabIndex = 38;
            this.button1.Text = "RAPORLA";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(851, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 17);
            this.label3.TabIndex = 39;
            this.label3.Text = "personel bilgilerini raporla";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(335, 70);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 20);
            this.textBox2.TabIndex = 35;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(913, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "tüm verileri raporla";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(335, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 20);
            this.textBox3.TabIndex = 36;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(12, 118);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(304, 21);
            this.checkBox3.TabIndex = 33;
            this.checkBox3.Text = "makinanın cinsi-markasına göre";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(335, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(140, 20);
            this.textBox1.TabIndex = 34;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(12, 70);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(183, 21);
            this.checkBox2.TabIndex = 32;
            this.checkBox2.Text = "tarihe göre arama";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(12, 27);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(204, 21);
            this.checkBox1.TabIndex = 31;
            this.checkBox1.Text = "DSİ no ya göre arama";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.PeachPuff;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightSalmon;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.mtarihDataGridViewTextBoxColumn,
            this.dsinoDataGridViewTextBoxColumn,
            this.markaDataGridViewTextBoxColumn,
            this.birimDataGridViewTextBoxColumn,
            this.cyerDataGridViewTextBoxColumn,
            this.aciklamaDataGridViewTextBoxColumn,
            this.pisimDataGridViewTextBoxColumn,
            this.ppozisyonDataGridViewTextBoxColumn,
            this.ptpozisyonuDataGridViewTextBoxColumn});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.DataSource = this.makinaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(78, 268);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 292);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.RowDefaultCellStyleChanged += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_RowDefaultCellStyleChanged);
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // mtarihDataGridViewTextBoxColumn
            // 
            this.mtarihDataGridViewTextBoxColumn.DataPropertyName = "mtarih";
            this.mtarihDataGridViewTextBoxColumn.HeaderText = "mtarih";
            this.mtarihDataGridViewTextBoxColumn.Name = "mtarihDataGridViewTextBoxColumn";
            // 
            // dsinoDataGridViewTextBoxColumn
            // 
            this.dsinoDataGridViewTextBoxColumn.DataPropertyName = "dsi_no";
            this.dsinoDataGridViewTextBoxColumn.HeaderText = "dsi_no";
            this.dsinoDataGridViewTextBoxColumn.Name = "dsinoDataGridViewTextBoxColumn";
            // 
            // markaDataGridViewTextBoxColumn
            // 
            this.markaDataGridViewTextBoxColumn.DataPropertyName = "marka";
            this.markaDataGridViewTextBoxColumn.HeaderText = "marka";
            this.markaDataGridViewTextBoxColumn.Name = "markaDataGridViewTextBoxColumn";
            // 
            // birimDataGridViewTextBoxColumn
            // 
            this.birimDataGridViewTextBoxColumn.DataPropertyName = "birim";
            this.birimDataGridViewTextBoxColumn.HeaderText = "birim";
            this.birimDataGridViewTextBoxColumn.Name = "birimDataGridViewTextBoxColumn";
            // 
            // cyerDataGridViewTextBoxColumn
            // 
            this.cyerDataGridViewTextBoxColumn.DataPropertyName = "c_yer";
            this.cyerDataGridViewTextBoxColumn.HeaderText = "c_yer";
            this.cyerDataGridViewTextBoxColumn.Name = "cyerDataGridViewTextBoxColumn";
            // 
            // aciklamaDataGridViewTextBoxColumn
            // 
            this.aciklamaDataGridViewTextBoxColumn.DataPropertyName = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.HeaderText = "aciklama";
            this.aciklamaDataGridViewTextBoxColumn.Name = "aciklamaDataGridViewTextBoxColumn";
            // 
            // pisimDataGridViewTextBoxColumn
            // 
            this.pisimDataGridViewTextBoxColumn.DataPropertyName = "p_isim";
            this.pisimDataGridViewTextBoxColumn.HeaderText = "p_isim";
            this.pisimDataGridViewTextBoxColumn.Name = "pisimDataGridViewTextBoxColumn";
            // 
            // ppozisyonDataGridViewTextBoxColumn
            // 
            this.ppozisyonDataGridViewTextBoxColumn.DataPropertyName = "p_pozisyon";
            this.ppozisyonDataGridViewTextBoxColumn.HeaderText = "p_pozisyon";
            this.ppozisyonDataGridViewTextBoxColumn.Name = "ppozisyonDataGridViewTextBoxColumn";
            // 
            // ptpozisyonuDataGridViewTextBoxColumn
            // 
            this.ptpozisyonuDataGridViewTextBoxColumn.DataPropertyName = "p_t_pozisyonu";
            this.ptpozisyonuDataGridViewTextBoxColumn.HeaderText = "p_t_pozisyonu";
            this.ptpozisyonuDataGridViewTextBoxColumn.Name = "ptpozisyonuDataGridViewTextBoxColumn";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.NavajoWhite;
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKayıtToolStripMenuItem,
            this.kaydıDüzenleToolStripMenuItem,
            this.kaydıSilToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(186, 70);
            // 
            // yeniKayıtToolStripMenuItem
            // 
            this.yeniKayıtToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeniKayıtToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources._11;
            this.yeniKayıtToolStripMenuItem.Name = "yeniKayıtToolStripMenuItem";
            this.yeniKayıtToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.yeniKayıtToolStripMenuItem.Text = "yeni kayıt";
            this.yeniKayıtToolStripMenuItem.Click += new System.EventHandler(this.yeniKayıtToolStripMenuItem_Click);
            // 
            // kaydıDüzenleToolStripMenuItem
            // 
            this.kaydıDüzenleToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaydıDüzenleToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources._001_06;
            this.kaydıDüzenleToolStripMenuItem.Name = "kaydıDüzenleToolStripMenuItem";
            this.kaydıDüzenleToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.kaydıDüzenleToolStripMenuItem.Text = "kaydı düzenle";
            this.kaydıDüzenleToolStripMenuItem.Click += new System.EventHandler(this.kaydıDüzenleToolStripMenuItem_Click);
            // 
            // kaydıSilToolStripMenuItem
            // 
            this.kaydıSilToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kaydıSilToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.iconexcel;
            this.kaydıSilToolStripMenuItem.Name = "kaydıSilToolStripMenuItem";
            this.kaydıSilToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.kaydıSilToolStripMenuItem.Text = "kaydı sil";
            this.kaydıSilToolStripMenuItem.Click += new System.EventHandler(this.kaydıSilToolStripMenuItem_Click);
            // 
            // makinaBindingSource
            // 
            this.makinaBindingSource.DataMember = "makina";
            this.makinaBindingSource.DataSource = this.mTSDataSet1;
            // 
            // mTSDataSet1
            // 
            this.mTSDataSet1.DataSetName = "MTSDataSet1";
            this.mTSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // makinaTableAdapter
            // 
            this.makinaTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApplication2.Properties.Resources.Imprimante;
            this.pictureBox1.Location = new System.Drawing.Point(669, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(187, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 45;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WindowsFormsApplication2.Properties.Resources.Search__2_;
            this.pictureBox2.Location = new System.Drawing.Point(481, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(165, 166);
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // makinaListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1199, 600);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "makinaListe";
            this.Text = "MAKİNALARLA İLGİLİ İŞLEMLER";
            this.Load += new System.EventHandler(this.makinaListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.makinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private MTSDataSet1 mTSDataSet1;
        private System.Windows.Forms.BindingSource makinaBindingSource;
        private MTSDataSet1TableAdapters.makinaTableAdapter makinaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mtarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsinoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cyerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pisimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ppozisyonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ptpozisyonuDataGridViewTextBoxColumn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydıDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kaydıSilToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}