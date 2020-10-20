using System;
namespace Technology
{
    public class Laptop : Computer
    {
        public string ScreenSpecs;

        public Laptop(string memory, string processor, string screenSpecs) : base(memory, processor)
        {
            ScreenSpecs = screenSpecs;
        }
    }
}
