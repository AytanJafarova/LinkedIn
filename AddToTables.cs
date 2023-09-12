using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn
{
    public class AddToTables
    {
        public void InsertNewUser(string connectionString, string name, string middle_name, string surname, string email, string password, string location)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                // Middle name column duzelt
                string query = $"INSERT INTO Users (name, surname, mmiddle_name, password, email, location) VALUES (@name, @surname, @middle_name, @password, @email, @location);";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@surname", surname);
                    command.Parameters.AddWithValue("@middle_name", middle_name);
                    command.Parameters.AddWithValue("@password", password);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@location", location);


                    command.ExecuteNonQuery();
                }
            }
        }
        public void InsertNewAccount(string connectionString, string headline, string summary, string job_industry, int user_id)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
               
                string query = $"INSERT INTO Accounts (headline, summary, job_industry, user_id) VALUES (@headline, @summary, @job_industry, @user_id);";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@headline", headline);
                    command.Parameters.AddWithValue("@summary", summary);
                    command.Parameters.AddWithValue("@job_industry", job_industry);
                    command.Parameters.AddWithValue("@user_id", user_id);

                    command.ExecuteNonQuery();
                }
            }
        }



    }
}
