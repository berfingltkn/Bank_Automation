using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public partial class yoneticisifremiunuttum : Form
    {
        public yoneticisifremiunuttum()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand cmd;
        public static string baglanti = @"Data Source=DESKTOP-9M6T8FA\SQLEXPRESS;Initial Catalog=bankaotomasyonu;Integrated Security=True";
        private void button_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from yoneticiTable where tc=@tc AND numara=@telefon";
            con = new SqlConnection(baglanti);
            con.Open();
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@tc", tcno.Text);
            cmd.Parameters.AddWithValue("@telefon", telefon.Text);
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                Random rastgele = new Random();
                int yenisifre = rastgele.Next(100000, 999999);

                string kayit = "update yoneticiTable set sifre=@sifre where tc=@tc";
                cmd = new SqlCommand(kayit, con);
                cmd.Parameters.AddWithValue("@sifre", yenisifre);
                cmd.Parameters.AddWithValue("@tc", tcno.Text);
                cmd.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.

                MessageBox.Show("sms telefon numaranıza gönderildi.");
                var url = "http://panel.ankaratoplusms.com/jsonapi/Submit";

                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Method = "POST";

                httpRequest.Accept = "application/json";
                httpRequest.ContentType = "application/json";

                var data = "{\"auth\":{\"username\":\"hq.15667\",\"password\":\"Ezber2000\"},\"MsgType\":\"Turkey\", \"DataCoding\":\"Standart\",\"Originator\":\"Ankara SMS\",\"Message\":\"yeni şifreniz: " + yenisifre + "\",\"To\":[\"" + telefon.Text + "\"]}";

                using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
                {
                    streamWriter.Write(data);
                }

                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                }
            }
            con.Close();
        }

        private void geributton_Click(object sender, EventArgs e)
        {
            yoneticigiris frm = new yoneticigiris();
            this.Close();
            frm.Show();
        }
    }
}
