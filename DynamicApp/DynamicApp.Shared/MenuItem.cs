using DynamicApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicApp.Shared
{
    public class MenuItem : IMenu
    {
        private readonly Action<object[]> actionToExecute;
        public MenuItem(Action<object[]> actionToExecute)
        {
            this.actionToExecute = actionToExecute;
        }
        public string DisplayText { get; set; }

        public void Execute(object[] args)
        {
            actionToExecute?.Invoke(args);
        }

        public void Render()
        {
            Console.WriteLine($"{DisplayText}");
        }
    }
}
