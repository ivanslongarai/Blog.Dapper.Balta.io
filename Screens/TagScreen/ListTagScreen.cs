using System;
using BlogDapper.Repositories;
using Blog.Models;

namespace BlogDapper.Screens.TagScreen
{
    public static class ListTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine($"===========================");
            Console.WriteLine($"Tags List");
            Console.WriteLine($"===========================");
            List();
            Console.ReadKey();
        }

        private static void List()
        {
            var repository = new Repository<Tag>();
            var tags = repository.GetAll();
            foreach (var tag in tags)
            {
                Console.WriteLine($"{tag.Id} - {tag.Name} - {tag.Slug}");
            }

            Console.WriteLine($"===========================");
            Console.WriteLine("Press a key to continue...");
            Console.WriteLine($"===========================");            
            
            Console.ReadKey();
            MainMenu.Load();
        }
    }
}
