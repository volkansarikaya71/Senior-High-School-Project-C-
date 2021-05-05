namespace Volkan_SARIKAYA
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.değişkenlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veriTürleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.intToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doubleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.charToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatörlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aritmetikselOperatörlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cıkarmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carpmaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.isleclerVeTürleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(2, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(705, 147);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SONUC";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(179, 260);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(373, 20);
            this.textBox1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.değişkenlerToolStripMenuItem,
            this.veriTürleriToolStripMenuItem,
            this.operatörlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // değişkenlerToolStripMenuItem
            // 
            this.değişkenlerToolStripMenuItem.Name = "değişkenlerToolStripMenuItem";
            this.değişkenlerToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.değişkenlerToolStripMenuItem.Text = "Değişkenler";
            this.değişkenlerToolStripMenuItem.Click += new System.EventHandler(this.değişkenlerToolStripMenuItem_Click);
            // 
            // veriTürleriToolStripMenuItem
            // 
            this.veriTürleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.intToolStripMenuItem,
            this.stringToolStripMenuItem,
            this.doubleToolStripMenuItem,
            this.charToolStripMenuItem});
            this.veriTürleriToolStripMenuItem.Name = "veriTürleriToolStripMenuItem";
            this.veriTürleriToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.veriTürleriToolStripMenuItem.Text = "Veri Türleri";
            this.veriTürleriToolStripMenuItem.Click += new System.EventHandler(this.veriTürleriToolStripMenuItem_Click);
            // 
            // intToolStripMenuItem
            // 
            this.intToolStripMenuItem.Name = "intToolStripMenuItem";
            this.intToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.intToolStripMenuItem.Text = "İnt";
            this.intToolStripMenuItem.Click += new System.EventHandler(this.intToolStripMenuItem_Click);
            // 
            // stringToolStripMenuItem
            // 
            this.stringToolStripMenuItem.Name = "stringToolStripMenuItem";
            this.stringToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stringToolStripMenuItem.Text = "String";
            this.stringToolStripMenuItem.Click += new System.EventHandler(this.stringToolStripMenuItem_Click);
            // 
            // doubleToolStripMenuItem
            // 
            this.doubleToolStripMenuItem.Name = "doubleToolStripMenuItem";
            this.doubleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.doubleToolStripMenuItem.Text = "Double";
            this.doubleToolStripMenuItem.Click += new System.EventHandler(this.doubleToolStripMenuItem_Click);
            // 
            // charToolStripMenuItem
            // 
            this.charToolStripMenuItem.Name = "charToolStripMenuItem";
            this.charToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.charToolStripMenuItem.Text = "Char";
            this.charToolStripMenuItem.Click += new System.EventHandler(this.charToolStripMenuItem_Click);
            // 
            // operatörlerToolStripMenuItem
            // 
            this.operatörlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aritmetikselOperatörlerToolStripMenuItem,
            this.isleclerVeTürleriToolStripMenuItem});
            this.operatörlerToolStripMenuItem.Name = "operatörlerToolStripMenuItem";
            this.operatörlerToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.operatörlerToolStripMenuItem.Text = "Operatörler";
            this.operatörlerToolStripMenuItem.Click += new System.EventHandler(this.operatörlerToolStripMenuItem_Click);
            // 
            // aritmetikselOperatörlerToolStripMenuItem
            // 
            this.aritmetikselOperatörlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toplamaToolStripMenuItem,
            this.cıkarmaToolStripMenuItem,
            this.carpmaToolStripMenuItem,
            this.bölmeToolStripMenuItem});
            this.aritmetikselOperatörlerToolStripMenuItem.Name = "aritmetikselOperatörlerToolStripMenuItem";
            this.aritmetikselOperatörlerToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.aritmetikselOperatörlerToolStripMenuItem.Text = "Aritmetiksel Operatörler";
            this.aritmetikselOperatörlerToolStripMenuItem.Click += new System.EventHandler(this.aritmetikselOperatörlerToolStripMenuItem_Click);
            // 
            // toplamaToolStripMenuItem
            // 
            this.toplamaToolStripMenuItem.Name = "toplamaToolStripMenuItem";
            this.toplamaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.toplamaToolStripMenuItem.Text = "Toplama";
            this.toplamaToolStripMenuItem.Click += new System.EventHandler(this.toplamaToolStripMenuItem_Click);
            // 
            // cıkarmaToolStripMenuItem
            // 
            this.cıkarmaToolStripMenuItem.Name = "cıkarmaToolStripMenuItem";
            this.cıkarmaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cıkarmaToolStripMenuItem.Text = "Cıkarma";
            this.cıkarmaToolStripMenuItem.Click += new System.EventHandler(this.cıkarmaToolStripMenuItem_Click);
            // 
            // carpmaToolStripMenuItem
            // 
            this.carpmaToolStripMenuItem.Name = "carpmaToolStripMenuItem";
            this.carpmaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.carpmaToolStripMenuItem.Text = "Carpma";
            this.carpmaToolStripMenuItem.Click += new System.EventHandler(this.carpmaToolStripMenuItem_Click);
            // 
            // bölmeToolStripMenuItem
            // 
            this.bölmeToolStripMenuItem.Name = "bölmeToolStripMenuItem";
            this.bölmeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bölmeToolStripMenuItem.Text = "Bölme";
            this.bölmeToolStripMenuItem.Click += new System.EventHandler(this.bölmeToolStripMenuItem_Click);
            // 
            // isleclerVeTürleriToolStripMenuItem
            // 
            this.isleclerVeTürleriToolStripMenuItem.Name = "isleclerVeTürleriToolStripMenuItem";
            this.isleclerVeTürleriToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.isleclerVeTürleriToolStripMenuItem.Text = "İslecler ve Türleri";
            this.isleclerVeTürleriToolStripMenuItem.Click += new System.EventHandler(this.isleclerVeTürleriToolStripMenuItem_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(440, 317);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(267, 47);
            this.axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 288);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem değişkenlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veriTürleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem intToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doubleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem charToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatörlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aritmetikselOperatörlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toplamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cıkarmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carpmaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem isleclerVeTürleriToolStripMenuItem;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

