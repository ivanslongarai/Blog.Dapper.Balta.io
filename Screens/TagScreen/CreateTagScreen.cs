using System;
using BlogDapper.Repositories;
using Blog.Models;

namespace BlogDapper.Screens.TagScreen
{
    public static class CreateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("===========================");
            Console.WriteLine("New tag");
            Console.WriteLine("===========================");

            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            Insert(new Tag { Name = name, Slug = slug });

            Console.WriteLine($"===========================");
            Console.WriteLine("Press a key to continue...");
            Console.WriteLine($"===========================");

            Console.ReadKey();
            MainMenu.Load();
        }

        public static void Insert(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>();
                repository.Insert (tag);
                Console.WriteLine("The new tag was registerd successfully");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("It was not possible to insert a new tag");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
