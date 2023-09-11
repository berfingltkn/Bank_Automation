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
    public partial class VadeliHesap : Form
    {
        public VadeliHesap()
        {
            InitializeComponent();
        }
        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=bankaotomasyonu;Integrated Security=True";
        public static int yuzde, kazanc;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void griddoldur()
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            insertTable();
        }

        private void VadeliHesap_Load(object sender, EventArgs e)
        {
            GridDoldur();
            
            
        }

        private void geributton_Click(object sender, EventArgs e)
        {

            musterisayfasi frm = new musterisayfasi();
            frm.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "3")
            {
                textBox5.Text = "10";
                textBox6.Text = "12";

            }
            else if (textBox1.Text == "6")
            {
                textBox5.Text = "15";
                textBox6.Text = "20";

            }
            else if (textBox1.Text == "12")
            {
                textBox5.Text = "20";
                textBox6.Text = "40";

            }
           
            int ceviri2 = Convert.ToInt32(textBox8.Text);
            yuzde = Convert.ToInt32(textBox5.Text);
            kazanc = (ceviri2 * yuzde) / 100;
            textBox7.Text = Convert.ToString(kazanc);

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        public void insertTable()
        {
            //not: önce bilgilendirme sistemini aç textboxlar dolsun!!!
            string sorgu = "insert into HesapTable(isim,soyisim,tc,HesapTuru,HesapBakiye,Borc,OnayDurum) values(@isim,@soyisim,@tc,@hesapturu,@hesapbakiye,@borc,@onaydurum)";

            con = new SqlConnection(baglanti);
            con.Open();
            cmd = new SqlCommand(sorgu,con);
            cmd.Parameters.AddWithValue("@isim",MusteriBilgilerSession.TabloAd);
            cmd.Parameters.AddWithValue("@soyisim", MusteriBilgilerSession.TabloSoyad);
            cmd.Parameters.AddWithValue("@tc", MusteriBilgilerSession.tc);
            cmd.Parameters.AddWithValue("@hesapturu", "vadeli");
            cmd.Parameters.AddWithValue("@hesapbakiye",textBox8.Text);
            cmd.Parameters.AddWithValue("@borc", "");
            cmd.Parameters.AddWithValue("@onaydurum","onaylanmadı");

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Hesap Açma Talebi İletilmiştir.");
        }
        public void GridDoldur()
        {
            string sorgu = "select * from HesapTable where tc=@tc and OnayDurum='onaylandı' and HesapTuru='vadeli' "  ;
            con = new SqlConnection(baglanti);
            con.Open();
            da = new SqlDataAdapter(sorgu, con);
            da.SelectCommand.Parameters.AddWithValue("@tc", MusteriBilgilerSession.tc);
            ds = new DataSet();
            da.Fill(ds, "HesapTable");

            dataGridView1.DataSource = ds.Tables["HesapTable"];

            con.Close();

        }
    }
}
