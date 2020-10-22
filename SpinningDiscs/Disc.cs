using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public abstract class Disc : IDisc
    {
        public bool IsSpinning { get; private set; } = false;
        public string Data, Name, Contents, DiscType;
        private int capacity;

        protected Disc(int capacity, string discType, string data, string name, string contents)
        {
            this.capacity = capacity;
            Data = data;
            Name = name;
            Contents = contents;
            DiscType = discType;
        }

        public string OnLoad()
        {
            return $"{DiscType} {capacity}MB {Name} '{Contents}'";
        }

        public string Read()
        {
            Console.WriteLine($"Reading {DiscType} data {Data} from {Name}");
            return Data;
        }

        public void SpinDisc()
        {
            IsSpinning = true;
            Console.WriteLine($"... spinning the disc up, please wait");
        }
    }
}
