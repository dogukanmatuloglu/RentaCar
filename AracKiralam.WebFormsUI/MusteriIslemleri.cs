using AracKiralama.Business.Concrete;
using AracKiralama.DataAccess.Abstract;
using AracKiralama.DataAccess.Concrete.EntityFramework;
using AracKiralama.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralam.WebFormsUI
{
    public partial class MusteriIslemleri : Form
    {
        public MusteriIslemleri()
        {
            InitializeComponent();
        }
        CustomerManager manager = new CustomerManager(new EfCustomerDal());
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAracEkle_Click(object sender, EventArgs e)
        {
            manager.Add(new Customer { Name = name.Text, Surname = surname.Text, Adress = adres.Text, TCKNO = tckno.Text });
            MusteriLoad();
        }

        private void MusteriIslemleri_Load(object sender, EventArgs e)
        {
            MusteriLoad();
        }

        private void tbxGuncelleId_TextChanged(object sender, EventArgs e)
        {

        }
        private void MusteriLoad()
        {
            dgwAracİslemleri.DataSource = manager.GetAll();
        }
    }
}
