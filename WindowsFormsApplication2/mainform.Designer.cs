namespace WindowsFormsApplication2
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yeniKakinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makinaListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniPersonelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personelAraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListesiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.makinaAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makinaListesiToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.personelİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniPersonelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreyiDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniÜyeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifremiDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kulid = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.kulad = new System.Windows.Forms.Label();
            this.kul_ad = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKakinaToolStripMenuItem,
            this.personelİşlemleriToolStripMenuItem,
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.adminİşlemleriToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1098, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniKakinaToolStripMenuItem
            // 
            this.yeniKakinaToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.yeniKakinaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makinaListesiToolStripMenuItem,
            this.makinaAraToolStripMenuItem,
            this.makinaListesiToolStripMenuItem1});
            this.yeniKakinaToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeniKakinaToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.Folder___MSN_M_Chatlogs;
            this.yeniKakinaToolStripMenuItem.Name = "yeniKakinaToolStripMenuItem";
            this.yeniKakinaToolStripMenuItem.Size = new System.Drawing.Size(170, 20);
            this.yeniKakinaToolStripMenuItem.Text = "MAKİNA İŞLEMLERİ";
            this.yeniKakinaToolStripMenuItem.Click += new System.EventHandler(this.yeniKakinaToolStripMenuItem_Click);
            // 
            // makinaListesiToolStripMenuItem
            // 
            this.makinaListesiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniPersonelToolStripMenuItem1,
            this.personelAraToolStripMenuItem1,
            this.personelListesiToolStripMenuItem1});
            this.makinaListesiToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.Front_Shovel;
            this.makinaListesiToolStripMenuItem.Name = "makinaListesiToolStripMenuItem";
            this.makinaListesiToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.makinaListesiToolStripMenuItem.Text = "yeni makina";
            this.makinaListesiToolStripMenuItem.Click += new System.EventHandler(this.makinaListesiToolStripMenuItem_Click);
            // 
            // yeniPersonelToolStripMenuItem1
            // 
            this.yeniPersonelToolStripMenuItem1.Name = "yeniPersonelToolStripMenuItem1";
            this.yeniPersonelToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.yeniPersonelToolStripMenuItem1.Text = "yeni personel";
            // 
            // personelAraToolStripMenuItem1
            // 
            this.personelAraToolStripMenuItem1.Image = global::WindowsFormsApplication2.Properties.Resources.Search;
            this.personelAraToolStripMenuItem1.Name = "personelAraToolStripMenuItem1";
            this.personelAraToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.personelAraToolStripMenuItem1.Text = "personel ara";
            // 
            // personelListesiToolStripMenuItem1
            // 
            this.personelListesiToolStripMenuItem1.Name = "personelListesiToolStripMenuItem1";
            this.personelListesiToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.personelListesiToolStripMenuItem1.Text = "personel listesi";
            // 
            // makinaAraToolStripMenuItem
            // 
            this.makinaAraToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.Search;
            this.makinaAraToolStripMenuItem.Name = "makinaAraToolStripMenuItem";
            this.makinaAraToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.makinaAraToolStripMenuItem.Text = "makina ara";
            this.makinaAraToolStripMenuItem.Click += new System.EventHandler(this.makinaAraToolStripMenuItem_Click);
            // 
            // makinaListesiToolStripMenuItem1
            // 
            this.makinaListesiToolStripMenuItem1.Image = global::WindowsFormsApplication2.Properties.Resources.My_Documents;
            this.makinaListesiToolStripMenuItem1.Name = "makinaListesiToolStripMenuItem1";
            this.makinaListesiToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.makinaListesiToolStripMenuItem1.Text = "makina listesi";
            this.makinaListesiToolStripMenuItem1.Click += new System.EventHandler(this.makinaListesiToolStripMenuItem1_Click);
            // 
            // personelİşlemleriToolStripMenuItem
            // 
            this.personelİşlemleriToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.personelİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniPersonelToolStripMenuItem,
            this.personelListesiToolStripMenuItem,
            this.personelAraToolStripMenuItem});
            this.personelİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personelİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("personelİşlemleriToolStripMenuItem.Image")));
            this.personelİşlemleriToolStripMenuItem.Name = "personelİşlemleriToolStripMenuItem";
            this.personelİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(187, 20);
            this.personelİşlemleriToolStripMenuItem.Text = "PERSONEL İŞLEMLERİ";
            // 
            // yeniPersonelToolStripMenuItem
            // 
            this.yeniPersonelToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources._11;
            this.yeniPersonelToolStripMenuItem.Name = "yeniPersonelToolStripMenuItem";
            this.yeniPersonelToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.yeniPersonelToolStripMenuItem.Text = "yeni personel";
            this.yeniPersonelToolStripMenuItem.Click += new System.EventHandler(this.yeniPersonelToolStripMenuItem_Click);
            // 
            // personelListesiToolStripMenuItem
            // 
            this.personelListesiToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.My_Documents;
            this.personelListesiToolStripMenuItem.Name = "personelListesiToolStripMenuItem";
            this.personelListesiToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.personelListesiToolStripMenuItem.Text = "personel listesi";
            this.personelListesiToolStripMenuItem.Click += new System.EventHandler(this.personelListesiToolStripMenuItem_Click);
            // 
            // personelAraToolStripMenuItem
            // 
            this.personelAraToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.Search;
            this.personelAraToolStripMenuItem.Name = "personelAraToolStripMenuItem";
            this.personelAraToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.personelAraToolStripMenuItem.Text = "personel ara";
            this.personelAraToolStripMenuItem.Click += new System.EventHandler(this.personelAraToolStripMenuItem_Click);
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.kullanıcıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şifreyiDeğiştirToolStripMenuItem});
            this.kullanıcıİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kullanıcıİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kullanıcıİşlemleriToolStripMenuItem.Image")));
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(197, 20);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "KULLANICI İŞLEMLERİ";
            // 
            // şifreyiDeğiştirToolStripMenuItem
            // 
            this.şifreyiDeğiştirToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.Leopard_Icon__117_;
            this.şifreyiDeğiştirToolStripMenuItem.Name = "şifreyiDeğiştirToolStripMenuItem";
            this.şifreyiDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.şifreyiDeğiştirToolStripMenuItem.Text = "şifreyi değiştir";
            this.şifreyiDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.şifreyiDeğiştirToolStripMenuItem_Click);
            // 
            // adminİşlemleriToolStripMenuItem
            // 
            this.adminİşlemleriToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.adminİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniÜyeEkleToolStripMenuItem,
            this.şifremiDeğiştirToolStripMenuItem});
            this.adminİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adminİşlemleriToolStripMenuItem.Image")));
            this.adminİşlemleriToolStripMenuItem.Name = "adminİşlemleriToolStripMenuItem";
            this.adminİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(161, 20);
            this.adminİşlemleriToolStripMenuItem.Text = "ADMİN İŞLEMLERİ";
            // 
            // yeniÜyeEkleToolStripMenuItem
            // 
            this.yeniÜyeEkleToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.User1;
            this.yeniÜyeEkleToolStripMenuItem.Name = "yeniÜyeEkleToolStripMenuItem";
            this.yeniÜyeEkleToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.yeniÜyeEkleToolStripMenuItem.Text = "yeni üye ekle";
            this.yeniÜyeEkleToolStripMenuItem.Click += new System.EventHandler(this.yeniÜyeEkleToolStripMenuItem_Click);
            // 
            // şifremiDeğiştirToolStripMenuItem
            // 
            this.şifremiDeğiştirToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.Leopard_Icon__117_;
            this.şifremiDeğiştirToolStripMenuItem.Name = "şifremiDeğiştirToolStripMenuItem";
            this.şifremiDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.şifremiDeğiştirToolStripMenuItem.Text = "şifremi değiştir";
            this.şifremiDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.şifremiDeğiştirToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.çıkışToolStripMenuItem.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.çıkışToolStripMenuItem.Image = global::WindowsFormsApplication2.Properties.Resources.iconexcel;
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.çıkışToolStripMenuItem.Text = "ÇIKIŞ";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // kulid
            // 
            this.kulid.AutoSize = true;
            this.kulid.Location = new System.Drawing.Point(1052, 7);
            this.kulid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kulid.Name = "kulid";
            this.kulid.Size = new System.Drawing.Size(46, 15);
            this.kulid.TabIndex = 1;
            this.kulid.Text = "kulid";
            this.kulid.Visible = false;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(796, 7);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(156, 17);
            this.label.TabIndex = 2;
            this.label.Text = "hoşgeldiniz sayın";
            // 
            // kulad
            // 
            this.kulad.AutoSize = true;
            this.kulad.Location = new System.Drawing.Point(867, 12);
            this.kulad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kulad.Name = "kulad";
            this.kulad.Size = new System.Drawing.Size(0, 15);
            this.kulad.TabIndex = 3;
            // 
            // kul_ad
            // 
            this.kul_ad.AutoSize = true;
            this.kul_ad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.kul_ad.Font = new System.Drawing.Font("Lucida Handwriting", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kul_ad.Location = new System.Drawing.Point(960, 5);
            this.kul_ad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kul_ad.Name = "kul_ad";
            this.kul_ad.Size = new System.Drawing.Size(64, 17);
            this.kul_ad.TabIndex = 4;
            this.kul_ad.Text = "kul_ad";
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1098, 399);
            this.Controls.Add(this.kul_ad);
            this.Controls.Add(this.kulad);
            this.Controls.Add(this.label);
            this.Controls.Add(this.kulid);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Lucida Handwriting", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "mainform";
            this.Text = "YÖNETİM EKRANI";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniKakinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makinaListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makinaAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makinaListesiToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personelİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniPersonelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniPersonelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personelAraToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem personelListesiToolStripMenuItem1;
        public System.Windows.Forms.Label kulid;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminİşlemleriToolStripMenuItem;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label kulad;
        public System.Windows.Forms.Label kul_ad;
        private System.Windows.Forms.ToolStripMenuItem şifreyiDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniÜyeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifremiDeğiştirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
    }
}