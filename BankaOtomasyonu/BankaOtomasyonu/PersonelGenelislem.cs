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
    public partial class PersonelGenelislem : Form
    {
        public PersonelGenelislem()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        SqlCommand cmd;
        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=bankaotomasyonu;Integrated Security=True";

        private void PersonelGenelislem_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Veznedar");
            comboBox1.Items.Add("MüşteriHiz");
            comboBox1.Items.Add("Yönetici");

        }
        public void griddoldur()
        {
            con = new SqlConnection(baglanti);
            con.Open();
            da = new SqlDataAdapter("select * from PersonelEkleTable", con);
            ds = new DataSet();

            da.Fill(ds, "PersonelEkleTable");
            dataGridView1.DataSource = ds.Tables["PersonelEkleTable"];
            con.Close();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBox1.Text= dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            griddoldur();
        }
        public void deletePersonel()
        {
            con = new SqlConnection(baglanti);
            cmd = new SqlCommand();
            con.Open();
            string sorgu = "delete from PersonelEkleTable where Isim=@isim AND tc=@tc";
            cmd.Parameters.AddWithValue("@isim",textBox1.Text);
            cmd.Parameters.AddWithValue("@tc", textBox2.Text);

            cmd.Connection = con;
            cmd.CommandText = sorgu;
            cmd.ExecuteNonQuery();
            griddoldur();
            con.Close();
            MessageBox.Show("silme işlemi başarıyla gerçekleştirildi.");
        }

        private void geributton_Click(object sender, EventArgs e)
        {
            yoneticisayfasi frm3 = new yoneticisayfasi();
            frm3.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            deletePersonel();
        }
        public void updatePersonel()
        {
            con = new SqlConnection(baglanti);
            cmd = new SqlCommand();
            con.Open();
            string sorgu = "update  PersonelEkleTable set statu=@statu,telefonno=@no where Isim=@isim and tc=@tc";
            cmd.Parameters.AddWithValue("@isim", textBox1.Text);
            cmd.Parameters.AddWithValue("@tc", textBox2.Text);
            cmd.Parameters.AddWithValue("@no",textBox4.Text);
            cmd.Parameters.AddWithValue("statu",comboBox1.Text);
            cmd.Connection = con;
            cmd.CommandText = sorgu;
            cmd.ExecuteNonQuery();
            griddoldur();
            con.Close();
            MessageBox.Show("güncelleme işlemi başarıyla gerçekleştirildi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            updatePersonel();
        }
    }
}
