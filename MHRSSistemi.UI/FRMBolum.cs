using MHRSSistemi.UI.Models;
using System.Text.RegularExpressions;

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
        try
        {
            Bolum bolum = new Bolum
            {
                BolumAdi = txtBolumAdi.Text.Trim(),
                BolumAciklamasi = txtBolumAciklamasi.Text.Trim()
            };

            lstbBolumler.Items.Add(bolum);
            MessageBox.Show("B�l�m ba�ar�yla eklendi.", "Ba�ar�l�", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bolumler.Add(bolum);

            Temizle();
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Bir hata olu�tu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            MessageBox.Show("L�tfen silmek i�in bir b�l�m se�iniz!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        lstbBolumler.Items.Remove(lstbBolumler.SelectedItem);
        MessageBox.Show("B�l�m ba�ar�yla silindi.", "Ba�ar�l�", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnGuncelle_Click(object sender, EventArgs e)
    {
        if (lstbBolumler.SelectedItem == null)
        {
            MessageBox.Show("G�ncellemek i�in bir b�l�m se�iniz!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        try
        {
            Bolum seciliBolum = lstbBolumler.SelectedItem as Bolum;

            seciliBolum.BolumAdi = txtBolumAdi.Text;
            seciliBolum.BolumAciklamasi = txtBolumAciklamasi.Text;

            int index = lstbBolumler.SelectedIndex;
            lstbBolumler.Items[index] = seciliBolum;

            Temizle();
            MessageBox.Show("B�l�m ba�ar�yla g�ncellendi.", "Ba�ar�l�", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("B�l�m bilgileri bo� olamaz ve sadece harf i�ermelidir!", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
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
