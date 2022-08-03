using DynamicApp.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicApp.Shared
{
    public class MenuItem : IMenu
    {
        private readonly Action<object[]> actionToExecute;
        private readonly ICommand command = null;
        public MenuItem(Action<object[]> actionToExecute, string text = "")
        {
            this.actionToExecute = actionToExecute;
            DisplayText = text;
        }
        public MenuItem(ICommand command, string text = "")
        { 
            this.command = command;
            DisplayText = text;
        }
        public string DisplayText { get; set; }

        public void Execute(object[] args)
        {
            actionToExecute?.Invoke(args);
            command?.Execute();
        }

        public void Render()
        {
            Console.WriteLine($"{DisplayText}");
        }
    }
}
