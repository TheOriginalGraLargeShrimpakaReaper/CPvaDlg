using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CPvaDlg
{
    /// <summary>
    /// Klasse CPvaBase ind der die wichtigsten Berechnungen gemacht werden
    /// </summary>
    public class CPvaBase
    {
        private int m_intAnzahl;
        private int m_intModulLeistung;
        private double m_dblInstalliertLeistung_kWp;
        private double m_dblDachFlaeche;

        /// <summary>
        /// Standardkonstruktor der Klasse CPvaBase
        /// </summary>
        public CPvaBase()
        {
        }

        /// <summary>
        /// Getter / Setter m_dblInstalliertLeistung_kWp
        /// </summary>
        public double InstalliertLeistungSetzen_kWp
        {
            get
            {
                return m_dblInstalliertLeistung_kWp;
            }
            set
            {
                m_dblInstalliertLeistung_kWp = value;
            }
        }

        /// <summary>
        /// Getter / Setter m_dblDachFlaeche
        /// </summary>
        public double Dachflaeche
        {
            get
            {
                return m_dblDachFlaeche;
            }
            set
            {
                m_dblDachFlaeche = value;
            }
        }

        /// <summary>
        /// Getter / Setter m_intAnzahl
        /// </summary>
        public int AnzahlModule
        {
            get
            {
                return m_intAnzahl;
            }
            set
            {
                m_intAnzahl = value;
            }
        }

        /// <summary>
        /// Erstellt den Ausgabestring anhand der Felder
        /// </summary>
        /// <returns></returns>
        public string BerechnungAusgeben()
        {
            string strAusgabe = "";

            strAusgabe = $"Leistung: {m_intAnzahl} * {m_intModulLeistung} Wp = {m_dblInstalliertLeistung_kWp} kWp, Dachfläche: {m_dblDachFlaeche} m2\n";

            return strAusgabe;
        }

        /// <summary>
        /// Prüft, ob die Anzahl der übergebenen Module grösser als 0 ist
        /// </summary>
        /// <param name="intAnzahl"></param>
        /// <param name="strErrorMessage"></param>
        /// <returns>name="bCheck"</returns>
        private bool CheckModulAnzahl(int intAnzahl, ref string strErrorMessage)
        {
            bool bCheck = false;

            if(intAnzahl > 0)
            {
                bCheck  =   true;
                m_intAnzahl = intAnzahl;
            }
            else
            {
                strErrorMessage = strErrorMessage = $"Die Benutzereingabe '{intAnzahl}' muss grösser als 0 sein";
            }

            return bCheck;
        }

        /// <summary>
        /// Prüft ob die Leistung der Module zwischen 100 und 600 (bis und mit) liegt
        /// </summary>
        /// <param name="intModulLeistung"></param>
        /// <param name="strErrorMessage"></param>
        /// <returns></returns>
        private bool CheckModulLeistung(int intModulLeistung, ref string strErrorMessage)
        {
            bool bCheck = false;

            if( intModulLeistung >= 100 && intModulLeistung <= 600)
            {
                bCheck = true;
                m_intModulLeistung = intModulLeistung;
            }
            else
            {
                strErrorMessage = $"Die Benutzereingabe Leistung '{intModulLeistung}' [Wp] ist nicht korrekt!\nGültiger Bereich: 100 - 600 [Wp]";
            }

            return bCheck;
        }

        /// <summary>
        /// Prüft ob die vom User übergebenen Daten auch wirklich ein Integer sind
        /// </summary>
        /// <param name="strUserInput"></param>
        /// <param name="strErrorMessage"></param>
        /// <param name="strEinheit"></param>
        /// <returns></returns>
        public bool CheckUserInput(string strUserInput, ref string strErrorMessage, string strEinheit)
        {
            bool bCheck = false;
            int intUserInput;

            bCheck = int.TryParse(strUserInput, out intUserInput);

            //  Nur fortfahren mit Methoden wenn Werte sauber sind
            if (bCheck)
            {
                switch (strEinheit)
                {
                    case "stk":
                        bCheck = CheckModulAnzahl(intUserInput, ref strErrorMessage);
                        break;
                    case "wp":
                        bCheck = CheckModulLeistung(intUserInput, ref strErrorMessage);
                        break;
                }
            }
            else
            {
                strErrorMessage = $"Die Benutzereingabe '{strUserInput}' ist kein nummerischer Wert!";
            }
                
            return bCheck;
        }

        /// <summary>
        /// Berechnet die Fläche des Daches.
        /// Hierzu wird die Anzahl Module x den Faktor 1.65 berechnet
        /// </summary>
        /// <param name="intAnzahl"></param>
        /// <returns></returns>
        public double DachFlaeche(int intAnzahl)
        {
            double dblDachFlaeche = intAnzahl * 1.65;

            return dblDachFlaeche;
        }

        /// <summary>
        /// Rechnet die Installierte Leistung aus.
        /// Hierzu werden die Anzahl Module mit der Leistung pro Modul multipliziert.
        /// 
        /// Da die Zieleinheit kWp ist, wird entsprechend gleich umgerechnet
        /// </summary>
        /// <returns></returns>
        public double InstallierteLeistung()
        {
            double dblInstallierteLeistung_kWp = UmrechnungKiloPeak(m_intAnzahl * m_intModulLeistung);

            return dblInstallierteLeistung_kWp;
        }

        /// <summary>
        /// Rechnet die übergebene Installierte Leistung von Wp in kWp um
        /// </summary>
        /// <param name="dblInstallierteLeistung"></param>
        /// <returns></returns>
        private double UmrechnungKiloPeak(double dblInstallierteLeistung)
        {
            double dblInstallierteLeistung_kWp = dblInstallierteLeistung / 1000;

            return dblInstallierteLeistung_kWp;
        }
    }
}