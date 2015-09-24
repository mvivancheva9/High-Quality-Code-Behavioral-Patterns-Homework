using System;

namespace TemplateMethod
{
    abstract class AbstractShopBuilder
    {
        public abstract void PutPaint();
        public abstract void PutLights();

        // The "Template method" 
        public void TemplateMethod()
        {
            PutPaint();
            PutLights();
            Console.WriteLine("");
        }
    }
}