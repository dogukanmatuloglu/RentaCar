
namespace AracKiralam.WebFormsUI
{
    partial class Aracİslemleri
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
            this.dgwAracİslemleri = new System.Windows.Forms.DataGridView();
            this.gbxEkle = new System.Windows.Forms.GroupBox();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.tbxPlaka = new System.Windows.Forms.TextBox();
            this.tbxKilometre = new System.Windows.Forms.TextBox();
            this.tbxYıl = new System.Windows.Forms.TextBox();
            this.tbxModel = new System.Windows.Forms.TextBox();
            this.tbxMarka = new System.Windows.Forms.TextBox();
            this.lblPlaka = new System.Windows.Forms.Label();
            this.lblKilomtere = new System.Windows.Forms.Label();
            this.lblYıl = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.gbxGüncelle = new System.Windows.Forms.GroupBox();
            this.tbxGuncelleId = new System.Windows.Forms.TextBox();
            this.lblGunclelleId = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.tbxGüncellePlaka = new System.Windows.Forms.TextBox();
            this.tbxGüncelleKilometre = new System.Windows.Forms.TextBox();
            this.tbxGüncelleYıl = new System.Windows.Forms.TextBox();
            this.tbxGüncelleModel = new System.Windows.Forms.TextBox();
            this.tbxGüncelleMarka = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGüncelleModel = new System.Windows.Forms.Label();
            this.lblGüncelleMarka = new System.Windows.Forms.Label();
            this.gbxAracSil = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAracİslemleri)).BeginInit();
            this.gbxEkle.SuspendLayout();
            this.gbxGüncelle.SuspendLayout();
            this.gbxAracSil.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwAracİslemleri
            // 
            this.dgwAracİslemleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAracİslemleri.Location = new System.Drawing.Point(12, 12);
            this.dgwAracİslemleri.Name = "dgwAracİslemleri";
            this.dgwAracİslemleri.RowHeadersWidth = 51;
            this.dgwAracİslemleri.RowTemplate.Height = 24;
            this.dgwAracİslemleri.Size = new System.Drawing.Size(869, 182);
            this.dgwAracİslemleri.TabIndex = 0;
            this.dgwAracİslemleri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwAracİslemleri_CellContentClick);
            // 
            // gbxEkle
            // 
            this.gbxEkle.Controls.Add(this.btnAracEkle);
            this.gbxEkle.Controls.Add(this.tbxPlaka);
            this.gbxEkle.Controls.Add(this.tbxKilometre);
            this.gbxEkle.Controls.Add(this.tbxYıl);
            this.gbxEkle.Controls.Add(this.tbxModel);
            this.gbxEkle.Controls.Add(this.tbxMarka);
            this.gbxEkle.Controls.Add(this.lblPlaka);
            this.gbxEkle.Controls.Add(this.lblKilomtere);
            this.gbxEkle.Controls.Add(this.lblYıl);
            this.gbxEkle.Controls.Add(this.lblModel);
            this.gbxEkle.Controls.Add(this.lblMarka);
            this.gbxEkle.Location = new System.Drawing.Point(13, 221);
            this.gbxEkle.Name = "gbxEkle";
            this.gbxEkle.Size = new System.Drawing.Size(237, 269);
            this.gbxEkle.TabIndex = 1;
            this.gbxEkle.TabStop = false;
            this.gbxEkle.Text = "Araç Ekle";
            // 
            // btnAracEkle
            // 
            this.btnAracEkle.Location = new System.Drawing.Point(95, 178);
            this.btnAracEkle.Name = "btnAracEkle";
            this.btnAracEkle.Size = new System.Drawing.Size(100, 28);
            this.btnAracEkle.TabIndex = 10;
            this.btnAracEkle.Text = "Ekle";
            this.btnAracEkle.UseVisualStyleBackColor = true;
            this.btnAracEkle.Click += new System.EventHandler(this.btnAracEkle_Click);
            // 
            // tbxPlaka
            // 
            this.tbxPlaka.Location = new System.Drawing.Point(95, 150);
            this.tbxPlaka.Name = "tbxPlaka";
            this.tbxPlaka.Size = new System.Drawing.Size(100, 22);
            this.tbxPlaka.TabIndex = 9;
            // 
            // tbxKilometre
            // 
            this.tbxKilometre.Location = new System.Drawing.Point(95, 119);
            this.tbxKilometre.Name = "tbxKilometre";
            this.tbxKilometre.Size = new System.Drawing.Size(100, 22);
            this.tbxKilometre.TabIndex = 8;
            // 
            // tbxYıl
            // 
            this.tbxYıl.Location = new System.Drawing.Point(95, 90);
            this.tbxYıl.Name = "tbxYıl";
            this.tbxYıl.Size = new System.Drawing.Size(100, 22);
            this.tbxYıl.TabIndex = 7;
            // 
            // tbxModel
            // 
            this.tbxModel.Location = new System.Drawing.Point(95, 59);
            this.tbxModel.Name = "tbxModel";
            this.tbxModel.Size = new System.Drawing.Size(100, 22);
            this.tbxModel.TabIndex = 6;
            // 
            // tbxMarka
            // 
            this.tbxMarka.Location = new System.Drawing.Point(95, 30);
            this.tbxMarka.Name = "tbxMarka";
            this.tbxMarka.Size = new System.Drawing.Size(100, 22);
            this.tbxMarka.TabIndex = 5;
            // 
            // lblPlaka
            // 
            this.lblPlaka.AutoSize = true;
            this.lblPlaka.Location = new System.Drawing.Point(15, 150);
            this.lblPlaka.Name = "lblPlaka";
            this.lblPlaka.Size = new System.Drawing.Size(43, 17);
            this.lblPlaka.TabIndex = 4;
            this.lblPlaka.Text = "Plaka";
            // 
            // lblKilomtere
            // 
            this.lblKilomtere.Location = new System.Drawing.Point(15, 120);
            this.lblKilomtere.Name = "lblKilomtere";
            this.lblKilomtere.Size = new System.Drawing.Size(100, 23);
            this.lblKilomtere.TabIndex = 3;
            this.lblKilomtere.Text = "Kilometre";
            // 
            // lblYıl
            // 
            this.lblYıl.AutoSize = true;
            this.lblYıl.Location = new System.Drawing.Point(15, 90);
            this.lblYıl.Name = "lblYıl";
            this.lblYıl.Size = new System.Drawing.Size(23, 17);
            this.lblYıl.TabIndex = 2;
            this.lblYıl.Text = "Yıl";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(15, 60);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(46, 17);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(15, 30);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(47, 17);
            this.lblMarka.TabIndex = 0;
            this.lblMarka.Text = "Marka";
            // 
            // gbxGüncelle
            // 
            this.gbxGüncelle.Controls.Add(this.tbxGuncelleId);
            this.gbxGüncelle.Controls.Add(this.lblGunclelleId);
            this.gbxGüncelle.Controls.Add(this.btnGüncelle);
            this.gbxGüncelle.Controls.Add(this.tbxGüncellePlaka);
            this.gbxGüncelle.Controls.Add(this.tbxGüncelleKilometre);
            this.gbxGüncelle.Controls.Add(this.tbxGüncelleYıl);
            this.gbxGüncelle.Controls.Add(this.tbxGüncelleModel);
            this.gbxGüncelle.Controls.Add(this.tbxGüncelleMarka);
            this.gbxGüncelle.Controls.Add(this.label1);
            this.gbxGüncelle.Controls.Add(this.label2);
            this.gbxGüncelle.Controls.Add(this.label3);
            this.gbxGüncelle.Controls.Add(this.lblGüncelleModel);
            this.gbxGüncelle.Controls.Add(this.lblGüncelleMarka);
            this.gbxGüncelle.Location = new System.Drawing.Point(274, 221);
            this.gbxGüncelle.Name = "gbxGüncelle";
            this.gbxGüncelle.Size = new System.Drawing.Size(237, 269);
            this.gbxGüncelle.TabIndex = 11;
            this.gbxGüncelle.TabStop = false;
            this.gbxGüncelle.Text = "Araç Güncelle";
            // 
            // tbxGuncelleId
            // 
            this.tbxGuncelleId.Location = new System.Drawing.Point(99, 31);
            this.tbxGuncelleId.Name = "tbxGuncelleId";
            this.tbxGuncelleId.Size = new System.Drawing.Size(100, 22);
            this.tbxGuncelleId.TabIndex = 12;
            // 
            // lblGunclelleId
            // 
            this.lblGunclelleId.AutoSize = true;
            this.lblGunclelleId.Location = new System.Drawing.Point(22, 29);
            this.lblGunclelleId.Name = "lblGunclelleId";
            this.lblGunclelleId.Size = new System.Drawing.Size(19, 17);
            this.lblGunclelleId.TabIndex = 11;
            this.lblGunclelleId.Text = "Id";
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(99, 207);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(100, 28);
            this.btnGüncelle.TabIndex = 10;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // tbxGüncellePlaka
            // 
            this.tbxGüncellePlaka.Location = new System.Drawing.Point(99, 179);
            this.tbxGüncellePlaka.Name = "tbxGüncellePlaka";
            this.tbxGüncellePlaka.Size = new System.Drawing.Size(100, 22);
            this.tbxGüncellePlaka.TabIndex = 9;
            // 
            // tbxGüncelleKilometre
            // 
            this.tbxGüncelleKilometre.Location = new System.Drawing.Point(99, 148);
            this.tbxGüncelleKilometre.Name = "tbxGüncelleKilometre";
            this.tbxGüncelleKilometre.Size = new System.Drawing.Size(100, 22);
            this.tbxGüncelleKilometre.TabIndex = 8;
            // 
            // tbxGüncelleYıl
            // 
            this.tbxGüncelleYıl.Location = new System.Drawing.Point(99, 119);
            this.tbxGüncelleYıl.Name = "tbxGüncelleYıl";
            this.tbxGüncelleYıl.Size = new System.Drawing.Size(100, 22);
            this.tbxGüncelleYıl.TabIndex = 7;
            // 
            // tbxGüncelleModel
            // 
            this.tbxGüncelleModel.Location = new System.Drawing.Point(99, 88);
            this.tbxGüncelleModel.Name = "tbxGüncelleModel";
            this.tbxGüncelleModel.Size = new System.Drawing.Size(100, 22);
            this.tbxGüncelleModel.TabIndex = 6;
            // 
            // tbxGüncelleMarka
            // 
            this.tbxGüncelleMarka.Location = new System.Drawing.Point(99, 59);
            this.tbxGüncelleMarka.Name = "tbxGüncelleMarka";
            this.tbxGüncelleMarka.Size = new System.Drawing.Size(100, 22);
            this.tbxGüncelleMarka.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kilometre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Yıl";
            // 
            // lblGüncelleModel
            // 
            this.lblGüncelleModel.AutoSize = true;
            this.lblGüncelleModel.Location = new System.Drawing.Point(19, 89);
            this.lblGüncelleModel.Name = "lblGüncelleModel";
            this.lblGüncelleModel.Size = new System.Drawing.Size(46, 17);
            this.lblGüncelleModel.TabIndex = 1;
            this.lblGüncelleModel.Text = "Model";
            // 
            // lblGüncelleMarka
            // 
            this.lblGüncelleMarka.AutoSize = true;
            this.lblGüncelleMarka.Location = new System.Drawing.Point(19, 59);
            this.lblGüncelleMarka.Name = "lblGüncelleMarka";
            this.lblGüncelleMarka.Size = new System.Drawing.Size(47, 17);
            this.lblGüncelleMarka.TabIndex = 0;
            this.lblGüncelleMarka.Text = "Marka";
            // 
            // gbxAracSil
            // 
            this.gbxAracSil.Controls.Add(this.btnSil);
            this.gbxAracSil.Controls.Add(this.label4);
            this.gbxAracSil.Location = new System.Drawing.Point(534, 221);
            this.gbxAracSil.Name = "gbxAracSil";
            this.gbxAracSil.Size = new System.Drawing.Size(298, 269);
            this.gbxAracSil.TabIndex = 12;
            this.gbxAracSil.TabStop = false;
            this.gbxAracSil.Text = "Araç Sil";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(176, 60);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 27);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Silmek İstediğiniz Aracı Listeden Seçiniz";
            // 
            // Aracİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 557);
            this.Controls.Add(this.gbxAracSil);
            this.Controls.Add(this.gbxGüncelle);
            this.Controls.Add(this.gbxEkle);
            this.Controls.Add(this.dgwAracİslemleri);
            this.Name = "Aracİslemleri";
            this.Text = "Aracİslemleri";
            this.Load += new System.EventHandler(this.Aracİslemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwAracİslemleri)).EndInit();
            this.gbxEkle.ResumeLayout(false);
            this.gbxEkle.PerformLayout();
            this.gbxGüncelle.ResumeLayout(false);
            this.gbxGüncelle.PerformLayout();
            this.gbxAracSil.ResumeLayout(false);
            this.gbxAracSil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwAracİslemleri;
        private System.Windows.Forms.GroupBox gbxEkle;
        private System.Windows.Forms.Label lblPlaka;
        private System.Windows.Forms.Label lblKilomtere;
        private System.Windows.Forms.Label lblYıl;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.TextBox tbxPlaka;
        private System.Windows.Forms.TextBox tbxKilometre;
        private System.Windows.Forms.TextBox tbxYıl;
        private System.Windows.Forms.TextBox tbxModel;
        private System.Windows.Forms.TextBox tbxMarka;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.GroupBox gbxGüncelle;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox tbxGüncellePlaka;
        private System.Windows.Forms.TextBox tbxGüncelleKilometre;
        private System.Windows.Forms.TextBox tbxGüncelleYıl;
        private System.Windows.Forms.TextBox tbxGüncelleModel;
        private System.Windows.Forms.TextBox tbxGüncelleMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGüncelleModel;
        private System.Windows.Forms.Label lblGüncelleMarka;
        private System.Windows.Forms.TextBox tbxGuncelleId;
        private System.Windows.Forms.Label lblGunclelleId;
        private System.Windows.Forms.GroupBox gbxAracSil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label4;
    }
}