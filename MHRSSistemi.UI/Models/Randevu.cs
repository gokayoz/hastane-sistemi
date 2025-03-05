using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRSSistemi.UI.Models
{
    public class Randevu
    {
        public DateTime RandevuTarihi { get; set; }
        public Hasta Hasta { get; set; }


        public override string ToString() => $"Hasta Adı Soyadı: {Hasta} : Randevu Tarihi: {RandevuTarihi.ToShortDateString()}";
    }
}
