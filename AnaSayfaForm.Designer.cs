namespace Kütüphane_Uygulaması
{
    partial class AnaSayfaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEmanetiAlma = new System.Windows.Forms.Button();
            this.btnEmanetVerme = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnKitapEkle);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(659, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap İşlemleri";
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapEkle.Location = new System.Drawing.Point(158, 94);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(132, 33);
            this.btnKitapEkle.TabIndex = 1;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(44, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Ekle";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnUyeEkle);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(18, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(326, 230);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Üye İşlemleri";
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUyeEkle.Location = new System.Drawing.Point(161, 100);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(93, 33);
            this.btnUyeEkle.TabIndex = 1;
            this.btnUyeEkle.Text = "Üye Ekle";
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(20, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Üye Ekleme";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnEmanetiAlma);
            this.groupBox3.Controls.Add(this.btnEmanetVerme);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(291, 304);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(423, 236);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet İşlemleri";
            // 
            // btnEmanetiAlma
            // 
            this.btnEmanetiAlma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmanetiAlma.Location = new System.Drawing.Point(189, 143);
            this.btnEmanetiAlma.Name = "btnEmanetiAlma";
            this.btnEmanetiAlma.Size = new System.Drawing.Size(174, 33);
            this.btnEmanetiAlma.TabIndex = 1;
            this.btnEmanetiAlma.Text = "Emaneti Alma";
            this.btnEmanetiAlma.UseVisualStyleBackColor = true;
            // 
            // btnEmanetVerme
            // 
            this.btnEmanetVerme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmanetVerme.Location = new System.Drawing.Point(189, 77);
            this.btnEmanetVerme.Name = "btnEmanetVerme";
            this.btnEmanetVerme.Size = new System.Drawing.Size(174, 33);
            this.btnEmanetVerme.TabIndex = 1;
            this.btnEmanetVerme.Text = "Emanet Verme";
            this.btnEmanetVerme.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 20);
            this.label7.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Emaneti Alma";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Emanet Verme ";
            // 
            // AnaSayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGreen;
            this.ClientSize = new System.Drawing.Size(1006, 591);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnaSayfaForm";
            this.Text = "Ana Sayfa Ekranı";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.Button btnEmanetiAlma;
        private System.Windows.Forms.Button btnEmanetVerme;
    }
}

