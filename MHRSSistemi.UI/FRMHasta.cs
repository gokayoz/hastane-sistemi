using MHRSSistemi.UI.Models;

namespace MHRSSistemi.UI
{
    public partial class FRMHasta : Form
    {
        private Doktor[] doktorlar;
        public FRMHasta(Doktor[] doktorlar) : this()
        {
            foreach (Doktor doktor in doktorlar)
            {
                cmbDoktorAdSoyadi.Items.Add(doktor);
            }
        }

        public FRMHasta()
        {
            InitializeComponent();
        }

        private void btnRandevuOlustur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHastaAdSoyadi.Text) || cmbDoktorAdSoyadi == null || string.IsNullOrWhiteSpace(txtHastaSikayeti.Text))
            {
                MessageBox.Show("Tüm alanları doldurunuz!");
                return;
            }

            if (dtpTarih.Value < DateTime.Today)
            {
                MessageBox.Show("Geçmiş tarihe randevu alamazsınız!");
            }

            Hasta hasta = new()
            {
                HastaAdSoyadi = txtHastaAdSoyadi.Text,
                HastaSikayeti = txtHastaSikayeti.Text,
                Doktor = cmbDoktorAdSoyadi.SelectedItem as Doktor
            };

            Randevu randevu = new()
            {
                Hasta = hasta,
                RandevuTarihi = dtpTarih.Value.Date
            };

            lstRandevular.Items.Add(randevu);

            Temizle();

            MessageBox.Show("Randevu başarıyla eklendi.");
        }

        private void Temizle()
        {
            txtHastaAdSoyadi.Text = txtHastaSikayeti.Text = string.Empty;
        }

        private void btnZRaporu_Click(object sender, EventArgs e)
        {
            Randevu[] randevular = new Randevu[lstRandevular.Items.Count];
            lstRandevular.Items.CopyTo(randevular, 0);

            FRMRandevu form4 = new FRMRandevu(randevular);
            form4.Show();
        }
    }
}
