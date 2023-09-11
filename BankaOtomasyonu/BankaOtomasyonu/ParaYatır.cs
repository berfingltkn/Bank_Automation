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
    public partial class ParaYatır : Form
    {
        public ParaYatır()
        {
            InitializeComponent();
        }
        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=bankaotomasyonu;Integrated Security=True";
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public static int para=0,borc=0,bakiye=0;

        private void ParaYatır_Load(object sender, EventArgs e)
        {
            griddoldur();
        }
        public void griddoldur()
        {
            con = new SqlConnection(baglanti);
            con.Open();
            da = new SqlDataAdapter("select * from HesapTable", con);
            ds = new DataSet();

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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            borc = Convert.ToInt32(textBox5.Text);
            para = Convert.ToInt32(textBox3.Text);
            bakiye = Convert.ToInt32(textBox4.Text); 


            if (textBox2.Text=="kredi")
            {
                borc = borc - para;
                if (borc == para)
                {
                    MessageBox.Show("borcunuz kapandı");
                }
                borcguncelle();
            }
            else if (textBox2.Text == "vadesiz")
            {
                para = para + bakiye;
                bakiye = para;
                bakiyeguncelle();
            }
            else if (textBox2.Text == "vadeli")
            {
                MessageBox.Show("Vadeli Hesap olduğundan işlem yapmak için Yöneticiyle iletişime geçiniz");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

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
            cmd.Parameters.AddWithValue("@borc",borc);
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
