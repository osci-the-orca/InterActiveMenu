using System;
using System.Collections.Generic;

namespace InterActiveMenu
{


    internal class Menu
    {

        List<MenuItem> menuItems = new();
        public int index;

        public void AddMenuItem(string menuItemName, Action method)
        {
            MenuItem menuItem = new(menuItemName, method);
            menuItems.Add(menuItem);
        }

        public void ShowMenu()
        {
            Console.CursorVisible = false;
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("MENU\n");
                Console.ResetColor();
                NavigateMenu(menuItems);
            }
        }

        public void NavigateMenu(List<MenuItem> menuOptions)
        {
            for (int i = 0; i < menuOptions.Count; i++)
            {
                if (i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine(menuOptions[i].menuItemName);
                }
                else
                {
                    Console.WriteLine(menuOptions[i].menuItemName);
                }
                Console.ResetColor();
            }

            ConsoleKeyInfo keyPressed = Console.ReadKey(true);

            if (keyPressed.Key == ConsoleKey.DownArrow)
            {
                if (index == menuOptions.Count - 1)
                {
                    index = 0;
                }
                else
                {
                    index++;
                }
            }
            else if (keyPressed.Key == ConsoleKey.UpArrow)
            {
                if (index <= 0)
                {
                    index = menuOptions.Count - 1;
                }
                else
                {
                    index--;
                }
            }
            else if (keyPressed.Key == ConsoleKey.LeftArrow)
            {
                Console.Clear();
            }
            else if (keyPressed.Key == ConsoleKey.RightArrow)
            {
                Console.Clear();
            }
            else if (keyPressed.Key == ConsoleKey.Enter)
            {

                Console.WriteLine("\n");
                menuOptions[index].method();
                Console.ReadKey(true);
            }
            Console.Clear();
        }
    }
}
