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
    
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Program.owner = this;
        }

        private void btnAracKirala_Click(object sender, EventArgs e)
        {
            AracListele aracListele = new AracListele();
            aracListele.MdiParent = Program.owner;
            pnlYeniAcılacakForm.Controls.Clear();
            aracListele.FormBorderStyle = FormBorderStyle.None;
            pnlYeniAcılacakForm.Controls.Add(aracListele);
            aracListele.Dock = DockStyle.Fill;
            aracListele.Show();
           
        }

        private void btnAracİslemleri_Click(object sender, EventArgs e)
        {
            Aracİslemleri aracİslemleri = new Aracİslemleri();
            aracİslemleri.MdiParent = Program.owner;
            aracİslemleri.FormBorderStyle = FormBorderStyle.None;
            pnlYeniAcılacakForm.Controls.Clear();
            pnlYeniAcılacakForm.Controls.Add(aracİslemleri);
            aracİslemleri.Dock = DockStyle.Fill;
            aracİslemleri.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnHareketler_Click(object sender, EventArgs e)
        {
            Hareketler hareketler = new Hareketler();
            hareketler.MdiParent = Program.owner;
            hareketler.FormBorderStyle = FormBorderStyle.None;
            pnlYeniAcılacakForm.Controls.Clear();
            pnlYeniAcılacakForm.Controls.Add(hareketler);
            hareketler.Dock = DockStyle.Fill;
            hareketler.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriIslemleri musteriIslemleri = new MusteriIslemleri();
            musteriIslemleri.MdiParent = Program.owner;
            musteriIslemleri.FormBorderStyle = FormBorderStyle.None;
            pnlYeniAcılacakForm.Controls.Clear();
            pnlYeniAcılacakForm.Controls.Add(musteriIslemleri);
            musteriIslemleri.Dock = DockStyle.Fill;
            musteriIslemleri.Show();
        }
    }
}
