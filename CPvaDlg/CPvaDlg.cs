using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPvaDlg
{
    public partial class CPvaDlg : Form
    {
        /*
         * Die Klasse CPvaBase wird als neues m_objPvBase definiert und erzeugt
         * 
         * Dies soll nur einmal gemacht werden, da die Werte nicht via Konstruktor übergeben werden.
        */
        CPvaBase m_objPvBase = new CPvaBase();

        /// <summary>
        /// Standard Konstruktor der Klasse CPvaDlg
        /// Initialisiert lediglich die Komponenten
        /// </summary>
        public CPvaDlg()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Berechnet die Leistungen beim Button Klick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBerechnen_Click(object sender, EventArgs e)
        {
            /*
             * Daten abholen und Prüfen
            */
            //  Anzahl Module
            string strAnzahl        =   txtAnzahl.Text;
            string strAnzahl_Error = "";
            bool bCheckAnzahl = m_objPvBase.CheckUserInput(strAnzahl, ref strAnzahl_Error, "stk");

            if(!bCheckAnzahl)
            {
                MessageBox.Show(strAnzahl_Error, "Benutzereingabe Anzahl", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnzahl.Focus();
                return;
            }

            //  Leistgung pro Modul
            string strModulLeistung = txtLeistungModul.Text;
            string strModulLeistung_Error = "";
            bool bCheckModulLeistung = m_objPvBase.CheckUserInput(strModulLeistung, ref strModulLeistung_Error, "wp");

            if(!bCheckModulLeistung)
            {
                MessageBox.Show(strModulLeistung_Error, "Benutzereingabe Leistung pro Modul", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAnzahl.Focus();
                return;
            }

            /*
             * Installierte Leistung berechnen
            */
            double dblInstallierteLeistung_kWp = m_objPvBase.InstallierteLeistung();
            m_objPvBase.InstalliertLeistungSetzen_kWp = dblInstallierteLeistung_kWp;

            /*
             * Fläche des Daches berechnen und setzen
            */
            double dblDachFlaeche = m_objPvBase.DachFlaeche(m_objPvBase.AnzahlModule);
            m_objPvBase.Dachflaeche = dblDachFlaeche;

            /*
             * Resultate setzen.
            */
            string strBerechnung = lblBerechnung.Text;
            string strNeueRechnung = m_objPvBase.BerechnungAusgeben();
            strBerechnung = strBerechnung + strNeueRechnung;
            lblBerechnung.Text = strBerechnung;
        }
    }
}
