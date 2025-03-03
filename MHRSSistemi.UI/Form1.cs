using MHRSSistemi.UI.Models;

namespace MHRSSistemi.UI;

public partial class Form1 : Form
{
    List<Bolum> bolumler = new();
    public Form1()
    {
        InitializeComponent();
    }

    private void btnEkle_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtBolumAdi.Text) || string.IsNullOrWhiteSpace(txtBolumAciklamasi.Text))
        {
            MessageBox.Show("B�l�m ad� veya a��klamas� bo� olamaz!");
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
            MessageBox.Show("B�l�m ba�ar�yla eklenmi�tir.");
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
            MessageBox.Show("L�ttfen b�l�m se�iniz!");
            return;
        }
        lstbBolumler.Items.Remove(lstbBolumler.SelectedItem);
        MessageBox.Show("B�l�m ba�ar�yla silindi.");
    }
    private void btnGuncelle_Click(object sender, EventArgs e)
    {
        if (lstbBolumler.SelectedItem == null)
        {
            MessageBox.Show("G�ncellemek istedi�iniz b�l�m� se�iniz!");
            return;
        }
        Bolum seciliBolum = (Bolum)lstbBolumler.SelectedItem;

        seciliBolum.BolumAdi = txtBolumAdi.Text;
        seciliBolum.BolumAciklamasi = txtBolumAciklamasi.Text;

        int index = lstbBolumler.SelectedIndex;
        lstbBolumler.Items[index] = seciliBolum;

        Temizle();
        MessageBox.Show("B�l�m ba�ar�yla g�ncellendi.");
    }

    private void btnGec_Click(object sender, EventArgs e)
    {
        Bolum[] bolumDizisi = new Bolum[0];

        foreach (Bolum item in lstbBolumler.Items)
        {
            Array.Resize(ref bolumDizisi, bolumDizisi.Length + 1);
            bolumDizisi[bolumDizisi.Length - 1] = item;
        }

        Form2 form2 = new Form2(bolumDizisi);
        form2.Show();
    }
}
