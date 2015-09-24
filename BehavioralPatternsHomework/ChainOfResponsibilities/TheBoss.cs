using System;

namespace ChainOfResponsibilities
{
    internal class TheBoss : Employee
    {
        public override void HandleDiscount(int discount)
        {
            if (discount >= 20 && discount < 30)
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