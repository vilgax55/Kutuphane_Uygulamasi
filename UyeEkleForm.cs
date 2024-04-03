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
    public partial class UyeEkleForm : Form
    {
        private DataTable dt;
        private List<Uye> uyeler;

        public UyeEkleForm()
        {
            InitializeComponent();
            uyeler = new List<Uye>();
            dt = new DataTable();
            dt.Columns.Add("TC:");
            dt.Columns.Add("Adı:");
            dt.Columns.Add("Soyadı:");
            dt.Columns.Add("telefon :");


            UyelerDgv.DataSource = dt;
            UyelerDgv.CellEndEdit += UyelerDgv_CellEndEdit;
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtTc.Text) ||
                string.IsNullOrWhiteSpace(txtAd.Text) ||
                string.IsNullOrWhiteSpace(txtSoyad.Text) ||
                string.IsNullOrWhiteSpace(txtTelNo.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Uye uye = new Uye();
            uye.UyeTc = Convert.ToDouble(txtTc.Text);
            uye.UyeAdi = txtAd.Text;
            uye.UyeSoyadi = txtSoyad.Text;
            uye.UyeTelNo = Convert.ToDouble(txtTelNo.Text);
            uye.TabloyaEkle(dt);
            uyeler.Add(uye);

            txtTc.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelNo.Text = "";
        }

        // ** ESKİ KAYDET BUTONUM : 
        //private void btnKaydet_Click(object sender, EventArgs e)
        //{
        //    if (uyeler.Count == 0)
        //    {
        //        MessageBox.Show("Kaydedilecek veri bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //        return;
        //    }

        //    string yazilacak = JsonSerializer.Serialize<List<Uye>>(uyeler);

        //    SaveFileDialog dialog = new SaveFileDialog();
        //    dialog.Filter = "JSON Dosyası|*.json";
        //    if (dialog.ShowDialog() == DialogResult.OK)
        //    {
        //        string dosya_yolu = dialog.FileName;
        //        File.WriteAllText(dosya_yolu, yazilacak, Encoding.UTF8);
        //    }
        //}

        private void btnYukle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(dialog.FileName);

                if (string.IsNullOrWhiteSpace(data))
                {
                    MessageBox.Show("Yüklenecek veri bulunmamaktadır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    uyeler = JsonSerializer.Deserialize<List<Uye>>(data);

                    foreach (Uye uye in uyeler)
                    {
                        uye.TabloyaEkle(dt);
                    }
                }
                catch (JsonException)
                {
                    MessageBox.Show("Geçersiz JSON formatı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void UyelerDgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = UyelerDgv.Rows[rowIndex];

            double tc;
            if (!double.TryParse(row.Cells["TC:"].Value?.ToString(), out tc))
            {
                MessageBox.Show("Geçersiz TC numarası.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ad = row.Cells["Adı:"].Value?.ToString();
            string soyad = row.Cells["Soyadı:"].Value?.ToString();

            double telNo;
            if (!double.TryParse(row.Cells["telefon :"].Value?.ToString(), out telNo))
            {
                MessageBox.Show("Geçersiz telefon numarası.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var existingUyeIndex = uyeler.FindIndex(u => u.UyeTc == tc);

            if (existingUyeIndex != -1)
            {
                var existingUye = uyeler[existingUyeIndex];
                existingUye.UyeAdi = ad;
                existingUye.UyeSoyadi = soyad;
                existingUye.UyeTelNo = telNo;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string yazilacak = JsonSerializer.Serialize<List<Uye>>(uyeler);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSON Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string dosya_yolu = dialog.FileName;
                File.WriteAllText(dosya_yolu, yazilacak, Encoding.UTF8);
            }
        }

        private void btnGuncelleKaydet_Click(object sender, EventArgs e)
        {
            UyelerDgv.EndEdit();
            btnKaydet_Click(sender, e);
        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (UyelerDgv.SelectedCells.Count > 0)
            {
                int selectedRowIndex = UyelerDgv.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = UyelerDgv.Rows[selectedRowIndex];

                double tc = Convert.ToDouble(selectedRow.Cells["TC:"].Value);
               
                UyelerDgv.Rows.Remove(selectedRow);
                uyeler.RemoveAll(u => u.UyeTc == tc);
            }
        }

    }
}