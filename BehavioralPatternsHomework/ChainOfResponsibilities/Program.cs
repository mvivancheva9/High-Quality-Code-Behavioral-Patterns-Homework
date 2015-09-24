using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilities
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup Chain of Responsibility 
            Employee shopAssistant = new ShopAssistant();
            Employee shopManager = new ShopManager();
            Employee bossy = new TheBoss();
            shopAssistant.SetSuccessor(shopManager);
            shopManager.SetSuccessor(bossy);

            // Generate discounts and process them
            int[] discountsInPercents = { 2, 5, 14, 22, 18, 3, 27, 20 };

            foreach (int discount in discountsInPercents)
            {
                shopAssistant.HandleDiscount(discount);
            }

            // Wait for user 
            Console.Read();
        }
    }
}
