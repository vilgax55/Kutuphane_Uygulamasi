using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kütüphane_Uygulaması;

namespace Kütüphane_Uygulaması
{
    public partial class AnaSayfaForm : Form
    {
        public AnaSayfaForm()
        {
            InitializeComponent();
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            var UyeEklefrm = new UyeEkleForm();
            UyeEklefrm.Show();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            var KitapEklefrm = new KitapİslemleriForm();
            KitapEklefrm.Show();
        }

        private void btnEmanetVerme_Click(object sender, EventArgs e)
        {
            var EmanetVerfrm = new EmanetIslemleriForm();
            EmanetVerfrm.Show();
        }
    }
}
