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
    public partial class Aracİslemleri : Form
    {
        public Aracİslemleri()
        {
            InitializeComponent();
        }
        CarManager carManager = new CarManager(new EfCarsDal());
        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            
            
            carManager.Add(new Car() { Kilometre=Convert.ToInt32( tbxKilometre.Text),Marka=tbxMarka.Text,Model=tbxModel.Text,Plaka=tbxPlaka.Text,Yıl=Convert.ToInt32( tbxYıl.Text )});
            MessageBox.Show("Araç Eklendi");
            CarLoad();
        }

        private void dgwAracİslemleri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Aracİslemleri_Load(object sender, EventArgs e)
        {
            CarLoad();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            carManager.Update(new Car {Id=Convert.ToInt32( tbxGuncelleId.Text), Kilometre = Convert.ToInt32(tbxGüncelleKilometre.Text), Marka = tbxGüncelleMarka.Text, Model = tbxGüncelleModel.Text, Plaka = tbxGüncellePlaka.Text, Yıl = Convert.ToInt32(tbxGüncelleYıl.Text) });
            CarLoad();
            MessageBox.Show("Araç Güncellendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            carManager.Delete(new Car() { Id = Convert.ToInt32(dgwAracİslemleri.CurrentRow.Cells[0].Value) });
            CarLoad();
            MessageBox.Show("Araç Silindi");
        }
        public void CarLoad()
        {
            dgwAracİslemleri.DataSource = carManager.GetAll();
        }
    }
}
