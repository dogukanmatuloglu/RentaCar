
namespace AracKiralam.WebFormsUI
{
    partial class AnaForm
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAracİslemleri = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMaliDurum = new System.Windows.Forms.Button();
            this.btnHareketler = new System.Windows.Forms.Button();
            this.btnAracKirala = new System.Windows.Forms.Button();
            this.pnlYeniAcılacakForm = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnAracİslemleri);
            this.pnlMenu.Controls.Add(this.button4);
            this.pnlMenu.Controls.Add(this.btnMaliDurum);
            this.pnlMenu.Controls.Add(this.btnHareketler);
            this.pnlMenu.Controls.Add(this.btnAracKirala);
            this.pnlMenu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pnlMenu.Location = new System.Drawing.Point(-2, -1);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(162, 607);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.AliceBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnExit.Location = new System.Drawing.Point(3, 333);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Çıkış";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAracİslemleri
            // 
            this.btnAracİslemleri.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAracİslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracİslemleri.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAracİslemleri.Location = new System.Drawing.Point(3, 269);
            this.btnAracİslemleri.Name = "btnAracİslemleri";
            this.btnAracİslemleri.Size = new System.Drawing.Size(152, 50);
            this.btnAracİslemleri.TabIndex = 5;
            this.btnAracİslemleri.Text = "Araç İşlemleri";
            this.btnAracİslemleri.UseVisualStyleBackColor = false;
            this.btnAracİslemleri.Click += new System.EventHandler(this.btnAracİslemleri_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.AliceBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.DarkBlue;
            this.button4.Location = new System.Drawing.Point(3, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 50);
            this.button4.TabIndex = 3;
            this.button4.Text = "Müsteri İslemleri";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMaliDurum
            // 
            this.btnMaliDurum.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMaliDurum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaliDurum.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnMaliDurum.Location = new System.Drawing.Point(3, 141);
            this.btnMaliDurum.Name = "btnMaliDurum";
            this.btnMaliDurum.Size = new System.Drawing.Size(152, 50);
            this.btnMaliDurum.TabIndex = 2;
            this.btnMaliDurum.Text = "Mali Durum";
            this.btnMaliDurum.UseVisualStyleBackColor = false;
            // 
            // btnHareketler
            // 
            this.btnHareketler.BackColor = System.Drawing.Color.AliceBlue;
            this.btnHareketler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHareketler.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnHareketler.Location = new System.Drawing.Point(3, 77);
            this.btnHareketler.Name = "btnHareketler";
            this.btnHareketler.Size = new System.Drawing.Size(152, 50);
            this.btnHareketler.TabIndex = 1;
            this.btnHareketler.Text = "Hareketler";
            this.btnHareketler.UseVisualStyleBackColor = false;
            this.btnHareketler.Click += new System.EventHandler(this.btnHareketler_Click);
            // 
            // btnAracKirala
            // 
            this.btnAracKirala.BackColor = System.Drawing.Color.AliceBlue;
            this.btnAracKirala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAracKirala.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAracKirala.Location = new System.Drawing.Point(3, 13);
            this.btnAracKirala.Name = "btnAracKirala";
            this.btnAracKirala.Size = new System.Drawing.Size(152, 50);
            this.btnAracKirala.TabIndex = 0;
            this.btnAracKirala.Text = "Araç Kirala";
            this.btnAracKirala.UseVisualStyleBackColor = false;
            this.btnAracKirala.Click += new System.EventHandler(this.btnAracKirala_Click);
            // 
            // pnlYeniAcılacakForm
            // 
            this.pnlYeniAcılacakForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlYeniAcılacakForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlYeniAcılacakForm.Location = new System.Drawing.Point(156, -1);
            this.pnlYeniAcılacakForm.Name = "pnlYeniAcılacakForm";
            this.pnlYeniAcılacakForm.Size = new System.Drawing.Size(887, 604);
            this.pnlYeniAcılacakForm.TabIndex = 1;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 604);
            this.Controls.Add(this.pnlYeniAcılacakForm);
            this.Controls.Add(this.pnlMenu);
            this.IsMdiContainer = true;
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnAracİslemleri;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMaliDurum;
        private System.Windows.Forms.Button btnHareketler;
        private System.Windows.Forms.Button btnAracKirala;
        private System.Windows.Forms.Panel pnlYeniAcılacakForm;
    }
}

