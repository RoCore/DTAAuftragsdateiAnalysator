using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTAAuftragsdateiAnalysator
{
    /// <summary>
    /// <seealso cref="https://www.gkv-datenaustausch.de/media/dokumente/leistungserbringer_1/pflege/technische_anlagen_aktuell_2/TA3_20121119_105.pdf"/>
    /// Abbildung der Tabelle in Anlage 2 für Pflege. Aktuellere Version ist bei Sonstigen Leistungserbringern
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class AuftragAttribute : Attribute
    {
        public int Stelle { get; set; }
        public int Länge { get; set; }
        public string Nutzungstyp { get; set; }
        public string Feldtyp { get; set; }
        public string Feldart { get; set; }
        public string Gruppe { get; set; }
        public string Beschreibung { get; set; }
    }
}
