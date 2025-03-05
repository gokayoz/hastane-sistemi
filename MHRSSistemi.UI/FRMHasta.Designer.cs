namespace MHRSSistemi.UI
{
    partial class FRMHasta
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
            lstRandevular = new ListBox();
            label1 = new Label();
            btnZRaporu = new Button();
            txtHastaAdSoyadi = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtHastaSikayeti = new TextBox();
            dtpTarih = new DateTimePicker();
            btnRandevuOlustur = new Button();
            cmbDoktorAdSoyadi = new ComboBox();
            SuspendLayout();
            // 
            // lstRandevular
            // 
            lstRandevular.FormattingEnabled = true;
            lstRandevular.Location = new Point(12, 413);
            lstRandevular.Name = "lstRandevular";
            lstRandevular.Size = new Size(624, 264);
            lstRandevular.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 41);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 1;
            label1.Text = "Ad Soyad:";
            // 
            // btnZRaporu
            // 
            btnZRaporu.Location = new Point(12, 357);
            btnZRaporu.Name = "btnZRaporu";
            btnZRaporu.Size = new Size(94, 29);
            btnZRaporu.TabIndex = 2;
            btnZRaporu.Text = "Z Raporu";
            btnZRaporu.UseVisualStyleBackColor = true;
            btnZRaporu.Click += btnZRaporu_Click;
            // 
            // txtHastaAdSoyadi
            // 
            txtHastaAdSoyadi.Location = new Point(145, 38);
            txtHastaAdSoyadi.Name = "txtHastaAdSoyadi";
            txtHastaAdSoyadi.Size = new Size(371, 27);
            txtHastaAdSoyadi.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 119);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Doktor:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 82);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 1;
            label3.Text = "Tarih:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 163);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 1;
            label4.Text = "Sikayet:";
            // 
            // txtHastaSikayeti
            // 
            txtHastaSikayeti.Location = new Point(145, 160);
            txtHastaSikayeti.Multiline = true;
            txtHastaSikayeti.Name = "txtHastaSikayeti";
            txtHastaSikayeti.Size = new Size(371, 226);
            txtHastaSikayeti.TabIndex = 3;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(145, 77);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(371, 27);
            dtpTarih.TabIndex = 4;
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.Location = new Point(542, 357);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(94, 29);
            btnRandevuOlustur.TabIndex = 2;
            btnRandevuOlustur.Text = "OLUŞTUR";
            btnRandevuOlustur.UseVisualStyleBackColor = true;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click;
            // 
            // cmbDoktorAdSoyadi
            // 
            cmbDoktorAdSoyadi.FormattingEnabled = true;
            cmbDoktorAdSoyadi.Location = new Point(145, 119);
            cmbDoktorAdSoyadi.Name = "cmbDoktorAdSoyadi";
            cmbDoktorAdSoyadi.Size = new Size(371, 28);
            cmbDoktorAdSoyadi.TabIndex = 5;
            // 
            // FRMHasta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(653, 690);
            Controls.Add(cmbDoktorAdSoyadi);
            Controls.Add(dtpTarih);
            Controls.Add(txtHastaSikayeti);
            Controls.Add(txtHastaAdSoyadi);
            Controls.Add(btnRandevuOlustur);
            Controls.Add(btnZRaporu);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstRandevular);
            Name = "FRMHasta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hasta Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstRandevular;
        private Label label1;
        private Button btnZRaporu;
        private TextBox txtHastaAdSoyadi;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtHastaSikayeti;
        private DateTimePicker dtpTarih;
        private Button btnRandevuOlustur;
        private ComboBox cmbDoktorAdSoyadi;
    }
}