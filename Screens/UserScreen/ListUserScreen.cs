using System;
using BlogDapper.Repositories;
using Blog.Models;

namespace BlogDapper.Screens.TagScreen
{
    public static class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine($"===========================");
            Console.WriteLine($"User List");
            Console.WriteLine($"===========================");
            List();
            Console.ReadKey();
        }

        private static void List()
        {
            var repository = new UserRepository();
            var users = repository.GetWithRoles();
            foreach (var user in users)
            {
                string roles = "";

                foreach (var role in user.Roles)
                {
                    if (role != null)
                    {
                        if (roles != "") roles = string.Concat(roles, ", ");
                        roles = String.Concat(roles, role.Name);
                    }
                }

                Console
                    .WriteLine($"{user.Id} - {user.Name} - {user.Email} - " +
                    $"({roles})");
            }

            Console.WriteLine($"===========================");
            Console.WriteLine("Press a key to continue...");
            Console.WriteLine($"===========================");

            Console.ReadKey();
            MainMenu.Load();
        }
    }
}
