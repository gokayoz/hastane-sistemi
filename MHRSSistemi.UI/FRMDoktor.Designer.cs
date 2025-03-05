namespace MHRSSistemi.UI
{
    partial class FRMDoktor
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
            cmbBolumler = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            lstbDoktorlar = new ListBox();
            txtDoktorBilgileri = new TextBox();
            btnGec = new Button();
            btnGuncelle = new Button();
            btnSil = new Button();
            btnEkle = new Button();
            label3 = new Label();
            mtxtTelefonu = new MaskedTextBox();
            SuspendLayout();
            // 
            // cmbBolumler
            // 
            cmbBolumler.FormattingEnabled = true;
            cmbBolumler.Location = new Point(217, 104);
            cmbBolumler.Name = "cmbBolumler";
            cmbBolumler.Size = new Size(358, 28);
            cmbBolumler.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 107);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 11;
            label2.Text = "Bölüm Seçimi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 30);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 12;
            label1.Text = "Doktor Bilgileri:";
            // 
            // lstbDoktorlar
            // 
            lstbDoktorlar.FormattingEnabled = true;
            lstbDoktorlar.Location = new Point(119, 196);
            lstbDoktorlar.Name = "lstbDoktorlar";
            lstbDoktorlar.Size = new Size(688, 164);
            lstbDoktorlar.TabIndex = 10;
            // 
            // txtDoktorBilgileri
            // 
            txtDoktorBilgileri.Location = new Point(217, 27);
            txtDoktorBilgileri.Name = "txtDoktorBilgileri";
            txtDoktorBilgileri.Size = new Size(592, 27);
            txtDoktorBilgileri.TabIndex = 9;
            // 
            // btnGec
            // 
            btnGec.Location = new Point(119, 385);
            btnGec.Name = "btnGec";
            btnGec.Size = new Size(688, 29);
            btnGec.TabIndex = 4;
            btnGec.Text = ">>>>>>>>>>>>>>>>>>>>>>";
            btnGec.UseVisualStyleBackColor = true;
            btnGec.Click += btnGec_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.Location = new Point(640, 152);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(110, 30);
            btnGuncelle.TabIndex = 5;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = true;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(406, 152);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(110, 30);
            btnSil.TabIndex = 6;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(191, 152);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(110, 30);
            btnEkle.TabIndex = 7;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(69, 67);
            label3.Name = "label3";
            label3.Size = new Size(119, 20);
            label3.TabIndex = 12;
            label3.Text = "Doktor Telefonu:";
            // 
            // mtxtTelefonu
            // 
            mtxtTelefonu.Location = new Point(217, 64);
            mtxtTelefonu.Mask = "(999) 000-0000";
            mtxtTelefonu.Name = "mtxtTelefonu";
            mtxtTelefonu.Size = new Size(215, 27);
            mtxtTelefonu.TabIndex = 13;
            // 
            // FRMDoktor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 434);
            Controls.Add(mtxtTelefonu);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(lstbDoktorlar);
            Controls.Add(txtDoktorBilgileri);
            Controls.Add(btnGec);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnEkle);
            Controls.Add(cmbBolumler);
            Name = "FRMDoktor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doktor Ekranı";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbBolumler;
        private Label label2;
        private Label label1;
        private ListBox lstbDoktorlar;
        private TextBox txtDoktorBilgileri;
        private Button btnGec;
        private Button btnGuncelle;
        private Button btnSil;
        private Button btnEkle;
        private Label label3;
        private MaskedTextBox mtxtTelefonu;
    }
}