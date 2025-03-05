using System.Text.RegularExpressions;

namespace MHRSSistemi.UI.Models
{
    public class Doktor
    {
        private string _doktorAdiSoyadi;
        private string _doktorTelefonu;

        public string DoktorAdSoyadi
        {
            get => _doktorAdiSoyadi;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value, @"^[a-zA-ZğüşıöçĞÜŞİÖÇ\s]+$"))
                {
                    throw new Exception("Doktor adı boş olamaz ve sadece harf içermelidir!");
                }
                _doktorAdiSoyadi = value;
            }
        }

        public string DoktorTelefonu
        {
            get => _doktorTelefonu;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value, @"^\d+$") || value.Length < 10)
                {
                    throw new Exception("Doktor telefonu boş olamaz, sadece rakamlardan oluşmalı ve en az 10 haneli olmalıdır!");
                }
                _doktorTelefonu = value;
            }
        }


        public Bolum Bolum { get; set; }

        public override string ToString() => $"Doktor Adı: {DoktorAdSoyadi} : Doktor Telefonu: {DoktorTelefonu}";
    }
}
