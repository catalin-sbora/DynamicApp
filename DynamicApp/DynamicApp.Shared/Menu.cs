using DynamicApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DynamicApp.Shared
{
    public class Menu : IMenu
    {
        private readonly List<IMenu> menuItems = new List<IMenu>();
        private bool continueLoop = true;

        private int ReadOption()
        {
            var optionStr = Console.ReadLine();
            int option = 0;
            while (!int.TryParse(optionStr, out option) || (option >= menuItems.Count() || option < 0))
            {
                Console.WriteLine("Please enter a valid menu option");
                optionStr = Console.ReadLine();
            }
            return option;
        }
        public Menu(IEnumerable<IMenu> menuItems)
        {
            this.menuItems.Add(new MenuItem((args => { continueLoop = false; })) { DisplayText = "Exit"});
            if (menuItems != null)
            {
                this.menuItems
                .AddRange(menuItems);
            }
        }

        public string DisplayText {get; set;}
        

        public void Execute(object[] args)
        {
            continueLoop = true;            
            do
            {
                RenderMenuItems();
                Console.WriteLine("\n\nPlease enter your option: ");
                int option = ReadOption();
                var selectedItem = menuItems.ElementAt(option);
                selectedItem.Execute(new [] { this });

            } while (continueLoop);
        }
        private void RenderMenuItems()
        {
            Console.Clear();
            int index = 0;
            foreach (var menuItem in menuItems)
            {
                Console.Write($"{index++}.");
                menuItem.Render();
            }
        }

        public void Render()
        {
            Console.WriteLine($"{DisplayText}");
        }
    }
}
