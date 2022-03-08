using System;

namespace BlogDapper.Screens.TagScreen
{
    public static class MenuRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Role management");
            Console.WriteLine("------------------------------");
            Console.WriteLine("What do you want do to?");
            Console.WriteLine("1 - List Roles");
            Console.WriteLine("2 - Insert Role");
            Console.WriteLine("3 - Go Back");
            Console.WriteLine("");
            Console.WriteLine("");

            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListRoleScreen.Load();
                    break;
                case 2:
                    CreateRoleScreen.Load();
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
