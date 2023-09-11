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
    public partial class MusteriGoruntule : Form
    {
        public MusteriGoruntule()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=bankaotomasyonu;Integrated Security=True";

        private void MusteriGoruntule_Load(object sender, EventArgs e)
        {
            baglantiolustur();
        }

        public void baglantiolustur()//not: fonksiyona static yazarsan yukarıda tanımlanmış con,da,ds görünmez.
        {
            con = new SqlConnection(baglanti);
            da = new SqlDataAdapter("select * from musteriTaable", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "musteriTaable");
            con.Close();
            bindingSource1.DataSource = ds.Tables["musteriTaable"];
            bindingNavigator1.BindingSource = bindingSource1;
            textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "isim"));
            textBox10.DataBindings.Add(new Binding("Text", bindingSource1, "soyad"));
            textBox9.DataBindings.Add(new Binding("Text", bindingSource1, "tc"));
            textBox7.DataBindings.Add(new Binding("Text", bindingSource1, "cinsiyet"));
            textBox8.DataBindings.Add(new Binding("Text", bindingSource1, "dogumtarihi"));
            textBox3.DataBindings.Add(new Binding("Text", bindingSource1, "dogumyeri"));
            textBox2.DataBindings.Add(new Binding("Text", bindingSource1, "email"));
            textBox5.DataBindings.Add(new Binding("Text", bindingSource1, "sifre"));
            textBox6.DataBindings.Add(new Binding("Text", bindingSource1, "adres"));
            textBox4.DataBindings.Add(new Binding("Text", bindingSource1, "telefon"));

        }

        private void bindingNavigator1_RefreshItems(object sender, EventArgs e)
        {

        }

        private void geributton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
