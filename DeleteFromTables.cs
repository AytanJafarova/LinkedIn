using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn
{
    public class DeleteFromTables
    {

        public void DeleteUserById(string connectionString, int userId)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "DELETE FROM Accounts WHERE user_id = @userId; DELETE FROM Users WHERE user_id = @userId; ";


                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", userId);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Delete successful.");
                    }
                    else
                    {
                        Console.WriteLine("No records were deleted.");
                    }
                }
            }
        }

        // Flexible form of the function
        public void DeleteFromTableById(string connectionString, int id, string tableName)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = $"DELETE FROM {tableName} WHERE user_id = @userId; ";


                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", id);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Delete successful.");
                    }
                    else
                    {
                        Console.WriteLine("No records were deleted.");
                    }
                }
            }
        }

    }
}
