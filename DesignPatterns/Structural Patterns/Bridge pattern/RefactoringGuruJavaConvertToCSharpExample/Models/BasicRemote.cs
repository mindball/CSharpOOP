using RefactoringGuruJavaConvertToCSharpExample.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringGuruJavaConvertToCSharpExample.Models
{
    public class BasicRemote : IRemote
    {
        protected IDevice device;

        public BasicRemote(IDevice device)
        {
            this.device = device;
        }

        public virtual void ChannelDown()
        {
            Console.WriteLine("Remote: channel down");
            this.device.SetChannel(this.device.GetChannel() - 1);
        }

        public virtual void ChannelUp()
        {
            Console.WriteLine("Remote: channel up");
            this.device.SetChannel(this.device.GetChannel() + 1);
        }

        public virtual void Power()
        {
            Console.WriteLine("Remote: power toggle");
            if (this.device.IsEnabled())
                this.device.Disable();
            else
                this.device.Enable();
        }

        public virtual void VolumeDown()
        {
            Console.WriteLine("Remote: volume down");
            this.device.SetVolume(this.device.GetVolume() - 10);
        }

        public virtual void VolumeUp()
        {
            Console.WriteLine("Remote: channel down");
            this.device.SetVolume(this.device.GetVolume() - 10);
        }
    }
}
