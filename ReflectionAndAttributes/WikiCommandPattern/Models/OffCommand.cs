using System;
using System.Collections.Generic;
using System.Text;
using WikiCommandPattern.Contracts;

namespace WikiCommandPattern.Models
{
    class OffCommand : ICommand
    {
        ISwitchable device;

        public OffCommand(ISwitchable device)
        {
            this.device = device;
        }
        public void Execute()
        {
            this.device.Off();
        }
    }
}
