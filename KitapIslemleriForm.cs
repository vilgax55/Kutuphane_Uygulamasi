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
using System.Runtime.InteropServices;

namespace Kütüphane_Uygulaması
{
    public partial class KitapİslemleriForm : Form
    {
        private DataTable dt;
        private List<Kitap> Kitaplar;
        public KitapİslemleriForm()
        {
            InitializeComponent();
            Kitaplar = new List<Kitap>();
            dt = new DataTable();
            dt.Columns.Add("Yazar Adi:");
            dt.Columns.Add("Kitap Adi:");
            dt.Columns.Add("Basim Yili:");
            dt.Columns.Add("Kitap Turu:");
            dt.Columns.Add("ID :");
            KitapDgv.DataSource = dt;

        }
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            double say;
            Kitap kitap = new Kitap();
            kitap.YazarAd = txtYazarAd.Text;
            kitap.KitapAd = txtKitapAdı.Text;
            if (double.TryParse(txtBasımYılı.Text, out say))
            {
                kitap.BasimYil = say;
            }
            else
            {
                MessageBox.Show("Geçersiz basım yılı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (double.TryParse(txtID.Text, out say))
            {
                kitap.ID = say;
            }
            else
            {
                MessageBox.Show("Geçersiz ID.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            kitap.KitapTur = txtTuru.Text;

            if (!string.IsNullOrWhiteSpace(kitap.YazarAd) && !string.IsNullOrWhiteSpace(kitap.KitapAd) && kitap.BasimYil != 0 && kitap.ID != 0)
            {
                Kitaplar.Add(kitap);
                kitap.TabloyaEkle(dt);
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            txtYazarAd.Text = "";
            txtKitapAdı.Text = "";
            txtBasımYılı.Text = "";
            txtTuru.Text = "";
            txtID.Text = "";  //ID
        }

        private void btnKitapKaydet_Click(object sender, EventArgs e)
        {
            string yazilacak = JsonSerializer.Serialize<List<Kitap>>(Kitaplar);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSON Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string dosya_yolu = dialog.FileName;
                File.WriteAllText(dosya_yolu, yazilacak, Encoding.UTF8);
            }
        }

        private void btnKitapYükle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(dialog.FileName);
                Kitaplar = JsonSerializer.Deserialize<List<Kitap>>(data);

                foreach (Kitap kitap in Kitaplar)
                {
                    kitap.TabloyaEkle(dt);
                }
            }
        }
    }
}
