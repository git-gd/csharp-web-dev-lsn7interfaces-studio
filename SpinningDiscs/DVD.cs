using System;
namespace SpinningDiscs
{
    public class DVD : Disc
    {
        public DVD(int capacity, string discType, string data, string name, string contents) : base(capacity, discType, data, name, contents)
        {
        }
        public void PlayVideo()
        {
            if (!IsSpinning)
            {
                SpinDisc();
                OnLoad();
            }
            Read();
            Console.WriteLine($"Now viewing {Contents}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Data);
            Console.ResetColor();
        }
    }
}
