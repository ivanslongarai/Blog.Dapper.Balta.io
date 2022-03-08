using System;
using BlogDapper.Repositories;
using Blog.Models;

namespace BlogDapper.Screens.TagScreen
{
    public static class LinkUserWithRole
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine($"===========================");
            Console.WriteLine($"Link User with a Role");
            Console.WriteLine($"===========================");

            Console.Write("User Id: ");
            var userId = Console.ReadLine();

            Console.Write("Role Id: ");
            var roleId = Console.ReadLine();

            try
            {
                LinkData(int.Parse(userId), int.Parse(roleId));
                Console.WriteLine("The data was linked successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("It was not possible to link the data");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"===========================");
            Console.WriteLine("Press a key to continue...");
            Console.WriteLine($"===========================");

            Console.ReadKey();
            MainMenu.Load();
        }

        private static void LinkData(int userId, int roleId)
        {
            var repository = new UserRepository();
            repository.LinkUserWithRole (userId, roleId);
        }
    }
}
