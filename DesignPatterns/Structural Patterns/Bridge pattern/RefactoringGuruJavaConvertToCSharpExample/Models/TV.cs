using RefactoringGuruJavaConvertToCSharpExample.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringGuruJavaConvertToCSharpExample.Models
{
    public class TV : IDevice
    {
        private bool isOn = false;
        private int volume = 30;
        private int channel = 1;

        public void Disable()
        {
            this.isOn = false;
        }

        public void Enable()
        {
            this.isOn = true;
        }

        public int GetChannel()
        {
            return this.channel;
        }

        public int GetVolume()
        {
            return this.volume;
        }

        public bool IsEnabled()
        {
            return this.isOn;
        }

        public void Mode()
        {
            Console.WriteLine("TV mode");

        }

        public void PrintStatus()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"| I'm {this.GetType().Name} set.");
            Console.WriteLine("| I'm " + (isOn ? "enabled" : "disabled"));
            Console.WriteLine("| Current volume is " + this.volume + "%");
            Console.WriteLine("| Current channel is " + this.channel);
            Console.WriteLine("------------------------------------\n");
        }

        public void SetChannel(int channel)
        {
            this.channel = channel;
        }

        public void SetVolume(int percent)
        {
            if (this.volume > 100)
                this.volume = 100;
            else if (this.volume < 0)
                this.volume = 0;
            else
                this.volume = percent;
        }
    }
}
