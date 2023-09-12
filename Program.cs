using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using Npgsql;
using System.Data;

namespace LinkedIn
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Connection stringi deyish
            string connectionString = "Host=localhost; Port=5432; Database=Linkedin; Username=postgres; Password=2023";

            SelectFromTables selectFromTables = new SelectFromTables();
            DeleteFromTables deleteFromTables = new DeleteFromTables();
            UpdateInTables updateInTables = new UpdateInTables();
            AddToTables addToTables = new AddToTables();
            
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    if (connection.State == ConnectionState.Open)
                    {
                        Console.WriteLine("Connection opened.");
                    }
                    else
                    {
                        Console.WriteLine("Connection failed to open.");
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                Console.WriteLine("Connection error: " + ex.Message);
            }
            Console.WriteLine("\n_____________________________________________________________________\n");



            selectFromTables.SelectAllUsers(connectionString);
            //deleteFromTables.DeleteFromTableById(connectionString, 2, "Users");
            //updateInTables.UpdateDataByID(connectionString, "Users", "name", 1,"Aysu");
            //addToTables.InsertNewUser(connectionString, "Nadir", "Aydin", "Jafar", "nadirjafar@", "ffdf", "ffdfd");
            //selectFromTables.SelectAllUsers(connectionString);
            //addToTables.InsertNewAccount(connectionString, "1C Administrator", "I am motivated employer", "Accouhnting", 3);
            selectFromTables.SelectAllAccounts(connectionString);

        }
    }
}
