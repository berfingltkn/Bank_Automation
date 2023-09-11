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
    public partial class PersonelEkle : Form
    {
        public PersonelEkle()
        {
            InitializeComponent();
        }

        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=bankaotomasyonu;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        private void PersonelEkle_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Veznedar");
            comboBox1.Items.Add("MüşteriHiz");
            comboBox1.Items.Add("Yönetici");
           
        }

        private void musteributton_Click(object sender, EventArgs e)
        {
            string select = "insert into PersonelEkleTable(Isim,Soyisim,telefonno,tc,adres,statu,maas,maasdurum) values(@isim,@soyisim,@telefon,@tc,@adres,@statu,@maas,@durum);";

            con = new SqlConnection(baglanti);
            cmd = new SqlCommand();
            
            cmd.Parameters.AddWithValue("@isim",textBox1.Text);
            cmd.Parameters.AddWithValue("@soyisim",textBox3.Text);
            cmd.Parameters.AddWithValue("@telefon",textBox4.Text);
            cmd.Parameters.AddWithValue("@tc", textBox2.Text);
            cmd.Parameters.AddWithValue("@adres", richTextBox1.Text);
            cmd.Parameters.AddWithValue("statu",comboBox1.Text);
            cmd.Parameters.AddWithValue("@durum","ödenmedi");

            if (comboBox1.Text=="Veznedar")
            {
                cmd.Parameters.AddWithValue("@maas", 4000);
            }
            else if (comboBox1.Text=="MüşteriHiz")
            {
                cmd.Parameters.AddWithValue("@maas", 5000);
            }
            else if (comboBox1.Text=="Yönetici")
            {
                cmd.Parameters.AddWithValue("@maas", 6000);
            }

            con.Open();
            cmd.Connection =con;
            cmd.CommandText = select;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void geributton_Click(object sender, EventArgs e)
        {
            yoneticisayfasi frm7 = new yoneticisayfasi();
            frm7.Show();
            this.Hide();
        }
    }
}
