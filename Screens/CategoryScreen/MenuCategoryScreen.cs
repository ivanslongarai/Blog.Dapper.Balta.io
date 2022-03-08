using System;

namespace BlogDapper.Screens.TagScreen
{
    public static class MenuCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Role management");
            Console.WriteLine("------------------------------");
            Console.WriteLine("What do you want do to?");
            Console.WriteLine("1 - List Categories");
            Console.WriteLine("2 - Insert Category");
            Console.WriteLine("3 - Go Back");
            Console.WriteLine("");
            Console.WriteLine("");

            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListCategoryScreen.Load();
                    break;
                case 2:
                    CreateCategoryScreen.Load();
                    break;
                case 3:
                    MainMenu.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }
    }
}
