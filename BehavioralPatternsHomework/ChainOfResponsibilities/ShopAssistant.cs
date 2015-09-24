using System;

namespace ChainOfResponsibilities
{
    internal class ShopAssistant : Employee
    {
        public override void HandleDiscount(int discount)
        {
            if (discount >= 0 && discount < 10)
            {
                Console.WriteLine("{0} handled discount {1}",
                  this.GetType().Name, discount);
            }
            else if (successor != null)
            {
                successor.HandleDiscount(discount);
            }
        }
    }
}