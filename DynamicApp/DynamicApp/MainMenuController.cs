using DynamicApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicApp
{
    public class MainMenuController
    {
        private readonly List<IMenu> menuItems = new List<IMenu>();  
        
        public MainMenuController(IEnumerable<IMenu> menuItems)
        {
            this.menuItems
                .AddRange(menuItems);
        }
        public void LoadMenu()
        { 
            
        }
    }
}
