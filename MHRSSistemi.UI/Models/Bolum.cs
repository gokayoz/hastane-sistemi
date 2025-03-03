using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
