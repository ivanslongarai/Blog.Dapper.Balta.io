using System;
using BlogDapper.Repositories;
using Blog.Models;

namespace BlogDapper.Screens.TagScreen
{
    public static class ListCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine($"===========================");
            Console.WriteLine($"Category List");
            Console.WriteLine($"===========================");
            List();
            Console.ReadKey();
        }

        private static void List()
        {
            var repository = new Repository<Category>();
            var categories = repository.GetAll();
            foreach (var category in categories)
            {
                Console
                    .WriteLine($"{category.Id} - {category.Name} - " +
                    $"{category.Slug}");
            }

            Console.WriteLine($"===========================");
            Console.WriteLine("Press a key to continue...");
            Console.WriteLine($"===========================");

            Console.ReadKey();
            MainMenu.Load();
        }
    }
}
