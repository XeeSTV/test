using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektLaboratorium
{
    public class Zlecenie : InterfejsZapisywalny
    {
        public Kontrahent Kontrahent { get; set; }
        public Probka Probka { get; set; }
        public List<Analiza> Analizy { get; set; } = new List<Analiza>();
        public DateTime TerminWykonania { get; set; }
        public decimal KosztCalkowity { get; set; }

        public void Zapisz()
        {
            // Logika zapisu zlecenia
        }
    }
}
