using System;
using TECHCOOL;

namespace databaseconnection
{
    class Program
    {
        static void Main(string[] args)
        {
            SQLet.ConnectSqlServer("todo", "ADAMS-BÆRBAR\\MSSQLSERVER01");
            string[][] result = SQLet.GetArray("SELECT title FROM todo");

            foreach (string[] col in result)
            {
                Console.WriteLine("Todo: " + col[0]);
            }

            string new_todo = Console.ReadLine();

            string sql_insert = $"INSERT INTO todo (title) VALUES ('{new_todo}')";

            Console.WriteLine(sql_insert);

            SQLet.Execute(sql_insert);
        }
    }
}