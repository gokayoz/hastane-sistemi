using MHRSSistemi.UI.Models;

namespace MHRSSistemi.UI
{
    public partial class FRMDoktor : Form
    {
        private Bolum[] bolumDizisi;

        List<Doktor> doktorlar = new();
        public FRMDoktor(Bolum[] bolumDizisi)
        {
            InitializeComponent();
            this.bolumDizisi = bolumDizisi;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cmbBolumler.DataSource = bolumDizisi;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDoktorBilgileri.Text))
            {
                MessageBox.Show("Doktor bilgileri boş olamaz!");
                return;
            }
            try
            {
                var doktor = new Doktor
                {
                    DoktorAdSoyadi = txtDoktorBilgileri.Text,
                    Bolum = (Bolum)cmbBolumler.SelectedItem,
                    DoktorTelefonu = mtxtTelefonu.Text
                };
                doktorlar.Add(doktor);
                Temizle();

                lstbDoktorlar.Items.Add(doktor);
                MessageBox.Show("Doktor başarıyla eklenmiştir.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Temizle()
        {
            txtDoktorBilgileri.Text = string.Empty;
            mtxtTelefonu.Text = string.Empty;
        }
        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            if (lstbDoktorlar.SelectedItem == null)
            {
                MessageBox.Show("Güncellemek istediğiniz doktoru seçiniz!");
                return;
            }
            Doktor seciliDoktor = lstbDoktorlar.SelectedItem as Doktor;

            seciliDoktor.DoktorAdSoyadi = txtDoktorBilgileri.Text;
            seciliDoktor.DoktorTelefonu = mtxtTelefonu.Text;
            seciliDoktor.Bolum.BolumAdi = cmbBolumler.SelectedItem.ToString();

            int index = lstbDoktorlar.SelectedIndex;
            lstbDoktorlar.Items[index] = seciliDoktor;

            Temizle();
            MessageBox.Show("Doktor başarıyla güncellendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstbDoktorlar.SelectedItem == null)
            {
                MessageBox.Show("Lüttfen bölüm seçiniz!");
                return;
            }
            lstbDoktorlar.Items.Remove(lstbDoktorlar.SelectedItem);
            MessageBox.Show("Doktor başarıyla silindi.");
        }
    }
}
