namespace Kütüphane_Uygulaması
{
    partial class EmanetIslemleriForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmanetIslemleriForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSonTarih = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKitapID = new System.Windows.Forms.TextBox();
            this.txtAlanTc = new System.Windows.Forms.TextBox();
            this.btnEmanetVerme = new System.Windows.Forms.Button();
            this.EmanetDgv = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.TsmDosya = new System.Windows.Forms.ToolStripSplitButton();
            this.TsmKaydet = new System.Windows.Forms.ToolStripMenuItem();
            this.TsmYükle = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmanetDgv)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap ID";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Controls.Add(this.txtSonTarih);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKitapID);
            this.groupBox1.Controls.Add(this.txtAlanTc);
            this.groupBox1.Controls.Add(this.btnEmanetVerme);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(0, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 409);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Emanet Verme";
            // 
            // txtSonTarih
            // 
            this.txtSonTarih.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSonTarih.Location = new System.Drawing.Point(243, 159);
            this.txtSonTarih.Name = "txtSonTarih";
            this.txtSonTarih.Size = new System.Drawing.Size(174, 27);
            this.txtSonTarih.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Son Tarih";
            // 
            // txtKitapID
            // 
            this.txtKitapID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKitapID.Location = new System.Drawing.Point(243, 102);
            this.txtKitapID.Name = "txtKitapID";
            this.txtKitapID.Size = new System.Drawing.Size(174, 27);
            this.txtKitapID.TabIndex = 3;
            // 
            // txtAlanTc
            // 
            this.txtAlanTc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAlanTc.Location = new System.Drawing.Point(243, 218);
            this.txtAlanTc.Name = "txtAlanTc";
            this.txtAlanTc.Size = new System.Drawing.Size(174, 27);
            this.txtAlanTc.TabIndex = 4;
            // 
            // btnEmanetVerme
            // 
            this.btnEmanetVerme.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmanetVerme.BackColor = System.Drawing.Color.LightBlue;
            this.btnEmanetVerme.Location = new System.Drawing.Point(243, 340);
            this.btnEmanetVerme.Name = "btnEmanetVerme";
            this.btnEmanetVerme.Size = new System.Drawing.Size(135, 52);
            this.btnEmanetVerme.TabIndex = 2;
            this.btnEmanetVerme.Text = "Emaneti Ver";
            this.btnEmanetVerme.UseVisualStyleBackColor = false;
            this.btnEmanetVerme.Click += new System.EventHandler(this.btnEmanetVerme_Click);
            // 
            // EmanetDgv
            // 
            this.EmanetDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmanetDgv.Location = new System.Drawing.Point(633, 82);
            this.EmanetDgv.Name = "EmanetDgv";
            this.EmanetDgv.RowHeadersWidth = 51;
            this.EmanetDgv.RowTemplate.Height = 24;
            this.EmanetDgv.Size = new System.Drawing.Size(664, 409);
            this.EmanetDgv.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.LightBlue;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmDosya});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1309, 27);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // TsmDosya
            // 
            this.TsmDosya.BackColor = System.Drawing.Color.Plum;
            this.TsmDosya.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TsmDosya.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsmKaydet,
            this.TsmYükle});
            this.TsmDosya.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TsmDosya.Image = ((System.Drawing.Image)(resources.GetObject("TsmDosya.Image")));
            this.TsmDosya.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TsmDosya.Name = "TsmDosya";
            this.TsmDosya.Size = new System.Drawing.Size(69, 24);
            this.TsmDosya.Text = "Dosya";
            // 
            // TsmKaydet
            // 
            this.TsmKaydet.Name = "TsmKaydet";
            this.TsmKaydet.Size = new System.Drawing.Size(138, 26);
            this.TsmKaydet.Text = "Kaydet";
            this.TsmKaydet.Click += new System.EventHandler(this.TsmKaydet_Click);
            // 
            // TsmYükle
            // 
            this.TsmYükle.Name = "TsmYükle";
            this.TsmYükle.Size = new System.Drawing.Size(138, 26);
            this.TsmYükle.Text = "Yükle";
            this.TsmYükle.Click += new System.EventHandler(this.TsmYükle_Click);
            // 
            // EmanetIslemleriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1309, 644);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.EmanetDgv);
            this.Controls.Add(this.groupBox1);
            this.Name = "EmanetIslemleriForm";
            this.Text = "Emanet İşlemleri";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmanetDgv)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKitapID;
        private System.Windows.Forms.TextBox txtAlanTc;
        private System.Windows.Forms.Button btnEmanetVerme;
        private System.Windows.Forms.TextBox txtSonTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView EmanetDgv;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSplitButton TsmDosya;
        private System.Windows.Forms.ToolStripMenuItem TsmKaydet;
        private System.Windows.Forms.ToolStripMenuItem TsmYükle;
    }
}