using System.Runtime.InteropServices;

namespace DTAAuftragsdateiAnalysator
{

    [StructLayout(LayoutKind.Sequential, Size = 348, Pack = 1, CharSet = CharSet.Ansi)]
    public class Auftragsdatei
    {
        //[FieldOffset(0)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6, MarshalTypeRef = typeof(string))]
        [Auftrag(Stelle = 1, Länge = 6, Nutzungstyp = "A", Feldtyp = "N", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Identifikator des Objektes „KrankenkassenKommunikation“ Konstante ‘500000’. Für die Kompatibilität mit Objektstruktur der DATEV.")]
        public string IDENTIFIKATOR;

        //[FieldOffset(-1 + 7)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
        [Auftrag(Stelle = 7, Länge = 2, Nutzungstyp = "A", Feldtyp = "N", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Version der Auftragssatzstruktur. Ändert sich, wenn Felder des Auftragssatzes hinzugefügt, gelöscht oder geändert werden. 
‘01’: erste Version des Verfahrens. Für die Kompatibilität mit Objektstruktur der DATEV")]
        public string VERSION;

        //[FieldOffset(-1 + 9)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        [Auftrag(Stelle = 9, Länge = 8, Nutzungstyp = "A", Feldtyp = "N", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Länge der Auftragsdatei in Bytes (Objekt „Krankenkassen-Kommunikation“) Bei VERSION = ‘01’ steht hier als Konstante ‘00000348’")]
        public string LÄNGE_AUFTRAG;

        //[FieldOffset(-1 + 17)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        [Auftrag(Stelle = 17, Länge = 3, Nutzungstyp = "A", Feldtyp = "N", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Laufende Nummer bei einer Teillieferung. Gibt die Sequenznummer der Datei an, sofern eine Nachricht auf mehrere Datenträger oder 
physikalische Dateien bei DFÜ verteilt werden muss.

‘000’ Nachricht ist komplett vorhanden
‘001’ Erster Teil der Nachricht.
 bis
‘098’ Teil 98 der Nachricht
‘9xx’ Letzter Teil der Nachricht. Dabei gibt xx die Nummer des letzten Teils der Teillieferung an. ")]
        public string SEQUENZ_NR;

        //[FieldOffset(-1 + 20)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        [Auftrag(Stelle = 20, Länge = 5, Nutzungstyp = "R", Feldtyp = "AN", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Das Feld VERFAHREN_KENNUNG ist im Anlage A zur Allgemeinen Dateistruktur im Datenaustausch festgelegt und unterliegt ständigen 
aufwärtskompatiblen Änderungen. Die zur Zeit geltende Regelung ist in Anlage A dieses Anhangs dargelegt. Die Festlegung des Dateinamens ist im Anhang 3, 
Abschnitt 1.1.2 der Technischen Anlage 1 geregelt.")]
        public string VERFAHREN_KENNUNG;

        //[FieldOffset(-1 + 25)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        [Auftrag(Stelle = 25, Länge = 3, Nutzungstyp = "A", Feldtyp = "N", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Laufende Transfernummer bei der Übertragung zwischen zwei direkt verbundenen Kommunikationspartnern.

Die Transfernummer hat keinen Bezug zur lfd.Nr. des Vorlaufsatzes in den Nutzdaten. Sie wird ab 999 wieder auf 0 gesetzt. Bei der Übertragung mittels 
FTAM wird für die Übertragung aus VERFAHREN_KENNUNG und der TRANSFERNUMMER ein Transferdateiname erzeugt. Das Feld TRANSFER_NUMMER wird unabhängig vom 
Feld VERFAHREN_KENNUNG festgelegt. Bei jeder erfolgreichen Übertragung einer Datei wird TRANSFER_NUMMER um eins erhöht. Ist eine Übertragung fehlerhaft, 
so wird die TRANSFER_NUMMER für diesen Übertragungswunsch beibehalten und bei einer späteren Übertragung derselben Datei wiederverwendet. 
Das empfangende System ist daher dafür verantwortlich, unmittelbar nach Empfang eines Dateipaares (Nutzdaten, Auftragssatz) die Dateien unter 
einem neuen systemeindeutigen Dateinamen abzuspeichern, damit es nicht zu Überschreibungen von Dateien kommt.")]
        public string TRANSFER_NUMMER;

        //[FieldOffset(-1 + 28)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        [Auftrag(Stelle = 28, Länge = 5, Nutzungstyp = "R", Feldtyp = "AN", Feldart = "K", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Weitere Spezifikation des Verfahrens innerhalb des in VERFAHREN_KENNUNG festgelegten Verfahrens.

Die Werte werden eindeutig pro Verfahren (bei Datenaustausch z. B. der Nachrichtentyp, sofern eindeutig pro Lieferung) festgelegt.
Damit ist pro Verfahren eine weitere Unterscheidung der Nachrichtenart möglich.
Dieses Feld kann benutzt werden, um die Verarbeitungspriorität auszudrücken.")]
        public string VERFAHREN_KENNUNG_SPEZIFIKATION;

        //[FieldOffset(-1 + 33)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        [Auftrag(Stelle = 33, Länge = 15, Nutzungstyp = "R", Feldtyp = "AN", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Absendender Eigner der Nutzdaten. Identifikation des Absenders. (IK: 9 Stellen oder Betriebsnummer: 9 Stellen) Der Eigner 
ist für die Korrektheit der Daten verantwortlich und nimmt die Verschlüsselung vor. Dies kennzeichnet die Stelle, welche die Verschlüsselung vornimmt. 
Sofern im Datenaustausch Leistungserbringer über Rechenzentren Daten austauschen, ist in der Regel das Rechenzentrum der Eigner, da es die Daten 
vor Weitergabe aufbereitet. ")]
        public string ABSENDER_EIGNER;

        //[FieldOffset(-1 + 48)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        [Auftrag(Stelle = 48, Länge = 15, Nutzungstyp = "R", Feldtyp = "AN", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Tatsächlicher physikalischer Absender der Nutzdaten. Identifikation desselben Typs wie im Feld ABSENDER_EIGNER angegeben. 
Hier steht gegebenenfalls auch eine Daten- übermittlungsstelle.")]
        public string ABSENDER_PHYSIKALISCH;

        //[FieldOffset(-1 + 63)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        [Auftrag(Stelle = 63, Länge = 15, Nutzungstyp = "R", Feldtyp = "AN", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Empfänger, der die Daten nutzen soll. Identifikation desselben Typs wie im Feld ABSENDER_EIGNER angegeben. Dieser Empfänger 
ist im Besitz des Schlüssels, um verschlüsselte Informationen zu entschlüsseln. Der Nutzer nimmt die Weiterverarbeitung der Daten vor. Im Fall des 
Datenaustausches mit den Leistungserbringern ist hier die Datenannahmestelle mit Entschlüsselungsbefugnis gemäß Kostenträgerdatei einzutragen.")]
        public string EMPFÄNGER_NUTZER;

        //[FieldOffset(-1 + 78)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 15)]
        [Auftrag(Stelle = 78, Länge = 15, Nutzungstyp = "R", Feldtyp = "AN", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Empfänger, der die Daten physikalisch empfangen soll (= nächster Empfänger). Identifikation desselben Typs wie im Feld 
ABSENDER_EIGNER angegeben. Hier steht gegebenenfalls auch eine Datenübermittlungsstelle.")]
        public string EMPFÄNGER_PHYSIKALISCH;

        //[FieldOffset(-1 + 93)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        [Auftrag(Stelle = 93, Länge = 6, Nutzungstyp = "R", Feldtyp = "N", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Fehler-Nr. laut Fehlerkatalog bei Rücksendungen von Dateien. ‘000000’: kein Fehler")]
        public string FEHLER_NUMMER;

        //[FieldOffset(-1 + 17)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        [Auftrag(Stelle = 99, Länge = 6, Nutzungstyp = "R", Feldtyp = "N", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Durchzuführende Maßnahme laut Fehlerkatalog. ‘000000’: keine Maßnahme erforderlich Siehe Feld FEHLER_NUMMER. 
Gemäß dem Fehlerverfahren festzulegen.")]
        public string FEHLER_MAßNAHME;

        //[FieldOffset(-1 + 105)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 11)]
        [Auftrag(Stelle = 105, Länge = 11, Nutzungstyp = "A", Feldtyp = "AN", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Der vom Anwendungssystem vergebene Dateiname. Im Arbeitgeberverfahren besteht der DATEINAME aus dem Feld VERFAHREN_KENNUNG und 
einer 6-stelligen Nummer. Die Festlegung der Dateinamen s. Anhang 3, Abschnitt 1.1.1 der Technischen Anlage 1")]
        public string DATEINAME;

        //[FieldOffset(-1 + 116)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
        [Auftrag(Stelle = 116, Länge = 14, Nutzungstyp = "L", Feldtyp = "N", Feldart = "K", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Erstellungsdatum der Datei aus der Anwendung.Format JJJJMMTTssmmss (Jahr, Monat, Tag, Stunde, Minute, Sekunde). 
Aus den Feldern ABSENDER_EIGNER, VERFAHREN_KENNUNG und DATUM_ERSTELLUNG kann ein eindeutiger Identifikator gebildet werden, anhand dessen eine 
Sendung eindeutig identifiziert werden kann. Es ist vom Absender-Eigner sicherzustellen, dass zwei unterschiedliche 
Sendungen nicht mit demselben Identifikator verschickt werden")]
        public string DATUM_ERSTELLUNG;

        //[FieldOffset(-1 + 130)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
        [Auftrag(Stelle = 130, Länge = 14, Nutzungstyp = "L", Feldtyp = "N", Feldart = "K", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Start der Übermittlung der Datei. Format JJJJMMTTssmmss (Jahr, Monat, Tag, Stunde, Minute, Sekunde) Diese Zeit 
kann als Logging-Information oder auch für Wiederaufsatzverfahren zwischen zwei Partnern genutzt werden. Wird vom Absender ausgefüllt.")]
        public string DATUM_ÜBERTRAGUNG_GESENDET;

        //[FieldOffset(-1 + 144)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
        [Auftrag(Stelle = 144, Länge = 14, Nutzungstyp = "L", Feldtyp = "N", Feldart = "K", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Start des Empfangs der Datei. Format JJJJMMTTssmmss (Jahr, Monat, Tag, Stunde, Minute, Sekunde). Wird nur vom 
ersten Empfänger ausgefüllt, der vertraglich die annehmende Stelle ist und deren Annahmezeit daher vertragliche Auswirkungen hat (. Das 
Feld ist vom ersten Absender mit numerischen Nullen aufzufüllen.")]
        public string DATUM_ÜBERTRAGUNG_EMPFANGEN_START;

        //[FieldOffset(-1 + 158)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
        [Auftrag(Stelle = 158, Länge = 14, Nutzungstyp = "L", Feldtyp = "N", Feldart = "K", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Ende der Empfangsübertragung der Datei. Format JJJJMMTTssmmss (Jahr, Monat, Tag, Stunde, Minute, Sekunde). 
Wird vom Empfänger ausgefüllt.")]
        public string DATUM_ÜBERTRAGUNG_EMPFANGEN_ENDE;

        //[FieldOffset(-1 + 172)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        [Auftrag(Stelle = 172, Länge = 6, Nutzungstyp = "A", Feldtyp = "N", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Versionsnummer der Datei. Wird derzeit in keinem Verfahren benutzt. Muss auf ‘000000’ gesetzt werden.")]
        public string DATEIVERSION;

        //[FieldOffset(-1 + 178)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        [Auftrag(Stelle = 178, Länge = 1, Nutzungstyp = "A", Feldtyp = "N", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Ist bereits eine Datei mit derselben Dateiversion
verschickt worden?
‘0’: Nein
‘1’: Dies ist die Korrekturdatei. Die bereits
erhaltene Datei kann gelöscht werden.
Wird derzeit in keinem Verfahren benutzt.
Muss auf ‘0’ gesetzt werden.")]
        public string KORREKTUR;

        //[FieldOffset(-1 + 179)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
        [Auftrag(Stelle = 179, Länge = 12, Nutzungstyp = "A", Feldtyp = "N", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Dateigröße der Nutzdatendatei in Bytes (unverschlüsselt und unkomprimiert)")]
        public string DATEIGRÖßE_NUTZDATEN;

        //[FieldOffset(-1 + 191)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 12)]
        [Auftrag(Stelle = 191, Länge = 12, Nutzungstyp = "A", Feldtyp = "N", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"Dateigröße der übertragenen Nutzdatendatei in Bytes (Länge bei eventueller Verschlüsselung und Komprimierung)")]
        public string DATEIGRÖßE_ÜBERTRAGUNG;

        //[FieldOffset(-1 + 203)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
        [Auftrag(Stelle = 203, Länge = 2, Nutzungstyp = "A", Feldtyp = "AN", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"‘I1’: ISO 8859-1
‘I7’: ISO 7-Bit,
Code gemäß DIN 66003 DRV 7
(Deutsche Referenzversion)
 ‘I8’: ISO 8-Bit,
Code gemäß DIN 66303 DRV 8
‘P8’: IBM-CODEPAGE 850
 (gilt nur nach bilateraler Vereinbarung)")]
        public string ZEICHENSATZ;

        //[FieldOffset(-1 + 205)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
        [Auftrag(Stelle = 205, Länge = 2, Nutzungstyp = "A", Feldtyp = "N", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @"‘00’ keine
‘01’ COMPRESS (CoCoNet)
‘02’ für LE-Verfahren aufgrund der
Teletrust-Definitionen
‘03’ ZIP (muss im 7-bit Code angewandt
werden)‘04’ COMPRESS (UNIX)
‚05‘ Jet x-press Software")]
        public string KOMPRIMIERUNG;

        //[FieldOffset(-1 + 207)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
        [Auftrag(Stelle = 207, Länge = 2, Nutzungstyp = "A", Feldtyp = "N", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @" ‘00’ keine
‘02’ für LE-Verfahren im PEM-Format.
 Das ITSG Trust Center stellt PEMZertifikate
nur noch bis 30.06.07 aus.
 Ab 01.07.2007 findet das PKCS#7-
Format Anwendung.")]
        public string VERSCHLÜSSELUNGSART;

        //[FieldOffset(-1 + 209)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
        [Auftrag(Stelle = 209, Länge = 2, Nutzungstyp = "A", Feldtyp = "N", Feldart = "M", Gruppe = "1. Teil: Allgemeine Beschreibung der Krankenkassen-Kommunikation",
            Beschreibung = @" ‘00’ keine
‘02’ für LE-Verfahren im PEM-Format.
 Das ITSG Trust Center stellt PEMZertifikate
nur noch bis 30.06.07 aus.
 Ab 01.07.2007 findet das PKCS#7-
Format Anwendung.")]
        public string ELEKTRONISCHE_UNTERSCHRIFT;

        //[FieldOffset(-1 + 211)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
        [Auftrag(Stelle = 211, Länge = 3, Nutzungstyp = "D", Feldtyp = "A", Feldart = "K", Gruppe = "2. Teil: Spezifische Information",
            Beschreibung = @"Satzformat der Datei auf dem Datenträger:
• F=FIX
• V=Variabel
• U=Undefiniert
• FB=FIX_geblockt
• FBA=FIX_geblockt
• VB=Variabel geblockt
• Bei DFÜ: Konstante ‘ ‘.")]
        public string SATZFORMAT;

        //[FieldOffset(-1 + 214)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 5)]
        [Auftrag(Stelle = 214, Länge = 5, Nutzungstyp = "D", Feldtyp = "N", Feldart = "K", Gruppe = "2. Teil: Spezifische Information",
            Beschreibung = @"Satzlänge bei fixem Satzformat. Bei DFÜ: Konstante ‘00000’.")]
        public string SATZLÄNGE;

        //[FieldOffset(-1 + 219)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
        [Auftrag(Stelle = 219, Länge = 8, Nutzungstyp = "D", Feldtyp = "N", Feldart = "K", Gruppe = "2. Teil: Spezifische Information",
            Beschreibung = @"Blocklänge in Bytes, sofern geblockt. Bei DFÜ: Konstante ‘00000000’.")]
        public string BLOCKLÄNGE;

        //[FieldOffset(-1 + 227)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        [Auftrag(Stelle = 227, Länge = 1, Nutzungstyp = "K", Feldtyp = "AN", Feldart = "K", Gruppe = "3. Teil: Spezifische Informationen",
            Beschreibung = @"Bei Anlieferung durch das Abrechnungssystem:
Leerzeichen
Verarbeitungskennzeichnung (Anwendung,
FTAM):
0 Einstellung in Ordnung
1 Ändern
2 Suspendieren
3 Löschen
4 Übertragen
5 Transferphase
6 Keine Verbindung
7 Fehlerhafter Transfer
8 Statusabfrage")]
        public string Status;

        //[FieldOffset(-1 + 228)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 2)]
        [Auftrag(Stelle = 228, Länge = 2, Nutzungstyp = "K", Feldtyp = "N", Feldart = "K", Gruppe = "3. Teil: Spezifische Informationen",
            Beschreibung = @"Hier wird die maximale Anzahl der Übertragungswiederholungen bei fehlerhaften Übertragungen angegeben. 
Wenn der angegebene Zähler überschritten wird, oder ein nichtbehebbarer Fehler beim Übertragungsversuch aufgetreten ist, wird der Auftrag 
als nicht durchführbar mit einem Diagnosecode gekennzeichnet ")]
        public string Wiederholung;

        //[FieldOffset(-1 + 230)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1)]
        [Auftrag(Stelle = 230, Länge = 1, Nutzungstyp = "K", Feldtyp = "N", Feldart = "K", Gruppe = "3. Teil: Spezifische Informationen",
            Beschreibung = @"Mögliche Wege sind:
1 X.25
2 ISDN
3 ISDN, bei Übertragungsproblemen
 erneuter Versuch über X.25
4 X.25, bei Übertragungsproblemen
 erneuter Versuch über ISDN
5 anderer Weg")]
        public string Übertragungsweg;

        //[FieldOffset(-1 + 231)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 10)]
        [Auftrag(Stelle = 231, Länge = 10, Nutzungstyp = "K", Feldtyp = "N", Feldart = "K", Gruppe = "3. Teil: Spezifische Informationen",
            Beschreibung = @"Hier wird der Zeitpunkt eingetragen, zu dem der Auftrag ausgeführt werden soll.Wird das Feld nicht vom Abrechnungssystem 
gefüllt oder ist der angegebene Ausführungszeitpunkt bereits überschritten, wird der Auftrag vom KKS zum nächstmöglichen Zeitpunkt ausgeführt. 
Im Format JJMMTTSSmm(Jahr, Monat, Tag, Stunde und Minute)")]
        public string VerzögerterVersand;

        //[FieldOffset(-1 + 241)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 6)]
        [Auftrag(Stelle = 241, Länge = 6, Nutzungstyp = "K", Feldtyp = "N", Feldart = "K", Gruppe = "3. Teil: Spezifische Informationen",
            Beschreibung = "Fehlernummer aus FTAM. Bei erfolgreich ausgeführten Aufträgen ist das Feld leer.")]
        public string InfoUndFehlerfelder;

        //[FieldOffset(-1 + 247)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 28)]
        [Auftrag(Stelle = 247, Länge = 28, Nutzungstyp = "K", Feldtyp = "AN", Feldart = "K", Gruppe = "3. Teil: Spezifische Informationen",
            Beschreibung = "Klartextfehlermeldung. Bei erfolgreich ausgeführten Aufträgen ist das Feld leer.")]
        public string VariablesInfoFeld;

        //[FieldOffset(-1 + 275)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 44)]
        [Auftrag(Stelle = 275, Länge = 44, Nutzungstyp = "I", Feldtyp = "AN", Feldart = "K", Gruppe = "4. Teil: Spezifische Information zur Verarbeitung innerhalb eines RZ", Beschreibung = "Verarbeitungsinterner physischer Dateiname")]
        public string DATEINAME_PHYSIKALISCH;

        //[FieldOffset(-1 + 319)]
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 30)]
        [Auftrag(Stelle = 319, Länge = 30, Nutzungstyp = "I", Feldtyp = "AN", Feldart = "M", Gruppe = "4. Teil: Spezifische Information zur Verarbeitung innerhalb eines RZ", Beschreibung = "Variabler Bereich, um Zusatzinformationen zur Datei bereitzustellen Stelle 319 - 320 s.Schlüssel Art der abgegebenen Leistung Anlage 3, Abschnitt 2.4")]
        public string DATEI_BEZEICHNUNG;
    }
}
