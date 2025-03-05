using System;
using System.Text.RegularExpressions;

namespace MHRSSistemi.UI.Models
{
    public class Bolum
    {
        private string _bolumAdi;
        private string _bolumAciklamasi;

        public string BolumAdi
        {
            get => _bolumAdi;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value, @"^[a-zA-ZğüşıöçĞÜŞİÖÇ\s]+$"))
                {
                    throw new Exception("Bölüm adı boş olamaz ve sadece harf içermelidir!");
                }
                _bolumAdi = value;
            }
        }

        public string BolumAciklamasi
        {
            get => _bolumAciklamasi;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !Regex.IsMatch(value, @"^[a-zA-ZğüşıöçĞÜŞİÖÇ\s]+$"))
                {
                    throw new Exception("Bölüm açıklaması boş olamaz ve sadece harf içermelidir!");
                }
                _bolumAciklamasi = value;
            }
        }

        public override string ToString() => $"Bölüm Adı: {BolumAdi} : Bölüm Açıklaması: {BolumAciklamasi}";
    }
}
