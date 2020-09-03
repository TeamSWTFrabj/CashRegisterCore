using System;

namespace CashRegister
{
    class Program
    {
        static void Main(string[] args)
        {
            Register uut = new Register();

            uut.AddItem(45.0);

            if (uut.GetNItems() == 1)
            {
                Console.WriteLine("GetNItems == 1 passed");
            }
            else
            {
                Console.WriteLine("GetNItems == 1 failed");
            }
        }
    }
}
