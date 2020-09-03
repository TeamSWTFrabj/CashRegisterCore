using System;

namespace CashRegister
{
    public class Register
    {
        private int numberOfItems;
        private double total;

        public Register()
        {
            numberOfItems = 0;
            total = 0.0;
        }

        public void AddItem(double itemPrice)
        {
            if (itemPrice < 0)
                throw new ArgumentException("Item er mindre end nul");
            total += itemPrice;
            numberOfItems++;
        }

        public int GetNItems()
        {
            return numberOfItems;
        }

        public double GetTotal()
        {
            return total;
        }

    }
}