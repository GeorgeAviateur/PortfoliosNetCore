using Npgsql;

namespace ResumeCleanAtchitecture.WebUI.Developer.test
{
    public class testDB
    {

        static void Main(string[] args)
        {
            string connectionString = "Host=your-host;Database=your-db;Username=your-username;Password=your-password";
            connectionString = "postgres://localhost:localhost@localhost:5432/database";
            try
            {
                using var conn = new NpgsqlConnection(connectionString);
                conn.Open();
                Console.WriteLine("Connection successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Connection failed: {ex.Message}");
            }
        }
    }
}
