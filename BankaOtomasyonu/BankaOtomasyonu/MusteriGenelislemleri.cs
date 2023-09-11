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
    public partial class MusteriGenelislemleri : Form
    {
        public MusteriGenelislemleri()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        SqlCommand cmd;
        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=bankaotomasyonu;Integrated Security=True";
        private void button3_Click(object sender, EventArgs e)
        {
            updatePersonel();
        }

        private void MusteriGenelislemleri_Load(object sender, EventArgs e)
        {
            griddoldur();
        }
        public void deleteMusteri()
        {
            con = new SqlConnection(baglanti);
            cmd = new SqlCommand();
            con.Open();
            string sorgu = "delete from musteriTaable where isim=@isim AND tc=@tc";
            cmd.Parameters.AddWithValue("@isim", textBox1.Text);
            cmd.Parameters.AddWithValue("@tc", textBox9.Text);

            cmd.Connection = con;
            cmd.CommandText = sorgu;
            cmd.ExecuteNonQuery();
            griddoldur();
            con.Close();
            MessageBox.Show("silme işlemi başarıyla gerçekleştirildi.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deleteMusteri();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MusteriGoruntule frm66 = new MusteriGoruntule();
            frm66.Show();
        }
        public void griddoldur()
        {
            con = new SqlConnection(baglanti);
            con.Open();
            da = new SqlDataAdapter("select * from musteriTaable", con);
            ds = new DataSet();

            da.Fill(ds, "musteriTaable");
            dataGridView1.DataSource = ds.Tables["musteriTaable"];
            con.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox9.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }
        public void updatePersonel()
        {
            con = new SqlConnection(baglanti);
            cmd = new SqlCommand();
            con.Open();
            string sorgu = "update  musteriTaable set email=@email,sifre=@sifre,telefon=@no,adres=@adres where isim=@isim and tc=@tc";
            cmd.Parameters.AddWithValue("@isim", textBox1.Text);
            cmd.Parameters.AddWithValue("@tc", textBox9.Text);
            cmd.Parameters.AddWithValue("@email", textBox2.Text);
            cmd.Parameters.AddWithValue("@sifre", textBox5.Text);
            cmd.Parameters.AddWithValue("@no", textBox4.Text);
            cmd.Parameters.AddWithValue("@adres", textBox6.Text);

            cmd.Connection = con;
            cmd.CommandText = sorgu;
            cmd.ExecuteNonQuery();
            griddoldur();
            con.Close();
            MessageBox.Show("güncelleme işlemi başarıyla gerçekleştirildi.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            insertMusteri();
        }
       public void insertMusteri()
        {
            string select = "insert into musteriTaable(isim,soyad,tc,cinsiyet,dogumtarihi,dogumyeri,email,sifre,adres,telefon) values(@isim,@soyisim,@tc,@cinsiyet,@dogumtarihi,@dogumyeri,@email,@sifre,@adres,@telefon);";

            con = new SqlConnection(baglanti);
            cmd = new SqlCommand();
            con.Open();

            cmd.Parameters.AddWithValue("@isim", textBox1.Text);
            cmd.Parameters.AddWithValue("@soyisim", textBox10.Text);
            cmd.Parameters.AddWithValue("@cinsiyet", textBox7.Text);
            cmd.Parameters.AddWithValue("@tc", textBox9.Text);
            cmd.Parameters.AddWithValue("@dogumtarihi", textBox9.Text);
            cmd.Parameters.AddWithValue("@dogumyeri", textBox3.Text);
            cmd.Parameters.AddWithValue("@email", textBox2.Text);
            cmd.Parameters.AddWithValue("@sifre", textBox5.Text);
            cmd.Parameters.AddWithValue("@adres", textBox5.Text);
            cmd.Parameters.AddWithValue("@telefon", textBox5.Text);
            cmd.Connection = con;
            cmd.CommandText = select;
            cmd.ExecuteNonQuery();
            griddoldur();
            con.Close();

        }

        private void geributton_Click(object sender, EventArgs e)
        {
            yoneticisayfasi frm3 = new yoneticisayfasi();
            frm3.Show();
            this.Close();
        }
    }
}
