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
    public partial class MusteriBilgilerSession : Form
    {
        public MusteriBilgilerSession()
        {
            InitializeComponent();
        }
        public static string TabloAd, TabloSoyad, tc;
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        SqlCommand cmd;
        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=bankaotomasyonu;Integrated Security=True";

        private void geributton_Click(object sender, EventArgs e)
        {
            musterisayfasi frm = new musterisayfasi();
            this.Close();
            frm.Show();
        }

        private void MusteriBilgilerSession_Load(object sender, EventArgs e)
        {
            textboxDoldur();
        }
        public void textboxDoldur()
        {
            con = new SqlConnection(baglanti);
            con.Open();
            SqlCommand cmd2 = new SqlCommand("select * from musteriTaable where tc=@veri2", con);
            cmd2.Parameters.AddWithValue("@veri2", musterigiris.TabloTc);
            SqlDataReader dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["isim"].ToString();
                textBox10.Text = dr["soyad"].ToString();
                textBox9.Text = dr["tc"].ToString();
                textBox7.Text = dr["cinsiyet"].ToString();
                textBox8.Text = dr["dogumtarihi"].ToString();
                textBox3.Text = dr["dogumyeri"].ToString();
                textBox2.Text = dr["email"].ToString();
                textBox5.Text = dr["sifre"].ToString();
                textBox6.Text = dr["adres"].ToString();
                textBox4.Text = dr["telefon"].ToString();

                TabloAd = textBox1.Text;
                TabloSoyad = textBox10.Text;
                tc = textBox9.Text;
            }
            con.Close();

        }
    }
}
