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
    public partial class MusteriBilgi : Form
    {
        public MusteriBilgi()
        {
            InitializeComponent();
        }
        CarManager manager = new CarManager(new EfCarsDal());
        private void MusteriBilgi_Load(object sender, EventArgs e)
        {
            string[] ehliyet =new string[17] { "A", "C1", "C", "D1", "D", "BE", "CE", "C1E", "DE", "D1E"," M", "B1", "B", "A1","A2", "F" ,"G"};
            cbxEhliyet.Items.AddRange(ehliyet);
        }
        public static DateTime NeZamanaKadar;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
            Font font = new Font("Calibri", 28);
            Font font1 = new Font("Calibri", 16);
            
            SolidBrush solidBrush = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black);
            e.Graphics.DrawLine(pen, 120, 120, 750, 120);
            e.Graphics.DrawLine(pen, 120, 180, 750, 180);
            e.Graphics.DrawString("ARAÇ KİRALAMA SÖZLEŞMESİ", font, solidBrush, 200, 120);
            e.Graphics.DrawString("Kiracı Bilgisi", font1, solidBrush, 90, 200);
            e.Graphics.DrawLine(pen, 90, 225, 200, 225);
            e.Graphics.DrawString("AD:", font1, solidBrush, 90, 235);
            e.Graphics.DrawString( tbxAd.Text, font1, solidBrush, 90, 260);
            e.Graphics.DrawString("SOYAD:", font1, solidBrush, 90, 285);
            e.Graphics.DrawString(  tbxSoyad.Text, font1, solidBrush, 90, 310);
            e.Graphics.DrawString("TCKNO:", font1, solidBrush, 90, 335);
            e.Graphics.DrawString( TbxTckno.Text, font1, solidBrush, 90, 360);
            e.Graphics.DrawString("EHLİYET:", font1, solidBrush, 90, 385);
            e.Graphics.DrawString(cbxEhliyet.SelectedItem.ToString(), font1, solidBrush, 90, 410);
            e.Graphics.DrawString("DOĞUM TARİHİ:", font1, solidBrush, 90, 435);
            e.Graphics.DrawString(dateTimePicker1.Text, font1, solidBrush, 90, 460);
         
            e.Graphics.DrawString("ADRES:", font1, solidBrush, 90, 485);
            e.Graphics.DrawString(tbxAdres.Text, font1, solidBrush, 90, 510);
            e.Graphics.DrawString("Kiralayan Bilgisi", font1, solidBrush, 500, 200);
            e.Graphics.DrawLine(pen, 500, 225, 645, 225);
            e.Graphics.DrawString("ŞİRKET ADI", font1, solidBrush, 500, 235);
            e.Graphics.DrawString("XXX RENTACAR", font1, solidBrush, 500, 255);
            e.Graphics.DrawString("TEMSİLCİ", font1, solidBrush, 500, 275);
            e.Graphics.DrawString("XXX RENTACAR", font1, solidBrush, 500, 295);
            e.Graphics.DrawString("TELEFON NUMARASI", font1, solidBrush, 500, 315);
            e.Graphics.DrawString("0555 555 55 55", font1, solidBrush, 500, 335);
            e.Graphics.DrawString("ADRES", font1, solidBrush, 500, 355);
            e.Graphics.DrawString("YUKARIKİ MAHALLE OSMANLI KÖYÜ MERKEZ/ZONGULDAK ", font1, solidBrush, 500,375 );

            e.Graphics.DrawString("ARAC BİLGİLERİ", font1, solidBrush, 90, 575);
            e.Graphics.DrawLine(pen, 90, 600, 245, 600);
            e.Graphics.DrawString("MARKA:"+AracListele.AracBilgileri[2], font1, solidBrush, 90, 625);
            e.Graphics.DrawString("MODEL:"+AracListele.AracBilgileri[3], font1, solidBrush, 90, 650);
            e.Graphics.DrawString("YIL:"+AracListele.AracBilgileri[1], font1, solidBrush, 90, 675);
            e.Graphics.DrawString("PLAKA:"+AracListele.AracBilgileri[0], font1, solidBrush, 90, 700);
            e.Graphics.DrawString("KİLOMETRE:" + AracListele.AracBilgileri[4], font1, solidBrush, 90, 725);
            //e.Graphics.DrawString("PLAKA" + AracListele.AracBilgileri[3], font1, solidBrush, 90, 750);



        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
       
            printPreviewDialog1.ShowDialog();
            
           NeZamanaKadar = nezamanakadar();
            MessageBox.Show(NeZamanaKadar.ToString());
            manager.KiralandigiSaatiYaz(new Car { Id = AracListele.AracId, Saat = NeZamanaKadar });
            timer1.Interval = 1000;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           var entitiy= manager.KiradakiAraçlarıListele();
          
           

                foreach (var item in entitiy)//kiradaki araçlar listesi içinde teker teker 1 saniyede bir süresi geöen var mı diye bak.
                {
                  if (item.Saat<DateTime.Now)
                  {

                    manager.CarStateChange2(item);
                    manager.SaatiSıfırlaManager(item);

                  }
                }
          
        }
        public DateTime nezamanakadar()
        {
            int eklenecekGun = Convert.ToInt32(tbxGün.Text);
            int eklenecekSaat = Convert.ToInt32(tbxSaat.Text);
            return DateTime.Now.AddDays(eklenecekGun).AddSeconds(eklenecekSaat);
        }
    }
}
