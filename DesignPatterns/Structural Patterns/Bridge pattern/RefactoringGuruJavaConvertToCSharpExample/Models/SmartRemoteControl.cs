using RefactoringGuruJavaConvertToCSharpExample.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringGuruJavaConvertToCSharpExample.Models
{
    public class SmartRemoteControl : BasicRemote
    {
        public SmartRemoteControl(IDevice device)
            : base(device)
        {
        }

        public void SpotifyButton()
        {
            Console.WriteLine("Change mode to smart and load Spotify!");
        }
    }
}
