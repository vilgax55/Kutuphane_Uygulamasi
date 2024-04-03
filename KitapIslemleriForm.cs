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

            KitapDgv.CellEndEdit += KitapDgv_CellEndEdit;

        }
        // ** ESKİ KİTAP EKLE 
        //private void btnKitapEkle_Click(object sender, EventArgs e)
        //{
        //    if(string.IsNullOrWhiteSpace(txtID.Text) || 
        //       string.IsNullOrWhiteSpace(txtKitapAdı.Text) ||
        //       string.IsNullOrWhiteSpace(txtBasımYılı.Text) ||
        //       string.IsNullOrWhiteSpace(txtTuru.Text) ||
        //       string.IsNullOrWhiteSpace(txtYazarAd.Text))
        //    {
        //        MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.","Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }
        //    Kitap kitap = new Kitap();
        //    kitap.YazarAd = txtYazarAd.Text;
        //    kitap.KitapAd = txtKitapAdı.Text;
        //    kitap.BasimYil = Convert.ToDouble(txtBasımYılı.Text);
        //    kitap.KitapTur = txtTuru.Text;  
        //    kitap.ID = Convert.ToDouble(txtID.Text);

        //    kitap.TabloyaEkle(dt);
        //    Kitaplar.Add(kitap);

        //    txtYazarAd.Text = "";
        //    txtKitapAdı.Text = "";
        //    txtBasımYılı.Text = "";
        //    txtTuru.Text = "";
        //    txtID.Text = "";  //ID
        //}

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

                if(string.IsNullOrWhiteSpace(data))
                {
                    MessageBox.Show("Yüklenecek veri bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try 
                {
                    Kitaplar = JsonSerializer.Deserialize<List<Kitap>>(data);

                    foreach ( Kitap kitap in Kitaplar)
                    {
                        kitap.TabloyaEkle(dt);
                    }
                }
                catch(JsonException)
                {
                    MessageBox.Show("Geçersiz JSON formatı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) ||
               string.IsNullOrWhiteSpace(txtKitapAdı.Text) ||
               string.IsNullOrWhiteSpace(txtBasımYılı.Text) ||
               string.IsNullOrWhiteSpace(txtTuru.Text) ||
               string.IsNullOrWhiteSpace(txtYazarAd.Text))
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Kitap kitap = new Kitap();
            kitap.YazarAd = txtYazarAd.Text;
            kitap.KitapAd = txtKitapAdı.Text;
            kitap.BasimYil = Convert.ToDouble(txtBasımYılı.Text);
            kitap.KitapTur = txtTuru.Text;
            kitap.ID = Convert.ToDouble(txtID.Text);

            kitap.TabloyaEkle(dt);
            Kitaplar.Add(kitap);

            txtYazarAd.Text = "";
            txtKitapAdı.Text = "";
            txtBasımYılı.Text = "";
            txtTuru.Text = "";
            txtID.Text = "";  //ID
        }

        private void KitapDgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = KitapDgv.Rows[rowIndex];

            int ID;
            if (!int.TryParse(row.Cells["ID :"].Value?.ToString(), out ID))
            {
                MessageBox.Show("Geçersiz ID numarası.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string yazarAdi = row.Cells["Yazar Adi:"].Value?.ToString();
            string kitapAdi = row.Cells["Kitap Adi:"].Value?.ToString();

            int basimYili;
            if (!int.TryParse(row.Cells["Basim Yili:"].Value?.ToString(), out basimYili))
            {
                MessageBox.Show("Geçersiz basım yılı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string kitapTuru = row.Cells["Kitap Turu:"].Value?.ToString();

            var existingKitapIndex = Kitaplar.FindIndex(k => k.ID == ID);

            if (existingKitapIndex != -1)
            {
                var existingKitap = Kitaplar[existingKitapIndex];
                existingKitap.YazarAd = yazarAdi;
                existingKitap.KitapAd = kitapAdi;
                existingKitap.BasimYil = basimYili;
                existingKitap.KitapTur = kitapTuru;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (KitapDgv.SelectedCells.Count > 0)
            {
                int selectedRowIndex = KitapDgv.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = KitapDgv.Rows[selectedRowIndex];

                // Get the value from the appropriate column
                double kitapID = Convert.ToDouble(selectedRow.Cells["ID :"].Value);

                KitapDgv.Rows.Remove(selectedRow);
                Kitaplar.RemoveAll(k => k.ID == kitapID);
            }
        }
    }
}
