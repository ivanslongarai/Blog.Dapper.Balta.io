using System;
using BlogDapper.Repositories;
using Blog.Models;

namespace BlogDapper.Screens.TagScreen
{
    public static class UpdateTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("===========================");
            Console.WriteLine("Updating a tag");
            Console.WriteLine("===========================");

            Console.Write("Id: ");
            var id = Console.ReadLine();
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            Update(new Tag { Id = int.Parse(id), Name = name, Slug = slug });
            Console.ReadKey();
        }

        public static void Update(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>();
                repository.Update (tag);
                Console.WriteLine("The tag was updated successfully");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("It was not possible to update the tag");
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine($"===========================");
            Console.WriteLine("Press a key to continue...");
            Console.WriteLine($"===========================");

            Console.ReadKey();
            MainMenu.Load();
        }
    }
}
