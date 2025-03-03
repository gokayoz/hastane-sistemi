namespace MHRSSistemi.UI
{
    partial class Form2
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
            SuspendLayout();
            // 
            // cmbBolumler
            // 
            cmbBolumler.FormattingEnabled = true;
            cmbBolumler.Location = new Point(53, 75);
            cmbBolumler.Name = "cmbBolumler";
            cmbBolumler.Size = new Size(293, 28);
            cmbBolumler.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 274);
            Controls.Add(cmbBolumler);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bölümler";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmbBolumler;
    }
}