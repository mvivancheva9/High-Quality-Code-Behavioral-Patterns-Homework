using System;

namespace ChainOfResponsibilities
{
    internal class ShopManager : Employee
    {
        public override void HandleDiscount(int discount)
        {
            if (discount >= 10 && discount < 20)
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