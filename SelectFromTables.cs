using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn
{
    public class SelectFromTables
    {
        public List<T> SelectAll<T>(string connectionString, string tableName, Func<NpgsqlDataReader, T> mapFunction)
        {
            List<T> list = new List<T>();
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = $"SELECT * FROM {tableName};";
                
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            T item = mapFunction(reader);
                            list.Add(item);
                        }
                    }
                }
            }
            return list;

        }
        public static Users MapUser(NpgsqlDataReader reader)
        {
            return new Users
            {
                // Column indexleri duzelt
                user_id = reader.GetInt32(0),
                email = reader.GetString(4),
                password = reader.GetString(5),
                name = reader.GetString(1),
                surname = reader.GetString(2),
                middle_name = reader.GetString(3),
                location = reader.GetString(6)
        };
        }

        public void SelectAllUsers(string connectionString)
        {
            Console.WriteLine("                                                             Users Table\n");

            List<Users> users  = SelectAll(connectionString, "Users", MapUser);
            foreach (var user in users)
            {
                Console.WriteLine($"User ID: {user.user_id}, Email: {user.email}, Name: {user.name} {user.surname} {user.middle_name}, Password: {user.password}, Location: {user.location} ");
            }
        }

        public static Accounts MapAccount(NpgsqlDataReader reader)
        {
            return new Accounts
            {
                // Column indexleri duzelt
                account_id = reader.GetInt32(0),
                user_id = reader.GetInt32(4),
                headline = reader.GetString(1),
                summary = reader.GetString(2),
                job_industry = reader.GetString(3)
        };
        }

        public void SelectAllAccounts(string connectionString)
        {
            Console.WriteLine("                                                             Accounts Table\n");

            List<Accounts> accounts  = SelectAll(connectionString, "Accounts", MapAccount);
            foreach (var account in accounts)
            {
                Console.WriteLine($"Account ID: {account.account_id}, User ID: {account.user_id}, Headline: {account.headline}, Summary: {account.summary}, Job Industry: {account.job_industry} ");
            }
        }

    }
}
