using System;
using System.Collections.Generic;
using System.Text;
using WikiCommandPattern.Contracts;

namespace WikiCommandPattern.Models
{
    public class OnCommand : ICommand
    {
        private ISwitchable device;
        public OnCommand(ISwitchable device)
        {
            this.device = device;
        }
        public void Execute()
        {
            this.device.On();
        }
    }
}
