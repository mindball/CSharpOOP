using DemoStatePattern.Models;
using System;

namespace DemoStatePattern
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player();

            Console.WriteLine(newPlayer.GetState());
            Console.WriteLine(newPlayer.IsPlaying());
            Console.WriteLine(newPlayer.NextTrack());
            Console.WriteLine(newPlayer.NextTrack());
            Console.WriteLine(newPlayer.NextTrack());
            Console.WriteLine(newPlayer.NextTrack());
            Console.WriteLine(newPlayer.PreviousTrack());

            Console.WriteLine();

            Console.WriteLine(newPlayer.GetState().OnLock());
            Console.WriteLine(newPlayer.NextTrack());
            Console.WriteLine(newPlayer.IsPlaying());

            Console.WriteLine();

            Console.WriteLine(newPlayer.GetState());
            Console.WriteLine(newPlayer.GetState().OnNext());
            Console.WriteLine(newPlayer.GetState().OnPlay());
            Console.WriteLine(newPlayer.PreviousTrack());
            Console.WriteLine(newPlayer.GetState());
            Console.WriteLine(newPlayer.GetState().OnPrevious());
            Console.WriteLine(newPlayer.GetState().OnPlay());
            Console.WriteLine(newPlayer.GetState());

            Console.WriteLine();
            Console.WriteLine(newPlayer.GetState().OnLock());
            Console.WriteLine(newPlayer.IsPlaying());
            Console.WriteLine(newPlayer.GetState().OnPlay());
            Console.WriteLine(newPlayer.IsPlaying());
        }
    }
}
