
namespace AracKiralam.WebFormsUI
{
    partial class MusteriIslemleri
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
            this.gbxAracSil = new System.Windows.Forms.GroupBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gbxGüncelle = new System.Windows.Forms.GroupBox();
            this.tbxGuncelleId = new System.Windows.Forms.TextBox();
            this.lblGunclelleId = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.tbxGüncelleAdres = new System.Windows.Forms.TextBox();
            this.tbxGüncelletckno = new System.Windows.Forms.TextBox();
            this.tbxGüncelleSoıyad = new System.Windows.Forms.TextBox();
            this.tbxGüncelleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblGüncelleModel = new System.Windows.Forms.Label();
            this.lblGüncelleMarka = new System.Windows.Forms.Label();
            this.gbxEkle = new System.Windows.Forms.GroupBox();
            this.btnAracEkle = new System.Windows.Forms.Button();
            this.adres = new System.Windows.Forms.TextBox();
            this.tckno = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.lblKilomtere = new System.Windows.Forms.Label();
            this.lblYıl = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.dgwAracİslemleri = new System.Windows.Forms.DataGridView();
            this.gbxAracSil.SuspendLayout();
            this.gbxGüncelle.SuspendLayout();
            this.gbxEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAracİslemleri)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxAracSil
            // 
            this.gbxAracSil.Controls.Add(this.btnSil);
            this.gbxAracSil.Controls.Add(this.label4);
            this.gbxAracSil.Location = new System.Drawing.Point(541, 258);
            this.gbxAracSil.Name = "gbxAracSil";
            this.gbxAracSil.Size = new System.Drawing.Size(298, 269);
            this.gbxAracSil.TabIndex = 16;
            this.gbxAracSil.TabStop = false;
            this.gbxAracSil.Text = "Müşteri Sil";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(176, 60);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(100, 27);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(282, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Silmek İstediğiniz Müşteriyi Listeden Seçiniz";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // gbxGüncelle
            // 
            this.gbxGüncelle.Controls.Add(this.tbxGuncelleId);
            this.gbxGüncelle.Controls.Add(this.lblGunclelleId);
            this.gbxGüncelle.Controls.Add(this.btnGüncelle);
            this.gbxGüncelle.Controls.Add(this.tbxGüncelleAdres);
            this.gbxGüncelle.Controls.Add(this.tbxGüncelletckno);
            this.gbxGüncelle.Controls.Add(this.tbxGüncelleSoıyad);
            this.gbxGüncelle.Controls.Add(this.tbxGüncelleName);
            this.gbxGüncelle.Controls.Add(this.label2);
            this.gbxGüncelle.Controls.Add(this.label3);
            this.gbxGüncelle.Controls.Add(this.lblGüncelleModel);
            this.gbxGüncelle.Controls.Add(this.lblGüncelleMarka);
            this.gbxGüncelle.Location = new System.Drawing.Point(281, 258);
            this.gbxGüncelle.Name = "gbxGüncelle";
            this.gbxGüncelle.Size = new System.Drawing.Size(237, 269);
            this.gbxGüncelle.TabIndex = 15;
            this.gbxGüncelle.TabStop = false;
            this.gbxGüncelle.Text = "Müşteri Güncelle";
            // 
            // tbxGuncelleId
            // 
            this.tbxGuncelleId.Location = new System.Drawing.Point(99, 31);
            this.tbxGuncelleId.Name = "tbxGuncelleId";
            this.tbxGuncelleId.Size = new System.Drawing.Size(100, 22);
            this.tbxGuncelleId.TabIndex = 12;
            this.tbxGuncelleId.TextChanged += new System.EventHandler(this.tbxGuncelleId_TextChanged);
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
            // 
            // tbxGüncelleAdres
            // 
            this.tbxGüncelleAdres.Location = new System.Drawing.Point(99, 148);
            this.tbxGüncelleAdres.Name = "tbxGüncelleAdres";
            this.tbxGüncelleAdres.Size = new System.Drawing.Size(100, 22);
            this.tbxGüncelleAdres.TabIndex = 8;
            // 
            // tbxGüncelletckno
            // 
            this.tbxGüncelletckno.Location = new System.Drawing.Point(99, 119);
            this.tbxGüncelletckno.Name = "tbxGüncelletckno";
            this.tbxGüncelletckno.Size = new System.Drawing.Size(100, 22);
            this.tbxGüncelletckno.TabIndex = 7;
            // 
            // tbxGüncelleSoıyad
            // 
            this.tbxGüncelleSoıyad.Location = new System.Drawing.Point(99, 88);
            this.tbxGüncelleSoıyad.Name = "tbxGüncelleSoıyad";
            this.tbxGüncelleSoıyad.Size = new System.Drawing.Size(100, 22);
            this.tbxGüncelleSoıyad.TabIndex = 6;
            // 
            // tbxGüncelleName
            // 
            this.tbxGüncelleName.Location = new System.Drawing.Point(99, 59);
            this.tbxGüncelleName.Name = "tbxGüncelleName";
            this.tbxGüncelleName.Size = new System.Drawing.Size(100, 22);
            this.tbxGüncelleName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(19, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tckno";
            // 
            // lblGüncelleModel
            // 
            this.lblGüncelleModel.AutoSize = true;
            this.lblGüncelleModel.Location = new System.Drawing.Point(19, 89);
            this.lblGüncelleModel.Name = "lblGüncelleModel";
            this.lblGüncelleModel.Size = new System.Drawing.Size(48, 17);
            this.lblGüncelleModel.TabIndex = 1;
            this.lblGüncelleModel.Text = "Soyad";
            // 
            // lblGüncelleMarka
            // 
            this.lblGüncelleMarka.AutoSize = true;
            this.lblGüncelleMarka.Location = new System.Drawing.Point(19, 59);
            this.lblGüncelleMarka.Name = "lblGüncelleMarka";
            this.lblGüncelleMarka.Size = new System.Drawing.Size(25, 17);
            this.lblGüncelleMarka.TabIndex = 0;
            this.lblGüncelleMarka.Text = "Ad";
            // 
            // gbxEkle
            // 
            this.gbxEkle.Controls.Add(this.btnAracEkle);
            this.gbxEkle.Controls.Add(this.adres);
            this.gbxEkle.Controls.Add(this.tckno);
            this.gbxEkle.Controls.Add(this.surname);
            this.gbxEkle.Controls.Add(this.name);
            this.gbxEkle.Controls.Add(this.lblKilomtere);
            this.gbxEkle.Controls.Add(this.lblYıl);
            this.gbxEkle.Controls.Add(this.lblModel);
            this.gbxEkle.Controls.Add(this.lblMarka);
            this.gbxEkle.Location = new System.Drawing.Point(20, 258);
            this.gbxEkle.Name = "gbxEkle";
            this.gbxEkle.Size = new System.Drawing.Size(237, 269);
            this.gbxEkle.TabIndex = 14;
            this.gbxEkle.TabStop = false;
            this.gbxEkle.Text = "Müsteri Ekle";
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
            // adres
            // 
            this.adres.Location = new System.Drawing.Point(95, 119);
            this.adres.Name = "adres";
            this.adres.Size = new System.Drawing.Size(100, 22);
            this.adres.TabIndex = 8;
            // 
            // tckno
            // 
            this.tckno.Location = new System.Drawing.Point(95, 90);
            this.tckno.Name = "tckno";
            this.tckno.Size = new System.Drawing.Size(100, 22);
            this.tckno.TabIndex = 7;
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(95, 59);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(100, 22);
            this.surname.TabIndex = 6;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(95, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 5;
            // 
            // lblKilomtere
            // 
            this.lblKilomtere.Location = new System.Drawing.Point(15, 120);
            this.lblKilomtere.Name = "lblKilomtere";
            this.lblKilomtere.Size = new System.Drawing.Size(100, 23);
            this.lblKilomtere.TabIndex = 3;
            this.lblKilomtere.Text = "Adres";
            // 
            // lblYıl
            // 
            this.lblYıl.AutoSize = true;
            this.lblYıl.Location = new System.Drawing.Point(15, 90);
            this.lblYıl.Name = "lblYıl";
            this.lblYıl.Size = new System.Drawing.Size(47, 17);
            this.lblYıl.TabIndex = 2;
            this.lblYıl.Text = "Tckno";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(15, 60);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(48, 17);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Soyad";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(15, 30);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(25, 17);
            this.lblMarka.TabIndex = 0;
            this.lblMarka.Text = "Ad";
            // 
            // dgwAracİslemleri
            // 
            this.dgwAracİslemleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAracİslemleri.Location = new System.Drawing.Point(19, 49);
            this.dgwAracİslemleri.Name = "dgwAracİslemleri";
            this.dgwAracİslemleri.RowHeadersWidth = 51;
            this.dgwAracİslemleri.RowTemplate.Height = 24;
            this.dgwAracİslemleri.Size = new System.Drawing.Size(820, 182);
            this.dgwAracİslemleri.TabIndex = 13;
            // 
            // MusteriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 577);
            this.Controls.Add(this.gbxAracSil);
            this.Controls.Add(this.gbxGüncelle);
            this.Controls.Add(this.gbxEkle);
            this.Controls.Add(this.dgwAracİslemleri);
            this.Name = "MusteriIslemleri";
            this.Text = "MusteriIslemleri";
            this.Load += new System.EventHandler(this.MusteriIslemleri_Load);
            this.gbxAracSil.ResumeLayout(false);
            this.gbxAracSil.PerformLayout();
            this.gbxGüncelle.ResumeLayout(false);
            this.gbxGüncelle.PerformLayout();
            this.gbxEkle.ResumeLayout(false);
            this.gbxEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAracİslemleri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAracSil;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbxGüncelle;
        private System.Windows.Forms.TextBox tbxGuncelleId;
        private System.Windows.Forms.Label lblGunclelleId;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox tbxGüncelleAdres;
        private System.Windows.Forms.TextBox tbxGüncelletckno;
        private System.Windows.Forms.TextBox tbxGüncelleSoıyad;
        private System.Windows.Forms.TextBox tbxGüncelleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblGüncelleModel;
        private System.Windows.Forms.Label lblGüncelleMarka;
        private System.Windows.Forms.GroupBox gbxEkle;
        private System.Windows.Forms.Button btnAracEkle;
        private System.Windows.Forms.TextBox adres;
        private System.Windows.Forms.TextBox tckno;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label lblKilomtere;
        private System.Windows.Forms.Label lblYıl;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.DataGridView dgwAracİslemleri;
    }
}