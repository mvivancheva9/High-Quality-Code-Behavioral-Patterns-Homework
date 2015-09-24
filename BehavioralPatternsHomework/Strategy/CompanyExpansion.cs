namespace Strategy
{
    internal class CompanyExpansion
    {
        Strategy strategy;

        // Constructor 
        public CompanyExpansion(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void CompanyExpansionInterface()
        {
            strategy.AlgorithmInterface();
        }
    }
}