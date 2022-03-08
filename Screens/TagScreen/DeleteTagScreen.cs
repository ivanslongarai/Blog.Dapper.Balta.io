using System;
using BlogDapper.Repositories;
using Blog.Models;

namespace BlogDapper.Screens.TagScreen
{
    public static class DeleteTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("===========================");
            Console.WriteLine("Deleting a tag");
            Console.WriteLine("===========================");

            Console.Write("Id: ");
            var id = Console.ReadLine();
            Delete(new Tag { Id = int.Parse(id) });
            Console.ReadKey();
        }

        public static void Delete(Tag tag)
        {
            try
            {
                var repository = new Repository<Tag>();
                repository.Delete (tag);
                Console.WriteLine("The tag was deleted successfully");
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("It was not possible to delete the tag");
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
