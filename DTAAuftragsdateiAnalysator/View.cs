using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTAAuftragsdateiAnalysator
{
    public class View
    {
        public String Name { get; set; }
        public String Value { get; set; }
        public int Stelle { get; set; }
        public int Länge { get; set; }
        public string Nutzungstyp { get; set; }
        public string Feldtyp { get; set; }
        public string Feldart { get; set; }
        public string Gruppe { get; set; }
        public string Beschreibung { get; set; }

        public static implicit operator View(AuftragAttribute value)
        {
            return new View
            {
                Stelle = (value?.Stelle).GetValueOrDefault(),
                Länge = (value?.Länge).GetValueOrDefault(),
                Nutzungstyp = value?.Nutzungstyp,
                Feldtyp = value?.Feldtyp,
                Feldart = value?.Feldart,
                Beschreibung = value?.Beschreibung,
                Gruppe = value?.Gruppe
            };
        }
    }
}
