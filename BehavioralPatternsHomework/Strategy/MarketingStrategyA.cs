using System;

namespace Strategy
{
    internal class MarketingStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Marketing Strategy A - Go big or go home");
        }
    }
}