using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kütüphane_Uygulaması
{
    public partial class EmanetIslemleriForm : Form
    {
        private DataTable dt;
        private List<Emanet> Emanetler;
        public EmanetIslemleriForm()
        {
            InitializeComponent();
            Emanetler = new List<Emanet>();
            dt = new DataTable();

            dt.Columns.Add("Kitap ID :");
            dt.Columns.Add("Son Tarih:");
            dt.Columns.Add("TC: ");
            EmanetDgv.DataSource = dt;

        }
        private void btnEmanetiVerme_Click(object sender, EventArgs e)
        {
            // Giriş alanlarının boş olup olmadığını kontrol ediyoruz
            if (string.IsNullOrWhiteSpace(txtKitapID.Text) ||
                string.IsNullOrWhiteSpace(txtSonTarih.Text) ||
                string.IsNullOrWhiteSpace(txtAlanTc.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Emanet emanet = new Emanet();
            emanet.kitapID = Convert.ToDouble(txtKitapID.Text);
            emanet.SonTarih = Convert.ToDouble(txtSonTarih.Text);
            emanet.Tc = Convert.ToDouble(txtAlanTc.Text);
            emanet.TabloyaEkle(dt);
            Emanetler.Add(emanet);

            txtKitapID.Text = "";
            txtSonTarih.Text = "";
            txtAlanTc.Text = "";
        }

        private void TsmKaydet_Click(object sender, EventArgs e)
        {
            if (Emanetler.Count == 0)
            {
                MessageBox.Show("Kaydedilecek veri bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string yazilacak = JsonSerializer.Serialize<List<Emanet>>(Emanetler);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSON Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string dosya_yolu = dialog.FileName;
                File.WriteAllText(dosya_yolu, yazilacak, Encoding.UTF8);
            }
        }

        private void TsmYükle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(dialog.FileName);
                Emanetler = JsonSerializer.Deserialize<List<Emanet>>(data);

                foreach (Emanet emanet in Emanetler)
                {
                    emanet.TabloyaEkle(dt);
                }
            }
        }
    }
}
