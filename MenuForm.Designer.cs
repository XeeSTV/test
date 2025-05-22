using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjektLaboratorium
{
    public partial class MenuForm
    {
      
        private void InitializeComponent()
        {
            this.labelNaglowek = new Label();
            this.buttonDodajZlecenie = new Button();
            this.buttonPodgladZlecen = new Button();
            this.buttonZarzadzajUzytkownikami = new Button();
            SuspendLayout();

            // labelNaglowek
            this.labelNaglowek.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            this.labelNaglowek.Location = new Point(30, 30);
            this.labelNaglowek.Name = "labelNaglowek";
            this.labelNaglowek.Size = new Size(400, 50);
            this.labelNaglowek.Text = "Menu Główne";
            this.labelNaglowek.TextAlign = ContentAlignment.MiddleCenter;

            // buttonDodajZlecenie
            this.buttonDodajZlecenie.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.buttonDodajZlecenie.Location = new Point(100, 100);
            this.buttonDodajZlecenie.Name = "buttonDodajZlecenie";
            this.buttonDodajZlecenie.Size = new Size(250, 50);
            this.buttonDodajZlecenie.Text = "Dodaj zlecenie";
            this.buttonDodajZlecenie.UseVisualStyleBackColor = true;
            this.buttonDodajZlecenie.Click += ButtonDodajZlecenie_Click; // Obsługa zdarzenia Click

            // buttonPodgladZlecen
            this.buttonPodgladZlecen.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.buttonPodgladZlecen.Location = new Point(100, 180);
            this.buttonPodgladZlecen.Name = "buttonPodgladZlecen";
            this.buttonPodgladZlecen.Size = new Size(250, 50);
            this.buttonPodgladZlecen.Text = "Podgląd zleceń";
            this.buttonPodgladZlecen.UseVisualStyleBackColor = true;

            // buttonZarzadzajUzytkownikami
            this.buttonZarzadzajUzytkownikami.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            this.buttonZarzadzajUzytkownikami.Location = new Point(100, 260);
            this.buttonZarzadzajUzytkownikami.Name = "buttonZarzadzajUzytkownikami";
            this.buttonZarzadzajUzytkownikami.Size = new Size(250, 50);
            this.buttonZarzadzajUzytkownikami.Text = "Zarządzaj użytkownikami";
            this.buttonZarzadzajUzytkownikami.UseVisualStyleBackColor = true;

            // MenuForm
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(450, 350);
            this.Controls.Add(this.labelNaglowek);
            this.Controls.Add(this.buttonDodajZlecenie);
            this.Controls.Add(this.buttonPodgladZlecen);
            this.Controls.Add(this.buttonZarzadzajUzytkownikami);
            this.Name = "MenuForm";
            this.Text = "Menu Główne";
            ResumeLayout(false);
        }

        // Event handler for "Dodaj zlecenie" button
        private void ButtonDodajZlecenie_Click(object sender, EventArgs e)
        {
            // Create and show the Form1
            Form1 form1 = new Form1();
            form1.Show();
        }

        private Label labelNaglowek;
        private Button buttonDodajZlecenie;
        private Button buttonPodgladZlecen;
        private Button buttonZarzadzajUzytkownikami;
    }
}