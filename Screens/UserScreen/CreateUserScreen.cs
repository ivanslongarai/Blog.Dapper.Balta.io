using System;
using BlogDapper.Repositories;
using Blog.Models;

namespace BlogDapper.Screens.TagScreen
{
    public static class CreateUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("===========================");
            Console.WriteLine("New User");
            Console.WriteLine("===========================");

            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.Write("Email: ");
            var email = Console.ReadLine();

            Console.Write("Password: ");
            var password = Console.ReadLine();

            Console.Write("Biography: ");
            var bio = Console.ReadLine();

            Console.Write("Image: ");
            var image = Console.ReadLine();

            Console.Write("Slug: ");
            var slug = Console.ReadLine();

            Insert(new User {
                Name = name,
                Email = email,
                PasswordHash = password,
                Bio = bio,
                Image = image,
                Slug = slug
            });

            Console.WriteLine($"===========================");
            Console.WriteLine("Press a key to continue...");
            Console.WriteLine($"===========================");

            Console.ReadKey();
            MainMenu.Load();
        }

        public static void Insert(User user)
        {
            try
            {
                var repository = new Repository<User>();
                repository.Insert (user);
                Console.WriteLine("The new user was registerd successfully");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("It was not possible to insert a new user");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
