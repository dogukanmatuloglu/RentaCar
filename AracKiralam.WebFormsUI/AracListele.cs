using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AracKiralama.Business.Concrete;
using AracKiralama.DataAccess.Concrete.EntityFramework;
using AracKiralama.Entities.Concrete;

namespace AracKiralam.WebFormsUI
{
    public partial class AracListele : Form
    {
        public AracListele()
        {
            InitializeComponent();
        }
        CarManager manager = new CarManager(new EfCarsDal());
        public static Car arac;
        public static string[] AracBilgileri = null;
        public static int AracId;
        
        private void AracListele_Load(object sender, EventArgs e)
        {
            dgwCars.DataSource = manager.GetAll();
        }

        private void btnSecim_Click(object sender, EventArgs e)
        {

            MusteriBilgi musteriBilgi = new MusteriBilgi();
            musteriBilgi.MdiParent = Program.owner;
            pnlAracListele.Controls.Clear();
            musteriBilgi.FormBorderStyle = FormBorderStyle.None;
            pnlAracListele.Controls.Add(musteriBilgi);
            musteriBilgi.Dock = DockStyle.Fill;

            AracBilgileri=AracBilgi(dgwCars);//arac bilgilerini pdf de görüntülemek üzere alıyoruz
            manager.CarStateChange(new Car() { Id = Convert.ToInt32(dgwCars.CurrentRow.Cells[0].Value) });
            AracId = Convert.ToInt32(dgwCars.CurrentRow.Cells[0].Value);
            musteriBilgi.Show();
            arac = new Car { Id = Convert.ToInt32(dgwCars.CurrentRow.Cells[0].Value) };

        }

        private string[] AracBilgi(DataGridView dataGridView)
        {
            string[] bilgi = new string[5];
            for (int i = 0; i < dataGridView.CurrentRow.Cells.Count-3; i++)
            {
                bilgi[i] = dataGridView.CurrentRow.Cells[i+1].Value.ToString();
            }

            return bilgi;

        }

        private void dgwCars_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pnlAracListele_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
