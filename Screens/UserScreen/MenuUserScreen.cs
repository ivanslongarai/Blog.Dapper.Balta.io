using System;

namespace BlogDapper.Screens.TagScreen
{
    public static class MenuUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("User management");
            Console.WriteLine("------------------------------");
            Console.WriteLine("What do you want do to?");
            Console.WriteLine("1 - List Users");
            Console.WriteLine("2 - Insert User");
            Console.WriteLine("3 - Link a User with a Role");
            Console.WriteLine("4 - Go Back");
            Console.WriteLine("");
            Console.WriteLine("");

            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListUserScreen.Load();
                    break;
                case 2:
                    CreateUserScreen.Load();
                    break;
                case 3:
                    LinkUserWithRole.Load();
                    break;
                case 4:
                    MainMenu.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }
    }
}
