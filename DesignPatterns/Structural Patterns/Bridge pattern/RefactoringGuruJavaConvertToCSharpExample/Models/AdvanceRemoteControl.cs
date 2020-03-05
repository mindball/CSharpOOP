using System;
using System.Collections.Generic;
using System.Text;
using RefactoringGuruJavaConvertToCSharpExample.Contracts;

namespace RefactoringGuruJavaConvertToCSharpExample.Models
{
    public class AdvanceRemoteControl : BasicRemote
    {
        public AdvanceRemoteControl(IDevice device) 
            : base(device)
        {
        }

        public void Mute()
        {
            Console.WriteLine("Remote: mute");
            this.device.SetVolume(0);
        }
    }
}
