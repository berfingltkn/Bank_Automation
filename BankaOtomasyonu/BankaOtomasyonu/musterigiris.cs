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
    public partial class musterigiris : Form
    {
        public musterigiris()
        {
            InitializeComponent();
        }
        public static string TabloTc = "";
        public static string TabloSifre = "";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=bankaotomasyonu;Integrated Security=True";
        public void geributton_Click(object sender, EventArgs e)
        {
            login frm = new login();
            this.Close();
            frm.Show();
        }

        public void musterigiris_Load(object sender, EventArgs e)
        {
            hatabilgilabel.Visible = false;
            sifremiunuttumlabel.Visible = false;
        }

        public void yoneticibutton_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from musteriTaable where tc=@tcc and sifre=@password";
            con = new SqlConnection(baglanti);
            cmd = new SqlCommand(sorgu,con);
            cmd.Parameters.AddWithValue("@tcc",tctextBox.Text);
            TabloTc = tctextBox.Text;
            cmd.Parameters.AddWithValue("@password", sifretextBox.Text);
            TabloSifre = tctextBox.Text;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                MusteriBilgilerSession frm = new MusteriBilgilerSession();
                frm.Show();
                this.Hide();
            }
            else
            {
                sifremiunuttumlabel.Visible = true;
                hatabilgilabel.Visible = true;
            }
            con.Close();
            
        }

        public void sifremiunuttumlabel_Click(object sender, EventArgs e)
        {
            musterisifremiunuttum sifrefrm = new musterisifremiunuttum();

            this.Close();
            sifrefrm.Show();
        }
        public void sifremiunuttum()
        {
            // eğer girdiği bilgiler doğruysa şifreyi hatırlatsın
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void digerBilgileriAl()
        {
            con = new SqlConnection(baglanti);
            ds = new DataSet();

            string sorgu2 = "select * from musteriTaable where tc=@tc";
            cmd.Parameters.AddWithValue("@tc",tctextBox.Text);
            da = new SqlDataAdapter(sorgu2,con);
            con.Open();
            da.Fill(ds, "musteriTaable");
        }
    }
}
