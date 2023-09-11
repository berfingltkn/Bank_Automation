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
    public partial class ParaCek : Form
    {
        public ParaCek()
        {
            InitializeComponent();
        }
        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=bankaotomasyonu;Integrated Security=True";
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public static int para = 0, borc = 0, bakiye = 0;

        private void ParaCek_Load(object sender, EventArgs e)
        {
            griddoldur();
        }
        public void griddoldur()
        {
            con = new SqlConnection(baglanti);
            con.Open();
            da = new SqlDataAdapter("select * from HesapTable where tc=@tc and isim=@isim ", con);
            ds = new DataSet();

            da.SelectCommand.Parameters.AddWithValue("@tc", MusteriBilgilerSession.tc);
            da.SelectCommand.Parameters.AddWithValue("@isim", MusteriBilgilerSession.TabloAd);
            da.Fill(ds, "HesapTable");
            dataGridView1.DataSource = ds.Tables["HesapTable"];
            con.Close();
        }

        private void musteributton_Click(object sender, EventArgs e)
        {
            musterisayfasi fr = new musterisayfasi();
            fr.Show();
            this.Hide();
        }

       
        private void musteributton_Click_1(object sender, EventArgs e)
        {
            musterisayfasi fr = new musterisayfasi();
            fr.Show();
            this.Hide();
        }

        private void dataGridView1_CellMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {

            borc = Convert.ToInt32(textBox5.Text);
            para = Convert.ToInt32(textBox3.Text);
            bakiye = Convert.ToInt32(textBox4.Text);

           

            if (textBox2.Text == "kredi")
            {
                borc = borc + para;
                borcguncelle();
            }
            else if (textBox2.Text == "vadesiz")
            {
               
                if (para > bakiye)
                {
                    MessageBox.Show("bakiye yetersiz ");
                }
                else
                {
                    para = bakiye - para;
                    bakiye = para;
                    bakiyeguncelle();
                }

            }
            else if (textBox2.Text == "vadeli")
            {
                MessageBox.Show("Vadeli Hesap olduğundan işlem yapmak için Yöneticiyle iletişime geçiniz");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void borcguncelle()
        {
            con = new SqlConnection(baglanti);
            con.Open();
            string sorgu = "update HesapTable set Borc=@borc where isim=@isim";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@borc", borc);
            cmd.Parameters.AddWithValue("@isim", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();

        }
        public void bakiyeguncelle()
        {

            con = new SqlConnection(baglanti);
            con.Open();
            string sorgu = "update HesapTable set HesapBakiye=@bakiye where isim=@isim";
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@bakiye", bakiye);
            cmd.Parameters.AddWithValue("@isim", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            griddoldur();
        }

    }
}
