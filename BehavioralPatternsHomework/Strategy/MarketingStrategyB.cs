using System;

namespace Strategy
{
    internal class MarketingStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Marketing Strategy B - spend your budget wisely");
        }
    }
}