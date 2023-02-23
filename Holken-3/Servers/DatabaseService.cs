using Holken_3.Models;
using Microsoft.Data.SqlClient;

namespace Holken_3.Servers
{
    internal class DatabaseService
    {
        private readonly string _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Berrr\Desktop\SQL-db-Holken3\case-management-Holken-3\Holken-3\Data\local_sql.mdf;Integrated Security=True";
        public void SaveToDatabase(Renter renter)
        {
            using var conn = new SqlConnection(_connectionString);
            conn.Open();

            using var cmd = new SqlCommand("SELECT Id FROM Renter_Addresses WHERE StreetName = @StreetName AND PostalCode = @PostalCode", conn);
            cmd.Parameters.AddWithValue("@StreetName", renter.PostalAddress.StreetName);
            cmd.Parameters.AddWithValue("@StreetName", renter.PostalAddress.PostalCode);
        }

    }
}
