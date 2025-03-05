namespace MHRSSistemi.UI
{
    partial class FRMRandevu
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
            btnDokumanOlustur = new Button();
            dtpBaslangic = new DateTimePicker();
            lvZRaporu = new ListView();
            dtpBitis = new DateTimePicker();
            SuspendLayout();
            // 
            // btnDokumanOlustur
            // 
            btnDokumanOlustur.Location = new Point(282, 391);
            btnDokumanOlustur.Name = "btnDokumanOlustur";
            btnDokumanOlustur.Size = new Size(194, 29);
            btnDokumanOlustur.TabIndex = 0;
            btnDokumanOlustur.Text = "Döküman Oluştur";
            btnDokumanOlustur.UseVisualStyleBackColor = true;
            // 
            // dtpBaslangic
            // 
            dtpBaslangic.Location = new Point(33, 28);
            dtpBaslangic.Name = "dtpBaslangic";
            dtpBaslangic.Size = new Size(250, 27);
            dtpBaslangic.TabIndex = 1;
            dtpBaslangic.ValueChanged += dtpBaslangic_ValueChanged;
            // 
            // lvZRaporu
            // 
            lvZRaporu.Location = new Point(33, 98);
            lvZRaporu.Name = "lvZRaporu";
            lvZRaporu.Size = new Size(732, 276);
            lvZRaporu.TabIndex = 2;
            lvZRaporu.UseCompatibleStateImageBehavior = false;
            // 
            // dtpBitis
            // 
            dtpBitis.Location = new Point(503, 28);
            dtpBitis.Name = "dtpBitis";
            dtpBitis.Size = new Size(250, 27);
            dtpBitis.TabIndex = 1;
            dtpBitis.ValueChanged += dtpBitis_ValueChanged;
            // 
            // FRMRandevu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvZRaporu);
            Controls.Add(dtpBitis);
            Controls.Add(dtpBaslangic);
            Controls.Add(btnDokumanOlustur);
            Name = "FRMRandevu";
            Text = "FRMRandevu";
            Load += FRMRandevu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDokumanOlustur;
        private DateTimePicker dtpBaslangic;
        private ListView lvZRaporu;
        private DateTimePicker dtpBitis;
    }
}