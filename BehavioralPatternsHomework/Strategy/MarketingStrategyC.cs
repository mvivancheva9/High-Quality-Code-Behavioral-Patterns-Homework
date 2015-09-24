using System;

namespace Strategy
{
    internal class MarketingStrategyC: Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Marketing Strategy C - pay as less as you can");
        }
    }
}