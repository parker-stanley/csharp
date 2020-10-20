using System;
namespace Technology
{
    public class Computer
    {
        public string Memory { get; set; }
        public string Processor { get; set; }
        public readonly string ModelNumber;

        public Computer(string memory, string processor)
        {
            Memory = memory;
            Processor = processor;
        }


    }
}
