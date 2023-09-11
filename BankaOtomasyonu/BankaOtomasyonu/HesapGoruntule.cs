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
    public partial class HesapGoruntule : Form
    {
        public HesapGoruntule()
        {
            InitializeComponent();
        }
        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=bankaotomasyonu;Integrated Security=True";
        public static int yuzde, kazanc;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;


        private void geributton_Click(object sender, EventArgs e)
        {
            musterisayfasi frm = new musterisayfasi();
            frm.Show();
            this.Hide();
        }

        private void HesapGoruntule_Load(object sender, EventArgs e)
        {
            GridDoldur();
        }

        public void GridDoldur()
        {
            string sorgu = "select * from HesapTable where tc=@tc and OnayDurum='onaylandı' ";
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
