namespace P3D
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.taskbar = new System.Windows.Forms.Panel();
            this.haritabuton = new System.Windows.Forms.PictureBox();
            this.panelgizle = new System.Windows.Forms.PictureBox();
            this.panelcenter = new System.Windows.Forms.Panel();
            this.kuzey = new System.Windows.Forms.Label();
            this.pusula = new System.Windows.Forms.PictureBox();
            this.ayarac = new System.Windows.Forms.PictureBox();
            this.chatac = new System.Windows.Forms.PictureBox();
            this.menuac = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.Panel();
            this.alan = new System.Windows.Forms.PictureBox();
            this.harita = new System.Windows.Forms.Panel();
            this.haritaresim = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.taskbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.haritabuton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelgizle)).BeginInit();
            this.panelcenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pusula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayarac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuac)).BeginInit();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alan)).BeginInit();
            this.harita.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.haritaresim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // taskbar
            // 
            this.taskbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.taskbar.Controls.Add(this.haritabuton);
            this.taskbar.Controls.Add(this.panelgizle);
            this.taskbar.Controls.Add(this.panelcenter);
            this.taskbar.Location = new System.Drawing.Point(0, 0);
            this.taskbar.Name = "taskbar";
            this.taskbar.Size = new System.Drawing.Size(1000, 75);
            this.taskbar.TabIndex = 0;
            // 
            // haritabuton
            // 
            this.haritabuton.BackColor = System.Drawing.Color.Red;
            this.haritabuton.Dock = System.Windows.Forms.DockStyle.Left;
            this.haritabuton.Location = new System.Drawing.Point(0, 0);
            this.haritabuton.Name = "haritabuton";
            this.haritabuton.Size = new System.Drawing.Size(75, 75);
            this.haritabuton.TabIndex = 3;
            this.haritabuton.TabStop = false;
            this.haritabuton.Click += new System.EventHandler(this.haritabuton_Click);
            // 
            // panelgizle
            // 
            this.panelgizle.BackColor = System.Drawing.Color.Red;
            this.panelgizle.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelgizle.Location = new System.Drawing.Point(925, 0);
            this.panelgizle.Name = "panelgizle";
            this.panelgizle.Size = new System.Drawing.Size(75, 75);
            this.panelgizle.TabIndex = 2;
            this.panelgizle.TabStop = false;
            this.panelgizle.Click += new System.EventHandler(this.panelgizle_Click);
            // 
            // panelcenter
            // 
            this.panelcenter.BackColor = System.Drawing.Color.Transparent;
            this.panelcenter.Controls.Add(this.kuzey);
            this.panelcenter.Controls.Add(this.pusula);
            this.panelcenter.Controls.Add(this.ayarac);
            this.panelcenter.Controls.Add(this.chatac);
            this.panelcenter.Controls.Add(this.menuac);
            this.panelcenter.Location = new System.Drawing.Point(330, 0);
            this.panelcenter.Margin = new System.Windows.Forms.Padding(0);
            this.panelcenter.Name = "panelcenter";
            this.panelcenter.Size = new System.Drawing.Size(316, 75);
            this.panelcenter.TabIndex = 1;
            this.panelcenter.Paint += new System.Windows.Forms.PaintEventHandler(this.panelcenter_Paint);
            // 
            // kuzey
            // 
            this.kuzey.AutoSize = true;
            this.kuzey.BackColor = System.Drawing.Color.White;
            this.kuzey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.kuzey.ForeColor = System.Drawing.Color.Black;
            this.kuzey.Location = new System.Drawing.Point(25, 0);
            this.kuzey.Name = "kuzey";
            this.kuzey.Size = new System.Drawing.Size(20, 20);
            this.kuzey.TabIndex = 8;
            this.kuzey.Text = "K";
            // 
            // pusula
            // 
            this.pusula.BackColor = System.Drawing.Color.White;
            this.pusula.Location = new System.Drawing.Point(-2, 0);
            this.pusula.Name = "pusula";
            this.pusula.Size = new System.Drawing.Size(75, 75);
            this.pusula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pusula.TabIndex = 3;
            this.pusula.TabStop = false;
            // 
            // ayarac
            // 
            this.ayarac.BackColor = System.Drawing.Color.Wheat;
            this.ayarac.Location = new System.Drawing.Point(79, 0);
            this.ayarac.Name = "ayarac";
            this.ayarac.Size = new System.Drawing.Size(75, 75);
            this.ayarac.TabIndex = 2;
            this.ayarac.TabStop = false;
            // 
            // chatac
            // 
            this.chatac.BackColor = System.Drawing.Color.Violet;
            this.chatac.Location = new System.Drawing.Point(160, 0);
            this.chatac.Name = "chatac";
            this.chatac.Size = new System.Drawing.Size(75, 75);
            this.chatac.TabIndex = 1;
            this.chatac.TabStop = false;
            // 
            // menuac
            // 
            this.menuac.BackColor = System.Drawing.Color.Turquoise;
            this.menuac.Location = new System.Drawing.Point(241, 0);
            this.menuac.Name = "menuac";
            this.menuac.Size = new System.Drawing.Size(75, 75);
            this.menuac.TabIndex = 0;
            this.menuac.TabStop = false;
            this.menuac.Click += new System.EventHandler(this.menuac_Click);
            // 
            // menu
            // 
            this.menu.Controls.Add(this.pictureBox5);
            this.menu.Controls.Add(this.pictureBox3);
            this.menu.Controls.Add(this.pictureBox2);
            this.menu.Controls.Add(this.pictureBox1);
            this.menu.Location = new System.Drawing.Point(300, 81);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(400, 400);
            this.menu.TabIndex = 2;
            this.menu.Visible = false;
            // 
            // alan
            // 
            this.alan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.alan.Image = ((System.Drawing.Image)(resources.GetObject("alan.Image")));
            this.alan.Location = new System.Drawing.Point(0, 0);
            this.alan.Name = "alan";
            this.alan.Size = new System.Drawing.Size(10000, 1080);
            this.alan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.alan.TabIndex = 1;
            this.alan.TabStop = false;
            this.alan.Click += new System.EventHandler(this.alan_Click);
            // 
            // harita
            // 
            this.harita.Controls.Add(this.haritaresim);
            this.harita.Location = new System.Drawing.Point(14, 81);
            this.harita.Name = "harita";
            this.harita.Size = new System.Drawing.Size(400, 200);
            this.harita.TabIndex = 3;
            this.harita.Visible = false;
            // 
            // haritaresim
            // 
            this.haritaresim.Location = new System.Drawing.Point(3, 3);
            this.haritaresim.Name = "haritaresim";
            this.haritaresim.Size = new System.Drawing.Size(394, 194);
            this.haritaresim.TabIndex = 0;
            this.haritaresim.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Violet;
            this.pictureBox1.Location = new System.Drawing.Point(117, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 75);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Violet;
            this.pictureBox2.Location = new System.Drawing.Point(217, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Violet;
            this.pictureBox3.Location = new System.Drawing.Point(322, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 75);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Violet;
            this.pictureBox5.Location = new System.Drawing.Point(3, 13);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 75);
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.harita);
            this.Controls.Add(this.taskbar);
            this.Controls.Add(this.alan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pcontum 3D";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.taskbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.haritabuton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelgizle)).EndInit();
            this.panelcenter.ResumeLayout(false);
            this.panelcenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pusula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ayarac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chatac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuac)).EndInit();
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.alan)).EndInit();
            this.harita.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.haritaresim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel taskbar;
        private System.Windows.Forms.Panel panelcenter;
        private System.Windows.Forms.PictureBox panelgizle;
        private System.Windows.Forms.PictureBox haritabuton;
        private System.Windows.Forms.PictureBox pusula;
        private System.Windows.Forms.PictureBox ayarac;
        private System.Windows.Forms.PictureBox chatac;
        private System.Windows.Forms.PictureBox menuac;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Label kuzey;
        private System.Windows.Forms.PictureBox alan;
        private System.Windows.Forms.Panel harita;
        private System.Windows.Forms.PictureBox haritaresim;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

