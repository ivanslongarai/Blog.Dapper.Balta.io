using System;
using BlogDapper.Repositories;
using Blog.Models;

namespace BlogDapper.Screens.TagScreen
{
    public static class CreateRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("===========================");
            Console.WriteLine("New role");
            Console.WriteLine("===========================");

            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            Insert(new Role { Name = name, Slug = slug });

            Console.WriteLine($"===========================");
            Console.WriteLine("Press a key to continue...");
            Console.WriteLine($"===========================");

            Console.ReadKey();
            MainMenu.Load();
        }

        public static void Insert(Role role)
        {
            try
            {
                var repository = new Repository<Role>();
                repository.Insert (role);
                Console.WriteLine("The new role was registerd successfully");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("It was not possible to insert a new role");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
