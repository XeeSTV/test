using System;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;

namespace ProjektLaboratorium
{
    public partial class AnalizyForm : Form
    {
        private readonly string _connectionString;

        public AnalizyForm()
        {
            InitializeComponent();

            _connectionString = ConfigurationManager
                .ConnectionStrings["PostgresConnection"]
                .ConnectionString;

            radioWegiel.CheckedChanged += Radio_CheckedChanged;
            radioBiopaliwo.CheckedChanged += Radio_CheckedChanged;
            radioPaliwoWtorne.CheckedChanged += Radio_CheckedChanged;
        }

        private void Radio_CheckedChanged(object sender, EventArgs e)
        {
            var radio = sender as RadioButton;
            if (radio != null && radio.Checked)
            {
                LoadAnalizyZBazy(GetTableName(radio));
            }
        }

        private string GetTableName(RadioButton radio) =>
            radio.Name switch
            {
                "radioWegiel" => "analizy_wegiel_kamienny",
                "radioBiopaliwo" => "analizy_biopaliwo_stale",
                "radioPaliwoWtorne" => "analizy_stale_paliwo_wtorne",
                _ => throw new ArgumentException("Nieznany rodzaj paliwa")
            };

        private void LoadAnalizyZBazy(string tableName)
        {
            panelCheckboxow.Controls.Clear();

            // 1) Dodaj nagłówki
            int y = 10;
            var lblHeaderAnaliza = new Label
            {
                Text = "Analiza",
                Location = new Point(10, y),
                Size = new Size(260, 24),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                AutoSize = false
            };
            var lblHeaderCena = new Label
            {
                Text = "Cena (netto)",
                Location = new Point(280, y),
                Size = new Size(100, 24),
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                AutoSize = false
            };
            panelCheckboxow.Controls.Add(lblHeaderAnaliza);
            panelCheckboxow.Controls.Add(lblHeaderCena);

            y += 30;

            using var conn = new NpgsqlConnection(_connectionString);
            conn.Open();
            string sql = $"SELECT analiza, norma, koszt FROM {tableName} ORDER BY id";
            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string nazwaAnalizy = reader.GetString(0);
                string norma = reader.GetString(1);
                decimal koszt = reader.GetDecimal(2);

                // separator
                var sep = new Label
                {
                    BackColor = Color.Black,
                    Location = new Point(10, y),
                    Size = new Size(panelCheckboxow.ClientSize.Width - 20, 1)
                };
                panelCheckboxow.Controls.Add(sep);
                y += 5;

                // Label: nazwa analizy
                var lblNazwa = new Label
                {
                    Text = nazwaAnalizy,
                    Location = new Point(10, y),
                    Size = new Size(260, 24),
                    AutoSize = false
                };
                // Label: norma (pod nazwą)
                var lblNorma = new Label
                {
                    Text = norma,
                    Location = new Point(10, y + 24),
                    Size = new Size(260, 20),
                    AutoSize = false,
                    Font = new Font(this.Font.FontFamily, 8F, FontStyle.Italic)
                };
                // Label: cena
                var lblCena = new Label
                {
                    Text = $"{koszt:F2} zł",
                    Location = new Point(280, y),
                    Size = new Size(100, 24),
                    AutoSize = false
                };
                // CheckBox
                var cb = new CheckBox
                {
                    Location = new Point(390, y + 4),
                    AutoSize = true
                };

                panelCheckboxow.Controls.Add(lblNazwa);
                panelCheckboxow.Controls.Add(lblNorma);
                panelCheckboxow.Controls.Add(lblCena);
                panelCheckboxow.Controls.Add(cb);

                y += 50; // 24 (nazwa) + 20 (norma) + spacing
            }
        }
    }
}
