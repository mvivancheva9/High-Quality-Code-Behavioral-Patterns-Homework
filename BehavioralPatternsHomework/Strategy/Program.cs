using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            CompanyExpansion companyExpansion;

            // Three contexts following different strategies 
            companyExpansion = new CompanyExpansion(new MarketingStrategyA());
            companyExpansion.CompanyExpansionInterface();

            companyExpansion = new CompanyExpansion(new MarketingStrategyB());
            companyExpansion.CompanyExpansionInterface();

            companyExpansion = new CompanyExpansion(new MarketingStrategyC());
            companyExpansion.CompanyExpansionInterface();

            // Wait for user 
            Console.Read();
        }
    }
}
