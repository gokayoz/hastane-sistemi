namespace MHRSSistemi.UI
{
    partial class FRMBolum
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEkle = new Button();
            txtBolumAdi = new TextBox();
            lstbBolumler = new ListBox();
            label1 = new Label();
            txtBolumAciklamasi = new TextBox();
            label2 = new Label();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnGec = new Button();
            SuspendLayout();
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(191, 139);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(110, 30);
            btnEkle.TabIndex = 0;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // txtBolumAdi
            // 
            txtBolumAdi.Location = new Point(158, 20);
            txtBolumAdi.Name = "txtBolumAdi";
            txtBolumAdi.Size = new Size(649, 27);
            txtBolumAdi.TabIndex = 1;
            // 
            // lstbBolumler
            // 
            lstbBolumler.FormattingEnabled = true;
            lstbBolumler.Location = new Point(119, 183);
            lstbBolumler.Name = "lstbBolumler";
            lstbBolumler.Size = new Size(688, 164);
            lstbBolumler.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 23);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 3;
            label1.Text = "Bölüm Adı:";
            // 
            // txtBolumAciklamasi
            // 
            txtBolumAciklamasi.Location = new Point(158, 59);
            txtBolumAciklamasi.Multiline = true;
            txtBolumAciklamasi.Name = "txtBolumAciklamasi";
            txtBolumAciklamasi.Size = new Size(649, 60);
            txtBolumAciklamasi.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 76);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 3;
            label2.Text = "Bölüm Açıklaması:";
            // 
            // btnSil
            // 
            btnSil.Location = new Point(406, 139);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(110, 30);
            btnSil.TabIndex = 0;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(640, 139);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(110, 30);
            btnGuncelle.TabIndex = 0;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnGec
            // 
            btnGec.Location = new Point(119, 372);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(688, 29);
            btnGec.TabIndex = 0;
            btnGec.Text = ">>>>>>>>>>>>>>>>>>>>>>";
            btnGec.UseVisualStyleBackColor = true;
            btnGec.Click += btnGec_Click;
            // 
            // FRMBolum
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 421);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtBolumAciklamasi);
            Controls.Add(lstbBolumler);
            Controls.Add(txtBolumAdi);
            Controls.Add(btnGec);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Name = "FRMBolum";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bölüm Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEkle;
        private TextBox txtBolumAdi;
        private ListBox lstbBolumler;
        private Label label1;
        private TextBox txtBolumAciklamasi;
        private Label label2;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnGec;
    }
}
