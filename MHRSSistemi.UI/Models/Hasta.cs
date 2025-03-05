using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRSSistemi.UI.Models
{
    public class Hasta
    {
        public string HastaAdSoyadi { get; set; }
        public string HastaSikayeti { get; set; }

        public Doktor Doktor { get; set; }

        public override string ToString() => $"{HastaAdSoyadi}";
    }
}
