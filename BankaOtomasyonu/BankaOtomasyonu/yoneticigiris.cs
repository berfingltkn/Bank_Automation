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
    public partial class yoneticigiris : Form
    {
        public yoneticigiris()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        public static string baglanti=@"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=bankaotomasyonu;Integrated Security=True";

        private void yoneticigiris_Load(object sender, EventArgs e)
        {
            hatabilgilabel.Visible = false;
            sifremiunuttumlabel.Visible = false;
        }

        private void geributton_Click(object sender, EventArgs e)
        {
            login frm = new login();
            this.Close();
            frm.Show();
        }

        private void yoneticibutton_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from yoneticiTable where tc=@tcno AND sifre=@password";
            con = new SqlConnection(baglanti);
            cmd = new SqlCommand(sorgu,con);
            
            
           
            cmd.Parameters.AddWithValue("@tcno",tctextBox.Text);
            cmd.Parameters.AddWithValue("@password",sifretextBox.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            //cmd.Connection = con;
            //cmd.CommandText = sorgu;
            //cmd.ExecuteNonQuery();
            if (dr.Read())
            {
                yoneticisayfasi frm = new yoneticisayfasi();
                frm.Show();
                this.Close();

            }
            else
            {
                hatabilgilabel.Visible = true;
                sifremiunuttumlabel.Visible = true;
            }
            con.Close();
        }

        private void sifremiunuttumlabel_Click(object sender, EventArgs e)
        {
            yoneticisifremiunuttum frm = new yoneticisifremiunuttum();
            this.Close();
            frm.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
