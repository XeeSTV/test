using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ProjektLaboratorium
{
    partial class AnalizyForm
    {
        private IContainer components = null;
        private Label labelNaglowek;
        private Panel panelRadio;
        private RadioButton radioWegiel;
        private RadioButton radioBiopaliwo;
        private RadioButton radioPaliwoWtorne;
        private Panel panelCheckboxow;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new Container();
            labelNaglowek = new Label();
            panelRadio = new Panel();
            radioWegiel = new RadioButton();
            radioBiopaliwo = new RadioButton();
            radioPaliwoWtorne = new RadioButton();
            panelCheckboxow = new Panel();

            // 
            // labelNaglowek
            // 
            labelNaglowek.Dock = DockStyle.Top;
            labelNaglowek.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelNaglowek.Text = "Wybierz rodzaj paliwa i analizy";
            labelNaglowek.TextAlign = ContentAlignment.MiddleCenter;
            labelNaglowek.Height = 60;
            // 
            // panelRadio
            // 
            panelRadio.Dock = DockStyle.Top;
            panelRadio.Height = 40;
            // 
            // radioWegiel
            // 
            radioWegiel.Name = "radioWegiel";
            radioWegiel.Text = "Węgiel kamienny";
            radioWegiel.AutoSize = true;
            radioWegiel.Location = new Point(20, 10);
            // 
            // radioBiopaliwo
            // 
            radioBiopaliwo.Name = "radioBiopaliwo";
            radioBiopaliwo.Text = "Biopaliwo stałe";
            radioBiopaliwo.AutoSize = true;
            radioBiopaliwo.Location = new Point(200, 10);
            // 
            // radioPaliwoWtorne
            // 
            radioPaliwoWtorne.Name = "radioPaliwoWtorne";
            radioPaliwoWtorne.Text = "Stałe paliwo wtórne";
            radioPaliwoWtorne.AutoSize = true;
            radioPaliwoWtorne.Location = new Point(380, 10);

            panelRadio.Controls.Add(radioWegiel);
            panelRadio.Controls.Add(radioBiopaliwo);
            panelRadio.Controls.Add(radioPaliwoWtorne);

            // 
            // panelCheckboxow
            // 
            panelCheckboxow.Dock = DockStyle.Fill;
            panelCheckboxow.AutoScroll = true;

            // 
            // AnalizyForm
            // 
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(500, 550);
            this.Controls.Add(panelCheckboxow);
            this.Controls.Add(panelRadio);
            this.Controls.Add(labelNaglowek);
            this.Name = "AnalizyForm";
            this.Text = "Przypisanie analiz do paliwa";
        }
    }
}
