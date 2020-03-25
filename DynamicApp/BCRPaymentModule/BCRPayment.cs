using DynamicApp.Abstractions;
using DynamicApp.Shared;
using System;

namespace BCRPaymentModule
{
    public class BCPPayment : IDynamicModule
    {
        public string Name 
        {
            get
            {
                return "BCR Payment Module";
            }
        }

        public IMenu GetModuleMenu()
        {
            IMenu retMenu = new MenuItem((parameters)=> 
            { 
                Console.WriteLine("BCR PaymentModule Execute"); 
                Console.ReadLine(); 
            }) { DisplayText = Name };

            return retMenu;
        }

        public void InitializeModule(string initializeData)
        {
            //throw new NotImplementedException();
        }
    }
}
