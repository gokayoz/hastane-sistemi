namespace MHRSSistemi.UI.Models
{
    public class Doktor
    {
        public string DoktorAdSoyadi { get; set; }
        public string DoktorTelefonu { get; set; }
        public Bolum Bolum { get; set; }

        public override string ToString()
        {
            return $"Doktor Adı: {DoktorAdSoyadi} : Doktor Telefonu: {DoktorTelefonu}";
        }
    }
}

