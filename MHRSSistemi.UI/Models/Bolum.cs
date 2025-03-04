namespace MHRSSistemi.UI.Models
{
    public class Bolum
    {
        public string BolumAdi { get; set; }
        public string BolumAciklamasi { get; set; }

        public override string ToString()
        {
            return $"Bölüm Adı: {BolumAdi} : Bölüm Açıklaması: {BolumAciklamasi}";
        }
    }
}
