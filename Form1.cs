using System;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;
using System.Drawing;

namespace ProjektLaboratorium
{
    public partial class Form1 : Form
    {
        private string connectionString;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            connectionString = ConfigurationManager.ConnectionStrings["PostgresConnection"].ConnectionString;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TestDatabaseConnection();
        }

        private void TestDatabaseConnection()
        {
            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    labelStatusBazy.Text = "Po³¹czenie z baz¹ danych: Sukces!";
                    labelStatusBazy.ForeColor = Color.Green;
                }
                catch (Exception)
                {
                    labelStatusBazy.Text = "Brak komunikacji z baz¹ danych";
                    labelStatusBazy.ForeColor = Color.Red;
                }
            }
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            Klient klient = new Klient
            {
                Nazwa = textBoxNazwa.Text,
                KodPocztowy = textBoxKodPocztowy.Text,
                Ulica = textBoxUlica.Text,
                Miasto = textBoxMiasto.Text,
                NIP = textBoxNIP.Text,
                Email = textBoxEmail.Text
            };

            klient.Zapisz();
            MessageBox.Show("Dane zosta³y zapisane do bazy danych!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonPrzejdzDoPrzypisania_Click(object sender, EventArgs e)
        {
            // Poprawione: otwieranie AnalizyForm zamiast nieistniej¹cego Form2
            using (var analizyForm = new AnalizyForm())
            {
                analizyForm.ShowDialog();
            }
        }

        private void textBoxNazwa_TextChanged(object sender, EventArgs e)
        {
            // Tu mo¿esz dodaæ dodatkowe akcje przy zmianie nazwy
        }
    }
}
