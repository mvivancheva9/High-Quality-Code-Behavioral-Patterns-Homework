using System;

namespace TemplateMethod
{
    internal class ConcreteBuilder : AbstractShopBuilder
    {
        public override void PutPaint()
        {
            Console.WriteLine("We work fast - but it will cost you more");
        }
        public override void PutLights()
        {
            Console.WriteLine("We use high quality materials - bigger investment");
        }
    }
}