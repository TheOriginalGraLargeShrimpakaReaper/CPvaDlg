namespace CPvaDlg
{
    partial class CPvaDlg
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtAnzahl = new System.Windows.Forms.TextBox();
            this.txtLeistungModul = new System.Windows.Forms.TextBox();
            this.txtInstLeistung = new System.Windows.Forms.TextBox();
            this.txtFlaeche = new System.Windows.Forms.TextBox();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.lblAnzahl = new System.Windows.Forms.Label();
            this.lblLeistungModul = new System.Windows.Forms.Label();
            this.lblInstLeistung = new System.Windows.Forms.Label();
            this.lblFlaeche = new System.Windows.Forms.Label();
            this.lblLeistungTitel = new System.Windows.Forms.Label();
            this.lblBerechnung = new System.Windows.Forms.Label();
            this.lblStueck = new System.Windows.Forms.Label();
            this.lblWp = new System.Windows.Forms.Label();
            this.lblkWp = new System.Windows.Forms.Label();
            this.lblFlaeche_m2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAnzahl
            // 
            this.txtAnzahl.Location = new System.Drawing.Point(136, 12);
            this.txtAnzahl.Name = "txtAnzahl";
            this.txtAnzahl.Size = new System.Drawing.Size(100, 20);
            this.txtAnzahl.TabIndex = 0;
            // 
            // txtLeistungModul
            // 
            this.txtLeistungModul.HideSelection = false;
            this.txtLeistungModul.Location = new System.Drawing.Point(136, 38);
            this.txtLeistungModul.Name = "txtLeistungModul";
            this.txtLeistungModul.Size = new System.Drawing.Size(100, 20);
            this.txtLeistungModul.TabIndex = 1;
            // 
            // txtInstLeistung
            // 
            this.txtInstLeistung.Location = new System.Drawing.Point(136, 64);
            this.txtInstLeistung.Name = "txtInstLeistung";
            this.txtInstLeistung.ReadOnly = true;
            this.txtInstLeistung.Size = new System.Drawing.Size(100, 20);
            this.txtInstLeistung.TabIndex = 2;
            // 
            // txtFlaeche
            // 
            this.txtFlaeche.Location = new System.Drawing.Point(136, 90);
            this.txtFlaeche.Name = "txtFlaeche";
            this.txtFlaeche.ReadOnly = true;
            this.txtFlaeche.Size = new System.Drawing.Size(100, 20);
            this.txtFlaeche.TabIndex = 3;
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(312, 12);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(75, 23);
            this.btnBerechnen.TabIndex = 4;
            this.btnBerechnen.Text = "Berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // lblAnzahl
            // 
            this.lblAnzahl.AutoSize = true;
            this.lblAnzahl.Location = new System.Drawing.Point(13, 12);
            this.lblAnzahl.Name = "lblAnzahl";
            this.lblAnzahl.Size = new System.Drawing.Size(77, 13);
            this.lblAnzahl.TabIndex = 5;
            this.lblAnzahl.Text = "Anzahl Module";
            // 
            // lblLeistungModul
            // 
            this.lblLeistungModul.AutoSize = true;
            this.lblLeistungModul.Location = new System.Drawing.Point(13, 38);
            this.lblLeistungModul.Name = "lblLeistungModul";
            this.lblLeistungModul.Size = new System.Drawing.Size(97, 13);
            this.lblLeistungModul.TabIndex = 6;
            this.lblLeistungModul.Text = "Leistung pro Modul";
            // 
            // lblInstLeistung
            // 
            this.lblInstLeistung.AutoSize = true;
            this.lblInstLeistung.Location = new System.Drawing.Point(16, 65);
            this.lblInstLeistung.Name = "lblInstLeistung";
            this.lblInstLeistung.Size = new System.Drawing.Size(97, 13);
            this.lblInstLeistung.TabIndex = 7;
            this.lblInstLeistung.Text = "Installierte Leistung";
            // 
            // lblFlaeche
            // 
            this.lblFlaeche.AutoSize = true;
            this.lblFlaeche.Location = new System.Drawing.Point(13, 90);
            this.lblFlaeche.Name = "lblFlaeche";
            this.lblFlaeche.Size = new System.Drawing.Size(62, 13);
            this.lblFlaeche.TabIndex = 8;
            this.lblFlaeche.Text = "Dachfläche";
            // 
            // lblLeistungTitel
            // 
            this.lblLeistungTitel.AutoSize = true;
            this.lblLeistungTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeistungTitel.Location = new System.Drawing.Point(12, 131);
            this.lblLeistungTitel.Name = "lblLeistungTitel";
            this.lblLeistungTitel.Size = new System.Drawing.Size(66, 13);
            this.lblLeistungTitel.TabIndex = 9;
            this.lblLeistungTitel.Text = "PV-Anlage";
            // 
            // lblBerechnung
            // 
            this.lblBerechnung.AutoSize = true;
            this.lblBerechnung.Location = new System.Drawing.Point(12, 157);
            this.lblBerechnung.Name = "lblBerechnung";
            this.lblBerechnung.Size = new System.Drawing.Size(0, 13);
            this.lblBerechnung.TabIndex = 10;
            // 
            // lblStueck
            // 
            this.lblStueck.AutoSize = true;
            this.lblStueck.Location = new System.Drawing.Point(242, 15);
            this.lblStueck.Name = "lblStueck";
            this.lblStueck.Size = new System.Drawing.Size(41, 13);
            this.lblStueck.TabIndex = 11;
            this.lblStueck.Text = "[Stück]";
            // 
            // lblWp
            // 
            this.lblWp.AutoSize = true;
            this.lblWp.Location = new System.Drawing.Point(242, 41);
            this.lblWp.Name = "lblWp";
            this.lblWp.Size = new System.Drawing.Size(30, 13);
            this.lblWp.TabIndex = 12;
            this.lblWp.Text = "[Wp]";
            // 
            // lblkWp
            // 
            this.lblkWp.AutoSize = true;
            this.lblkWp.Location = new System.Drawing.Point(242, 65);
            this.lblkWp.Name = "lblkWp";
            this.lblkWp.Size = new System.Drawing.Size(36, 13);
            this.lblkWp.TabIndex = 13;
            this.lblkWp.Text = "[kWp]";
            // 
            // lblFlaeche_m2
            // 
            this.lblFlaeche_m2.AutoSize = true;
            this.lblFlaeche_m2.Location = new System.Drawing.Point(242, 93);
            this.lblFlaeche_m2.Name = "lblFlaeche_m2";
            this.lblFlaeche_m2.Size = new System.Drawing.Size(121, 13);
            this.lblFlaeche_m2.TabIndex = 14;
            this.lblFlaeche_m2.Text = "[m2], 1 Modul = 1.65 m2";
            // 
            // CPvaDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 221);
            this.Controls.Add(this.lblFlaeche_m2);
            this.Controls.Add(this.lblkWp);
            this.Controls.Add(this.lblWp);
            this.Controls.Add(this.lblStueck);
            this.Controls.Add(this.lblBerechnung);
            this.Controls.Add(this.lblLeistungTitel);
            this.Controls.Add(this.lblFlaeche);
            this.Controls.Add(this.lblInstLeistung);
            this.Controls.Add(this.lblLeistungModul);
            this.Controls.Add(this.lblAnzahl);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.txtFlaeche);
            this.Controls.Add(this.txtInstLeistung);
            this.Controls.Add(this.txtLeistungModul);
            this.Controls.Add(this.txtAnzahl);
            this.Name = "CPvaDlg";
            this.Text = "PV-Anlage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAnzahl;
        private System.Windows.Forms.TextBox txtLeistungModul;
        private System.Windows.Forms.TextBox txtInstLeistung;
        private System.Windows.Forms.TextBox txtFlaeche;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.Label lblAnzahl;
        private System.Windows.Forms.Label lblLeistungModul;
        private System.Windows.Forms.Label lblInstLeistung;
        private System.Windows.Forms.Label lblFlaeche;
        private System.Windows.Forms.Label lblLeistungTitel;
        private System.Windows.Forms.Label lblBerechnung;
        private System.Windows.Forms.Label lblStueck;
        private System.Windows.Forms.Label lblWp;
        private System.Windows.Forms.Label lblkWp;
        private System.Windows.Forms.Label lblFlaeche_m2;
    }
}

