using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kütüphane_Uygulaması
{
    public partial class EmanetIslemleriForm : Form
    {
        private BindingList<Emanet> Emanetler;

        public EmanetIslemleriForm()
        {
            InitializeComponent();
            Emanetler = new BindingList<Emanet>();
            EmanetDgv.DataSource = Emanetler;
        }

        private void TsmYükle_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "JSON Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string data = File.ReadAllText(dialog.FileName);
                Emanetler = JsonSerializer.Deserialize<BindingList<Emanet>>(data);


                EmanetDgv.DataSource = null;
                EmanetDgv.DataSource = Emanetler;
            }
        }

        private void btnEmanetVerme_Click(object sender, EventArgs e)
        {

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

            string yazilacak = JsonSerializer.Serialize<BindingList<Emanet>>(Emanetler);

            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "JSON Dosyası|*.json";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string dosya_yolu = dialog.FileName;
                File.WriteAllText(dosya_yolu, yazilacak, Encoding.UTF8);
            }
        }

 

        private void EmanetDgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = EmanetDgv.Rows[rowIndex];

            double kitapID;
            if (!double.TryParse(row.Cells["KitapID"].Value?.ToString(), out kitapID))
            {
                MessageBox.Show("Geçersiz kitap ID'si.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double sonTarih;
            if (!double.TryParse(row.Cells["SonTarih"].Value?.ToString(), out sonTarih))
            {
                MessageBox.Show("Geçersiz son tarih.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double tc;
            if (!double.TryParse(row.Cells["TC"].Value?.ToString(), out tc))
            {
                MessageBox.Show("Geçersiz TC numarası.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var updatedEmanet = Emanetler.FirstOrDefault(em => em.Tc == tc);

            if (updatedEmanet != null)
            {
                updatedEmanet.kitapID = kitapID;
                updatedEmanet.SonTarih = sonTarih;
            }
        }


        private void btnGuncelleKaydet_Click(object sender, EventArgs e)
        {
            EmanetDgv.EndEdit();
            TsmKaydet_Click(sender, e);
        }
    }
}
