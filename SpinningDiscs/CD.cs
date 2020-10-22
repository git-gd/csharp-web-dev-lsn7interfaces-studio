using System;
namespace SpinningDiscs
{
    public class CD : Disc
    {
        public CD(int capacity, string discType, string data, string name, string contents) : base(capacity, discType, data, name, contents)
        {
        }

        public void PlaySong()
        {
            if (!IsSpinning)
            {
                SpinDisc();
                OnLoad();
            }
            Read();
            Console.WriteLine($"Now listening to {Contents}:");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(Data);
            Console.ResetColor();
        }
    }
}
