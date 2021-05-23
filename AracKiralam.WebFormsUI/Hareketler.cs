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

namespace AracKiralam.WebFormsUI
{
    public partial class Hareketler : Form
    {
        public Hareketler()
        {
            InitializeComponent();
        }
        CarManager manager = new CarManager(new EfCarsDal());

        private void Hareketler_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = manager.KiradakiAraçlarıListele();
            dgwGarajdakiAraclar.DataSource = manager.GarajdakiAraclariListele();

            
            
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
