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
    public partial class MusteriDestek : Form
    {
        public MusteriDestek()
        {
            InitializeComponent();
        }

        private void geributton_Click(object sender, EventArgs e)
        {
            musterisayfasi frm = new musterisayfasi();
            frm.Show();
            this.Hide();
        }

        private void MusteriDestek_Load(object sender, EventArgs e)
        {

        }
    }
}
