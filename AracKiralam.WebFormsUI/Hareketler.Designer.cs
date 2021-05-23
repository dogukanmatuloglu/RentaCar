
namespace AracKiralam.WebFormsUI
{
    partial class Hareketler
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
            this.lblKiradakiAraclar = new System.Windows.Forms.Label();
            this.lblGarajdakArac = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dgwGarajdakiAraclar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGarajdakiAraclar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKiradakiAraclar
            // 
            this.lblKiradakiAraclar.AutoSize = true;
            this.lblKiradakiAraclar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKiradakiAraclar.Location = new System.Drawing.Point(20, 63);
            this.lblKiradakiAraclar.Name = "lblKiradakiAraclar";
            this.lblKiradakiAraclar.Size = new System.Drawing.Size(144, 20);
            this.lblKiradakiAraclar.TabIndex = 0;
            this.lblKiradakiAraclar.Text = "Kiradaki Araçlar";
            // 
            // lblGarajdakArac
            // 
            this.lblGarajdakArac.AutoSize = true;
            this.lblGarajdakArac.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGarajdakArac.Location = new System.Drawing.Point(526, 63);
            this.lblGarajdakArac.Name = "lblGarajdakArac";
            this.lblGarajdakArac.Size = new System.Drawing.Size(156, 20);
            this.lblGarajdakArac.TabIndex = 1;
            this.lblGarajdakArac.Text = "Garajdaki Araçlar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 95);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(320, 372);
            this.dataGridView1.TabIndex = 3;
            // 
            // dgwGarajdakiAraclar
            // 
            this.dgwGarajdakiAraclar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwGarajdakiAraclar.Location = new System.Drawing.Point(530, 95);
            this.dgwGarajdakiAraclar.Name = "dgwGarajdakiAraclar";
            this.dgwGarajdakiAraclar.RowHeadersWidth = 51;
            this.dgwGarajdakiAraclar.RowTemplate.Height = 24;
            this.dgwGarajdakiAraclar.Size = new System.Drawing.Size(320, 372);
            this.dgwGarajdakiAraclar.TabIndex = 4;
            // 
            // Hareketler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 557);
            this.Controls.Add(this.dgwGarajdakiAraclar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblGarajdakArac);
            this.Controls.Add(this.lblKiradakiAraclar);
            this.Name = "Hareketler";
            this.Text = "Hareketler";
            this.Load += new System.EventHandler(this.Hareketler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwGarajdakiAraclar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKiradakiAraclar;
        private System.Windows.Forms.Label lblGarajdakArac;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dgwGarajdakiAraclar;
    }
}