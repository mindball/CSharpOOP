using RefactoringGuruJavaConvertToCSharpExample.Contracts;
using RefactoringGuruJavaConvertToCSharpExample.Models;
using System;

namespace RefactoringGuruJavaConvertToCSharpExample
{
    class StartUp
    {
        static void Main(string[] args)
        {
            TestDevice(new TV());
            TestDevice(new Radio());
        }

        public static void TestDevice(IDevice device)
        {
            Console.WriteLine("Test basic remote control");
            BasicRemote basicRemoteControl = new BasicRemote(device);
            basicRemoteControl.Power();           
            device.PrintStatus();

            Console.WriteLine("Tests with advanced remote.");
            AdvanceRemoteControl advancedRemote = new AdvanceRemoteControl(device);
            advancedRemote.Power();
            advancedRemote.Mute();
            device.PrintStatus();

            Console.WriteLine("Tests with smart remote.");
            SmartRemoteControl smartRemote = new SmartRemoteControl(device);
            smartRemote.Power();
            smartRemote.SpotifyButton();
            device.SetVolume(10);
            device.PrintStatus();
        }
    }
}
