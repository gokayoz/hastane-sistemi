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
            mtxtTelefonu.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals; // kullanıldığında yalnızca girilen rakamlar döner
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Doktor doktor = new Doktor
                {
                    DoktorAdSoyadi = txtDoktorBilgileri.Text,
                    Bolum = (Bolum)cmbBolumler.SelectedItem,
                    DoktorTelefonu = mtxtTelefonu.Text
                };

                doktorlar.Add(doktor);
                Temizle();

                lstbDoktorlar.Items.Add(doktor);
                MessageBox.Show("Doktor başarıyla eklendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Temizle()
        {
            txtDoktorBilgileri.Text = string.Empty;
            mtxtTelefonu.Text = string.Empty;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstbDoktorlar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen silmek için bir doktor seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            lstbDoktorlar.Items.Remove(lstbDoktorlar.SelectedItem);
            MessageBox.Show("Doktor başarıyla silindi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstbDoktorlar.SelectedItem == null)
            {
                MessageBox.Show("Lütfen güncellemek için bir doktor seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Doktor seciliDoktor = lstbDoktorlar.SelectedItem as Doktor;

                seciliDoktor.DoktorAdSoyadi = txtDoktorBilgileri.Text;
                seciliDoktor.DoktorTelefonu = mtxtTelefonu.Text;
                seciliDoktor.Bolum = (Bolum)cmbBolumler.SelectedItem;

                int index = lstbDoktorlar.SelectedIndex;
                lstbDoktorlar.Items[index] = seciliDoktor;

                Temizle();
                MessageBox.Show("Doktor başarıyla güncellendi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGec_Click(object sender, EventArgs e)
        {
            Doktor[] doktorlar = new Doktor[0];

            foreach (Doktor doktor in lstbDoktorlar.Items)
            {
                Array.Resize(ref doktorlar, doktorlar.Length + 1);
                doktorlar[doktorlar.Length - 1] = doktor;
            }

            FRMHasta form3 = new FRMHasta(doktorlar);
            form3.Show();
        }
    }
}
