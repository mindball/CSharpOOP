using MilitaryEliteVersion2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryEliteVersion2.Contracts
{
    public interface IMission
    {
        string CodeName { get; }

        State State { get; }

        void CompleteMission();

    }
}
