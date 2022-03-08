using System;
using BlogDapper.Repositories;
using Blog.Models;

namespace BlogDapper.Screens.TagScreen
{
    public static class ListRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine($"===========================");
            Console.WriteLine($"Role List");
            Console.WriteLine($"===========================");
            List();
            Console.ReadKey();
        }

        private static void List()
        {
            var repository = new Repository<Role>();
            var roles = repository.GetAll();
            foreach (var role in roles)
            {
                Console.WriteLine($"{role.Id} - {role.Name} - {role.Slug}");
            }

            Console.WriteLine($"===========================");
            Console.WriteLine("Press a key to continue...");
            Console.WriteLine($"===========================");

            Console.ReadKey();
            MainMenu.Load();
        }
    }
}
