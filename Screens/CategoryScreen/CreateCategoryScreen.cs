using System;
using BlogDapper.Repositories;
using Blog.Models;

namespace BlogDapper.Screens.TagScreen
{
    public static class CreateCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("===========================");
            Console.WriteLine("New Category");
            Console.WriteLine("===========================");

            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            Insert(new Category { Name = name, Slug = slug });

            Console.WriteLine($"===========================");
            Console.WriteLine("Press a key to continue...");
            Console.WriteLine($"===========================");

            Console.ReadKey();
            MainMenu.Load();
        }

        public static void Insert(Category category)
        {
            try
            {
                var repository = new Repository<Category>();
                repository.Insert (category);
                Console
                    .WriteLine("The new category was registerd successfully");
            }
            catch (System.Exception ex)
            {
                Console
                    .WriteLine("It was not possible to insert a new category");
                Console.WriteLine(ex.Message);
            }
        }
    }
}
