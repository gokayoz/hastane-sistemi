using MHRSSistemi.UI.Models;

namespace MHRSSistemi.UI;

public partial class FRMBolum : Form
{
    List<Bolum> bolumler = new();
    public FRMBolum()
    {
        InitializeComponent();
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtBolumAdi.Text) || string.IsNullOrWhiteSpace(txtBolumAciklamasi.Text))
        {
            MessageBox.Show("Bölüm adý veya açýklamasý boþ olamaz!");
            return;
        }
        try
        {
            var bolum = new Bolum
            {
                BolumAdi = txtBolumAdi.Text,
                BolumAciklamasi = txtBolumAciklamasi.Text
            };
            bolumler.Add(bolum);
            Temizle();

            lstbBolumler.Items.Add(bolum);
            MessageBox.Show("Bölüm baþarýyla eklenmiþtir.");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
    }
    private void Temizle()
    {
        txtBolumAciklamasi.Text = txtBolumAdi.Text = string.Empty;
    }
    private void btnSil_Click(object sender, EventArgs e)
    {
        if (lstbBolumler.SelectedItem == null)
        {
            MessageBox.Show("Lüttfen bölüm seçiniz!");
            return;
        }
        lstbBolumler.Items.Remove(lstbBolumler.SelectedItem);
        MessageBox.Show("Bölüm baþarýyla silindi.");
    }
    private void btnGuncelle_Click(object sender, EventArgs e)
    {
        if (lstbBolumler.SelectedItem == null)
        {
            MessageBox.Show("Güncellemek istediðiniz bölümü seçiniz!");
            return;
        }
        Bolum seciliBolum = lstbBolumler.SelectedItem as Bolum;

        seciliBolum.BolumAdi = txtBolumAdi.Text;
        seciliBolum.BolumAciklamasi = txtBolumAciklamasi.Text;

        int index = lstbBolumler.SelectedIndex;
        lstbBolumler.Items[index] = seciliBolum;

        Temizle();
        MessageBox.Show("Bölüm baþarýyla güncellendi.");
    }

    private void btnGec_Click(object sender, EventArgs e)
    {
        Bolum[] bolumDizisi = new Bolum[0];

        foreach (Bolum bolum in lstbBolumler.Items)
        {
            Array.Resize(ref bolumDizisi, bolumDizisi.Length + 1);
            bolumDizisi[bolumDizisi.Length - 1] = bolum;
        }

        FRMDoktor form2 = new FRMDoktor(bolumDizisi);
        form2.Show();
    }
}
