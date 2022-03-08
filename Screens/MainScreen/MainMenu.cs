using System;
using BlogDapper.Screens.TagScreen;

namespace BlogDapper.Screens
{
    public static class MainMenu
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("My Blog");
            Console.WriteLine("------------------------------");
            Console.WriteLine("What do you want do to?");
            Console.WriteLine("1 - User management");
            Console.WriteLine("2 - Role management");
            Console.WriteLine("3 - Category management");
            Console.WriteLine("4 - Tag management");
            Console.WriteLine("5 - Link Role/User");
            Console.WriteLine("6 - Link Post/Tag");
            Console.WriteLine("7 - Reports");
            Console.WriteLine("8 - Exit");
            Console.WriteLine("");
            Console.WriteLine("");

            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    MenuUserScreen.Load();
                    break;
                case 2:
                    MenuRoleScreen.Load();
                    break;
                case 3:
                    MenuCategoryScreen.Load();
                    break;
                case 4:
                    MenuTagScreen.Load();
                    break;
                case 8:
                    Console.WriteLine("The application will be closed.");
                    break;
                default:
                    Load();
                    break;
            }
        }
    }
}
