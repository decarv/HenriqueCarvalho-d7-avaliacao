using System;
using System.Data.SqlClient;

namespace D7
{
    internal class Database
    {
        internal readonly string connectionString = $"Server=labsoft.pcs.usp.br; " +
            $"Initial Catalog=db_10; User id=usuario_10; pwd=1169847323;";

        internal byte[] ReadHashedPasswordPlusSalt(string username) // OK
        {
            byte[] hashedPassword = new byte[256];
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT HashedPassword FROM users_d7 WHERE Username = @Username";
                using (SqlCommand cmd = new(query, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            hashedPassword = Convert.FromHexString(Convert.ToString(reader["HashedPassword"]));
                        }
                    }
                }
            }
            return hashedPassword; 
        }

    }
}
