using System;

namespace SpinningDiscs
{
    class Program
    {
        static void Main(string[] args)
        {
            CD audioDisc = new CD(750, "Audio", "♫ Hot For Teacher ♫ ...", "The Best Of The 80s Hair Bands", "1) Van Halen - Hot For Teacher");
            DVD movieDisc = new DVD(750, "Video", "(•_•) / ( •_•)>⌐□-□ / (⌐□_□)", "CSI: Miami - Season 1", "Episode 1: 	\"Golden Parachute\"");

            Console.OutputEncoding = System.Text.Encoding.UTF8;

            audioDisc.PlaySong();

            Console.WriteLine();

            movieDisc.PlayVideo();
        }
    }
}
