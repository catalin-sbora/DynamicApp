using System;
using System.Collections.Generic;
using System.Text;

namespace DynamicApp.Abstractions
{
    public interface IMenu
    {
        string DisplayText { get; set; }
        void Execute(object[] args);
        void Render();
    }
}
