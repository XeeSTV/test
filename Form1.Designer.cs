using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ProjektLaboratorium
{
    partial class Form1
    {
        private IContainer components = null;
        private TextBox textBoxNazwa;
        private TextBox textBoxKodPocztowy;
        private TextBox textBoxUlica;
        private TextBox textBoxMiasto;
        private TextBox textBoxNIP;
        private TextBox textBoxEmail;
        private RadioButton radioButtonFirma;
        private RadioButton radioButtonOsobaPrywatna;
        private ComboBox comboBoxMaterial;
        private DateTimePicker dateTimePickerPobrania;
        private DateTimePicker dateTimePickerTermin;
        private TextBox textBoxKoszt;
        private Button buttonZapisz;
        private Button buttonPrzejdzDoPrzypisania;
        private Label labelStatusBazy;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();
            textBoxNazwa = new TextBox();
            textBoxKodPocztowy = new TextBox();
            textBoxUlica = new TextBox();
            textBoxMiasto = new TextBox();
            textBoxNIP = new TextBox();
            textBoxEmail = new TextBox();
            radioButtonFirma = new RadioButton();
            radioButtonOsobaPrywatna = new RadioButton();
            comboBoxMaterial = new ComboBox();
            dateTimePickerPobrania = new DateTimePicker();
            dateTimePickerTermin = new DateTimePicker();
            textBoxKoszt = new TextBox();
            buttonZapisz = new Button();
            buttonPrzejdzDoPrzypisania = new Button();
            labelStatusBazy = new Label();

            // textBoxNazwa
            textBoxNazwa.Location = new Point(30, 30);
            textBoxNazwa.Name = "textBoxNazwa";
            textBoxNazwa.PlaceholderText = "Nazwa kontrahenta";
            textBoxNazwa.Size = new Size(250, 23);
            textBoxNazwa.TabIndex = 0;

            // textBoxKodPocztowy
            textBoxKodPocztowy.Location = new Point(30, 65);
            textBoxKodPocztowy.Name = "textBoxKodPocztowy";
            textBoxKodPocztowy.PlaceholderText = "Kod pocztowy";
            textBoxKodPocztowy.Size = new Size(250, 23);
            textBoxKodPocztowy.TabIndex = 1;

            // textBoxUlica
            textBoxUlica.Location = new Point(30, 100);
            textBoxUlica.Name = "textBoxUlica";
            textBoxUlica.PlaceholderText = "Ulica";
            textBoxUlica.Size = new Size(250, 23);
            textBoxUlica.TabIndex = 2;

            // textBoxMiasto
            textBoxMiasto.Location = new Point(30, 135);
            textBoxMiasto.Name = "textBoxMiasto";
            textBoxMiasto.PlaceholderText = "Miasto";
            textBoxMiasto.Size = new Size(250, 23);
            textBoxMiasto.TabIndex = 3;

            // textBoxNIP
            textBoxNIP.Location = new Point(30, 170);
            textBoxNIP.Name = "textBoxNIP";
            textBoxNIP.PlaceholderText = "NIP";
            textBoxNIP.Size = new Size(250, 23);
            textBoxNIP.TabIndex = 4;

            // textBoxEmail
            textBoxEmail.Location = new Point(30, 205);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.PlaceholderText = "Email kontrahenta";
            textBoxEmail.Size = new Size(250, 23);
            textBoxEmail.TabIndex = 5;

            // radioButtonFirma
            radioButtonFirma.Location = new Point(30, 240);
            radioButtonFirma.Name = "radioButtonFirma";
            radioButtonFirma.Size = new Size(100, 24);
            radioButtonFirma.TabIndex = 6;
            radioButtonFirma.Text = "Firma";
            radioButtonFirma.Checked = true;

            // radioButtonOsobaPrywatna
            radioButtonOsobaPrywatna.Location = new Point(140, 240);
            radioButtonOsobaPrywatna.Name = "radioButtonOsobaPrywatna";
            radioButtonOsobaPrywatna.Size = new Size(140, 24);
            radioButtonOsobaPrywatna.TabIndex = 7;
            radioButtonOsobaPrywatna.Text = "Osoba prywatna";

            // comboBoxMaterial
            comboBoxMaterial.Items.AddRange(new object[] { "Węgiel kamienny", "Węgiel brunatny", "Biopaliwo stałe", "Stałe paliwo wtórne" });
            comboBoxMaterial.Location = new Point(30, 280);
            comboBoxMaterial.Name = "comboBoxMaterial";
            comboBoxMaterial.Size = new Size(250, 23);
            comboBoxMaterial.TabIndex = 8;

            // dateTimePickerPobrania
            dateTimePickerPobrania.Location = new Point(30, 315);
            dateTimePickerPobrania.Name = "dateTimePickerPobrania";
            dateTimePickerPobrania.Size = new Size(250, 23);
            dateTimePickerPobrania.TabIndex = 9;

            // dateTimePickerTermin
            dateTimePickerTermin.Location = new Point(30, 350);
            dateTimePickerTermin.Name = "dateTimePickerTermin";
            dateTimePickerTermin.Size = new Size(250, 23);
            dateTimePickerTermin.TabIndex = 10;

            // textBoxKoszt
            textBoxKoszt.Location = new Point(30, 385);
            textBoxKoszt.Name = "textBoxKoszt";
            textBoxKoszt.PlaceholderText = "Koszt analiz (PLN)";
            textBoxKoszt.Size = new Size(250, 23);
            textBoxKoszt.TabIndex = 11;

            // buttonZapisz
            buttonZapisz.Location = new Point(30, 420);
            buttonZapisz.Name = "buttonZapisz";
            buttonZapisz.Size = new Size(120, 30);
            buttonZapisz.TabIndex = 12;
            buttonZapisz.Text = "Zapisz zlecenie";
            buttonZapisz.UseVisualStyleBackColor = true;
            buttonZapisz.Click += new EventHandler(this.buttonZapisz_Click);

            // buttonPrzejdzDoPrzypisania
            buttonPrzejdzDoPrzypisania.Location = new Point(160, 420);
            buttonPrzejdzDoPrzypisania.Name = "buttonPrzejdzDoPrzypisania";
            buttonPrzejdzDoPrzypisania.Size = new Size(120, 30);
            buttonPrzejdzDoPrzypisania.TabIndex = 13;
            buttonPrzejdzDoPrzypisania.Text = "Przypisz analizy";
            buttonPrzejdzDoPrzypisania.UseVisualStyleBackColor = true;
            buttonPrzejdzDoPrzypisania.Click += new EventHandler(this.buttonPrzejdzDoPrzypisania_Click);

            // labelStatusBazy
            labelStatusBazy.Location = new Point(30, 460);
            labelStatusBazy.Name = "labelStatusBazy";
            labelStatusBazy.Size = new Size(250, 23);
            labelStatusBazy.TabIndex = 14;
            labelStatusBazy.Text = "Status bazy danych: Oczekiwanie...";
            labelStatusBazy.TextAlign = ContentAlignment.MiddleCenter;

            // Form1
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(320, 510);
            this.Controls.Add(textBoxNazwa);
            this.Controls.Add(textBoxKodPocztowy);
            this.Controls.Add(textBoxUlica);
            this.Controls.Add(textBoxMiasto);
            this.Controls.Add(textBoxNIP);
            this.Controls.Add(textBoxEmail);
            this.Controls.Add(radioButtonFirma);
            this.Controls.Add(radioButtonOsobaPrywatna);
            this.Controls.Add(comboBoxMaterial);
            this.Controls.Add(dateTimePickerPobrania);
            this.Controls.Add(dateTimePickerTermin);
            this.Controls.Add(textBoxKoszt);
            this.Controls.Add(buttonZapisz);
            this.Controls.Add(buttonPrzejdzDoPrzypisania);
            this.Controls.Add(labelStatusBazy);
            this.Name = "Form1";
            this.Text = "Przyjęcie zlecenia - Laboratorium";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
