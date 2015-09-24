using System;

namespace TemplateMethod
{
    internal class ConcreteBuilder2 : AbstractShopBuilder
    {
        public override void PutLights()
        {
            Console.WriteLine("We take less, but we work slower");
        }

        public override void PutPaint()
        {
            Console.WriteLine("Cheap material - less investment");
        }
    }
}