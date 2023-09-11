using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BankaOtomasyonu
{
    public partial class YoneticiSifreDegistir : Form
    {
        public YoneticiSifreDegistir()
        {
            InitializeComponent();
        }
        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=bankaotomasyonu;Integrated Security=True";
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;
        private void YoneticiSifreDegistir_Load(object sender, EventArgs e)
        {

        }
        public void eskisifreKontrol()
        {
            string sorgu = "select sifre from yoneticiTable where tc=@tc";
            con = new SqlConnection(baglanti);
            cmd = new SqlCommand(sorgu,con);
            con.Open();
            cmd.Parameters.AddWithValue("@tc", textBox2.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                if (telefon.Text != textBox1.Text)
                {
                    MessageBox.Show("yeni şifre ile yeni şifre tekrar uyuşmamaktadır!");
                }
                sifreGuncelle();
            }
            else
            {
                MessageBox.Show("eski şifre hatalı!");
            }
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            eskisifreKontrol();
           
        }
        public void sifreGuncelle()
        {
           
            con = new SqlConnection(baglanti);
            string sorgu = "update yoneticiTable set sifre=@sifre where tc=@tc";
            con.Open();
            cmd = new SqlCommand(sorgu, con);
            
            cmd.Parameters.AddWithValue("@sifre", textBox1.Text);
            cmd.Parameters.AddWithValue("@tc", textBox2.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Şifre Başarıyla Güncelleştirildi.");
        }

        private void geributton_Click(object sender, EventArgs e)
        {
            yoneticisayfasi frm7 = new yoneticisayfasi();
            frm7.Show();
            this.Hide();
        }
    }
}
