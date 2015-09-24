using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractShopBuilder c;

            c = new ConcreteBuilder();
            c.TemplateMethod();

            c = new ConcreteBuilder2();
            c.TemplateMethod();

            // Wait for user 
            Console.Read();
        }
    }
}
