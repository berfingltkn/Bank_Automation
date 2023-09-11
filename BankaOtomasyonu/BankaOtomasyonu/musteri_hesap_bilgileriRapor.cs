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
    public partial class musteri_hesap_bilgileriRapor : Form
    {
        public musteri_hesap_bilgileriRapor()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=bankaotomasyonu;Integrated Security=True";
        private void musteri_hesap_bilgileriRapor_Load(object sender, EventArgs e)
        {
            RaporDoldur("select *from HesapTable");
        }
        public void RaporDoldur(string sql)
        {
            con = new SqlConnection(baglanti);
            da = new SqlDataAdapter(sql, con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds);
            crystalReport11.SetDataSource(ds.Tables[0]);
            crystalReportViewer1.ReportSource = crystalReport11;
            con.Close();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
