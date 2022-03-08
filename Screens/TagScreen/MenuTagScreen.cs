using System;

namespace BlogDapper.Screens.TagScreen
{
    public static class MenuTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Tags management");
            Console.WriteLine("------------------------------");
            Console.WriteLine("What do you want do to?");
            Console.WriteLine("1 - List Tags");
            Console.WriteLine("2 - Insert Tag");
            Console.WriteLine("3 - Update Tag");
            Console.WriteLine("4 - Delete Tag");
            Console.WriteLine("5 - Go Back");
            Console.WriteLine("");
            Console.WriteLine("");

            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListTagScreen.Load();
                    break;
                case 2:
                    CreateTagScreen.Load();
                    break;
                case 3:
                    UpdateTagScreen.Load();
                    break;
                case 4:
                    DeleteTagScreen.Load();
                    break;
                case 5:
                    MainMenu.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }
    }
}
