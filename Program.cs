using System;

namespace InterActiveMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            // int b = ((int)Console.ReadKey(true).KeyChar);

            Menu menu = new Menu();

            menu.AddMenuItem("Date ", PrintCurrentDate);
            menu.AddMenuItem("About Me ", OscarInfo);
            menu.AddMenuItem("INfo About Frans", FransInfo);
            menu.AddMenuItem("Info ERIK", EricInfo);

            menu.ShowMenu();
        }

        static void PrintCurrentDate()
        {

            Console.WriteLine(DateTime.Now);
        }

        static void OscarInfo()
        {
            Console.WriteLine("Name: Oscar!!");
        }

        static void FransInfo()
        {
            Console.WriteLine("Name: Frans");
        }

        static void EricInfo()
        {
            Console.WriteLine("Name: FLERIC ");
        }
    }
}
