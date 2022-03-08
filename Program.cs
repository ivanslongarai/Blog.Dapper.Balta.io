using System;
using BlogDapper;
using BlogDapper.Screens;
using Microsoft.Data.SqlClient;

namespace Dapper
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.connection =
                new SqlConnection(@"Data Source=desktop-vf2hide\sqlexpress;Initial Catalog=blog;Integrated Security=True;Connect Timeout=30");

            Database.connection.Open();

            MainMenu.Load();
            Database.connection.Close();
        }
    }
}
