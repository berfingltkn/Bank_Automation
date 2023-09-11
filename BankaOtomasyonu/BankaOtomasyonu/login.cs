using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaOtomasyonu
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void yoneticibutton_Click(object sender, EventArgs e)
        {
            yoneticigiris frm = new yoneticigiris();
            frm.Show();
            this.Hide();
        }

        private void musteributton_Click(object sender, EventArgs e)
        {
            musterigiris frm = new musterigiris();
            frm.Show();
            this.Hide();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
