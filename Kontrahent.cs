using System;
using System.Configuration; // Do odczytu z App.config
using Npgsql; // Biblioteka do obsługi PostgreSQL

namespace ProjektLaboratorium
{
    public abstract class Kontrahent : InterfejsZapisywalny
    {
        public string Nazwa { get; set; }
        public string KodPocztowy { get; set; }
        public string Ulica { get; set; }
        public string Miasto { get; set; }
        public string NIP { get; set; }
        public string Email { get; set; }

        public abstract void Zapisz();
    }

    public class Klient : Kontrahent
    {
        public override void Zapisz()
        {
            // Pobranie connection string z App.config
            string connectionString = ConfigurationManager.ConnectionStrings["PostgresConnection"].ConnectionString;

            using (var connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // Nawiązanie połączenia

                    // Przygotowanie zapytania SQL
                    string query = "INSERT INTO Kontrahent (Nazwa, KodPocztowy, Ulica, Miasto, NIP, Email) " +
                                   "VALUES (@Nazwa, @KodPocztowy, @Ulica, @Miasto, @NIP, @Email)";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        // Dodawanie parametrów
                        command.Parameters.AddWithValue("@Nazwa", Nazwa);
                        command.Parameters.AddWithValue("@KodPocztowy", KodPocztowy);
                        command.Parameters.AddWithValue("@Ulica", Ulica);
                        command.Parameters.AddWithValue("@Miasto", Miasto);
                        command.Parameters.AddWithValue("@NIP", NIP);
                        command.Parameters.AddWithValue("@Email", Email);

                        command.ExecuteNonQuery(); // Wykonanie zapytania
                        Console.WriteLine("Dane zostały zapisane pomyślnie.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Błąd podczas zapisywania danych: {ex.Message}");
                }
            }
        }
    }
}