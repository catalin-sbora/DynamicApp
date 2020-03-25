using System;

namespace DynamicApp.Abstractions
{
    public interface IDynamicModule
    {
        string Name { get; }
        void InitializeModule(string initializeData);
        IMenu GetModuleMenu();
    }
}
