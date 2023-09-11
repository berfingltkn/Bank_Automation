using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BankaOtomasyonu
{
    public partial class yoneticisayfasi : Form
    {
        public yoneticisayfasi()
        {
            InitializeComponent();
        }
        
        private void yoneticisayfasi_Load(object sender, EventArgs e)
        {
            
        }

        private void isimlabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PersonelEkle frm = new PersonelEkle();
            frm.Show();
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PersonelMaasYatırma frm1 = new PersonelMaasYatırma();
            frm1.Show();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            YoneticiSifreDegistir frm5 = new YoneticiSifreDegistir();
            frm5.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PersonelGenelislem frm8 = new PersonelGenelislem();
            frm8.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MusteriGenelislemleri frm0 = new MusteriGenelislemleri();
            frm0.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OnayBekleyenMusteriler d = new OnayBekleyenMusteriler();
            d.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            musteri_hesap_bilgileriRapor frm = new musteri_hesap_bilgileriRapor();
            frm.Show();
            this.Hide();
        }
    }
}
