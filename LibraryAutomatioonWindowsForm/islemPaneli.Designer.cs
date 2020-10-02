namespace LibraryAutomatioonWindowsForm
{
    partial class islemPaneli
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.kullaniciBilgiPanel = new System.Windows.Forms.Panel();
            this.btnKulanicilar = new System.Windows.Forms.Button();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.btnSil);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Controls.Add(this.btnEkle);
            this.panel1.Controls.Add(this.btnKulanicilar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 461);
            this.panel1.TabIndex = 0;
            // 
            // kullaniciBilgiPanel
            // 
            this.kullaniciBilgiPanel.BackColor = System.Drawing.Color.Teal;
            this.kullaniciBilgiPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.kullaniciBilgiPanel.Location = new System.Drawing.Point(200, 0);
            this.kullaniciBilgiPanel.Name = "kullaniciBilgiPanel";
            this.kullaniciBilgiPanel.Size = new System.Drawing.Size(654, 34);
            this.kullaniciBilgiPanel.TabIndex = 1;
            // 
            // btnKulanicilar
            // 
            this.btnKulanicilar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnKulanicilar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKulanicilar.FlatAppearance.BorderSize = 0;
            this.btnKulanicilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKulanicilar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKulanicilar.Location = new System.Drawing.Point(0, 0);
            this.btnKulanicilar.Name = "btnKulanicilar";
            this.btnKulanicilar.Size = new System.Drawing.Size(200, 55);
            this.btnKulanicilar.TabIndex = 0;
            this.btnKulanicilar.Text = "Kullanıcılar";
            this.btnKulanicilar.UseVisualStyleBackColor = false;
            this.btnKulanicilar.Click += new System.EventHandler(this.btnKulanicilar_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnEkle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Location = new System.Drawing.Point(0, 55);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(200, 55);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = false;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnGuncelle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Location = new System.Drawing.Point(0, 110);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(200, 55);
            this.btnGuncelle.TabIndex = 2;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            // 
            // btnSil
            // 
            this.btnSil.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Location = new System.Drawing.Point(0, 165);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(200, 55);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = false;
            // 
            // islemPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 461);
            this.Controls.Add(this.kullaniciBilgiPanel);
            this.Controls.Add(this.panel1);
            this.Name = "islemPaneli";
            this.Text = "islemPaneli";
            this.Load += new System.EventHandler(this.islemPaneli_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnKulanicilar;
        private System.Windows.Forms.Panel kullaniciBilgiPanel;
    }
}