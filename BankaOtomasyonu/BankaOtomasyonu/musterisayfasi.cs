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
    public partial class musterisayfasi : Form
    {
        public musterisayfasi()
        {
            InitializeComponent();
        }
 public void isimlabel_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            MusteriSifreDegistir frm = new MusteriSifreDegistir();
            frm.Show();
            this.Hide();
        }

        private void musteributton_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ParaYatır frm88 = new ParaYatır();
            frm88.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ParaCek frms =new ParaCek();
            frms.Show();
            this.Hide();
        }

        private void musterisayfasi_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            MusteriBilgilerSession frk = new MusteriBilgilerSession();
            frk.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            VadeliHesap fro = new VadeliHesap();
            fro.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            VadesizHesap frm = new VadesizHesap();
            frm.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            KrediHesabi frm = new KrediHesabi();
            frm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HesapGoruntule frm = new HesapGoruntule();
            frm.Show();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MusteriDestek g = new MusteriDestek();
            g.Show();
            this.Hide();
        }
    }
}