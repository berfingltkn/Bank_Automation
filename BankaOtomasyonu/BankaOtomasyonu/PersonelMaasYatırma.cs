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
    public partial class PersonelMaasYatırma : Form
    {
        public PersonelMaasYatırma()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds;
        SqlCommand cmd;
        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=bankaotomasyonu;Integrated Security=True";
        private void PersonelMaasYatırma_Load(object sender, EventArgs e)
        {
            griddoldur();
            
        }
        public void griddoldur()
        {
            con = new SqlConnection(baglanti);
            con.Open();
            da = new SqlDataAdapter("select * from PersonelEkleTable where maasdurum='ödenmedi'", con);
            ds = new DataSet();

            da.Fill(ds,"PersonelEkleTable");
            dataGridView1.DataSource = ds.Tables["PersonelEkleTable"];
            con.Close();
        }
     

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

            
        }
        public void maasdurumUpdate()
        {
            string odendi = "ödendi";
            con = new SqlConnection(baglanti);
            cmd = new SqlCommand();
            con.Open();
            string select = "update PersonelEkleTable set maasdurum=@maasdurum where Isim=@isim";
            cmd.Parameters.AddWithValue("@maasdurum", odendi);
            cmd.Parameters.AddWithValue("@isim", textBox1.Text);
            cmd.Connection = con;
            cmd.CommandText = select;
            cmd.ExecuteNonQuery();
            griddoldur();
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            maasdurumUpdate();
            MessageBox.Show("maaş yatırıldı :)");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void geributton_Click(object sender, EventArgs e)
        {
            yoneticisayfasi frm3 = new yoneticisayfasi();
            frm3.Show();
            this.Close();
        }
    }
}
