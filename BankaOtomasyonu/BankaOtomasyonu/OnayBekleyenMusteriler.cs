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
    public partial class OnayBekleyenMusteriler : Form
    {
        public OnayBekleyenMusteriler()
        {
            InitializeComponent();
        }
        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=bankaotomasyonu;Integrated Security=True";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommand cmd;
        
        private void geributton_Click(object sender, EventArgs e)
        {
            yoneticisayfasi j = new yoneticisayfasi();
            j.Show();
            this.Hide();
        }

        private void OnayBekleyenMusteriler_Load(object sender, EventArgs e)
        {
            griddoldur();
        }
        public void griddoldur()
        {
            string sorgu = "select * from HesapTable where OnayDurum='onaylanmadı'";
            con = new SqlConnection(baglanti);
            con.Open();
            da = new SqlDataAdapter(sorgu,con);
            ds = new DataSet();
            da.Fill(ds,"HesapTable");

            dataGridView1.DataSource = ds.Tables["HesapTable"];

            con.Close();

        }
        public void updateOnayDurum()
        {
            string select = "update HesapTable set OnayDurum=@durum where HesapNo=@no";
            con = new SqlConnection(baglanti);
            con.Open();
            cmd = new SqlCommand(select, con);
            cmd.Parameters.AddWithValue("@durum","onaylandı");
            cmd.Parameters.AddWithValue("@no", textBox4.Text);
           
            cmd.ExecuteNonQuery();
            griddoldur();
            con.Close();

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox4.Text= dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            updateOnayDurum();
            MessageBox.Show("Hesap Onayı Başarı ile Gerçekleştirildi.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
