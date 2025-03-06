using ClosedXML.Excel;
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
        private void btnDokumanOlustur_Click(object sender, EventArgs e)
        {
            DateTime baslangicTarihi = dtpBaslangic.Value.Date;
            DateTime bitisTarihi = dtpBitis.Value.Date;

            ListeyiGuncelle(baslangicTarihi, bitisTarihi);

            try
            {
                using (var workbook = new XLWorkbook())
                {
                    var workSheet = workbook.AddWorksheet("ZRaporu");

                    workSheet.Cell(1, 1).Value = "Hasta Adı Soyad";
                    workSheet.Cell(1, 2).Value = "Bölüm";
                    workSheet.Cell(1, 3).Value = "Doktor";
                    workSheet.Cell(1, 4).Value = "Şikayet";
                    workSheet.Cell(1, 5).Value = "Tarih";

                    int satir = 2;
                    foreach (ListViewItem item in lvZRaporu.Items)
                    {
                        workSheet.Cell(satir, 1).Value = item.SubItems[0].Text;
                        workSheet.Cell(satir, 2).Value = item.SubItems[1].Text;
                        workSheet.Cell(satir, 3).Value = item.SubItems[2].Text;
                        workSheet.Cell(satir, 4).Value = item.SubItems[3].Text;
                        workSheet.Cell(satir, 5).Value = item.SubItems[4].Text;
                        satir++;
                    }

                    using (SaveFileDialog saveFileDialog = new())
                    {
                        saveFileDialog.Filter = "Excel Files|*xlsx";
                        saveFileDialog.Title = "Excel Dosyasını Kaydet";
                        saveFileDialog.FileName = "ZRaporu.xlsx";

                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string filePath = saveFileDialog.FileName;
                            workbook.SaveAs(filePath);
                            MessageBox.Show("Excel Başarıyla Oluşturuldu.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
