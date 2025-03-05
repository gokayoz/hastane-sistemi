using MHRSSistemi.UI.Models;

namespace MHRSSistemi.UI
{
    public partial class FRMRandevu : Form
    {
        private Randevu[] randevular;
        public FRMRandevu(Randevu[] array) : this()
        {
            this.randevular = array;

            ListeyiGuncelle(DateTime.Today, DateTime.Today);
        }

        private void ListeyiGuncelle(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            lvZRaporu.Items.Clear();

            var filtrelenmisRandevular = randevular
                .Where(r => r.RandevuTarihi.Date >= baslangicTarihi && r.RandevuTarihi.Date <= bitisTarihi)
                .ToList();

            foreach (var item in filtrelenmisRandevular)
            {
                ListViewItem listViewItem = new ListViewItem(item.Hasta.HastaAdSoyadi);

                listViewItem.SubItems.Add(item.Hasta.Doktor.Bolum.ToString());
                listViewItem.SubItems.Add(item.Hasta.Doktor.ToString());
                listViewItem.SubItems.Add(item.Hasta.HastaSikayeti);
                listViewItem.SubItems.Add(item.RandevuTarihi.ToShortDateString());

                lvZRaporu.Items.Add(listViewItem);
            }
        }
        public FRMRandevu()
        {
            InitializeComponent();
        }

        private void dtpBaslangic_ValueChanged(object sender, EventArgs e)
        {
            ListeyiGuncelle(dtpBaslangic.Value.Date, dtpBitis.Value.Date);
        }

        private void dtpBitis_ValueChanged(object sender, EventArgs e)
        {
            ListeyiGuncelle(dtpBaslangic.Value.Date, dtpBitis.Value.Date);
        }

        private void FRMRandevu_Load(object sender, EventArgs e)
        {
            lvZRaporu.View = View.Details;
            lvZRaporu.GridLines = true;
            lvZRaporu.Columns.Add("Hasta Adı Soyadı", 160);
            lvZRaporu.Columns.Add("Bölüm Adı ", 160);
            lvZRaporu.Columns.Add("Doktor Adı Soyadı", 160);
            lvZRaporu.Columns.Add("Şikayet", 160);
            lvZRaporu.Columns.Add("Tarih", 160);
        }
    }
}
