using System;
namespace Technology
{
    public class SmartPhone : Computer
    {
        public string ScreenSpecs;

        public SmartPhone(string memory, string processor, string screenSpecs) : base(memory, processor)
        {
            ScreenSpecs = screenSpecs;
        }
    }
}
