
namespace AracKiralam.WebFormsUI
{
    partial class AracListele
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
            this.dgwCars = new System.Windows.Forms.DataGridView();
            this.btnSecim = new System.Windows.Forms.Button();
            this.pnlAracListele = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCars)).BeginInit();
            this.pnlAracListele.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwCars
            // 
            this.dgwCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCars.Location = new System.Drawing.Point(3, 10);
            this.dgwCars.Name = "dgwCars";
            this.dgwCars.RowHeadersWidth = 51;
            this.dgwCars.RowTemplate.Height = 24;
            this.dgwCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCars.Size = new System.Drawing.Size(859, 349);
            this.dgwCars.TabIndex = 0;
            this.dgwCars.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCars_CellContentClick);
            // 
            // btnSecim
            // 
            this.btnSecim.Location = new System.Drawing.Point(710, 365);
            this.btnSecim.Name = "btnSecim";
            this.btnSecim.Size = new System.Drawing.Size(152, 50);
            this.btnSecim.TabIndex = 1;
            this.btnSecim.Text = "Seç";
            this.btnSecim.UseVisualStyleBackColor = true;
            this.btnSecim.Click += new System.EventHandler(this.btnSecim_Click);
            // 
            // pnlAracListele
            // 
            this.pnlAracListele.Controls.Add(this.btnSecim);
            this.pnlAracListele.Controls.Add(this.dgwCars);
            this.pnlAracListele.Location = new System.Drawing.Point(3, 2);
            this.pnlAracListele.Name = "pnlAracListele";
            this.pnlAracListele.Size = new System.Drawing.Size(865, 555);
            this.pnlAracListele.TabIndex = 2;
            this.pnlAracListele.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAracListele_Paint);
            // 
            // AracListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 558);
            this.Controls.Add(this.pnlAracListele);
            this.Name = "AracListele";
            this.Text = "AracListele";
            this.Load += new System.EventHandler(this.AracListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCars)).EndInit();
            this.pnlAracListele.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCars;
        private System.Windows.Forms.Button btnSecim;
        private System.Windows.Forms.Panel pnlAracListele;
    }
}