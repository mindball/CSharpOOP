using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Contracs
{
    public interface ISoldier
    {
        string Id { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}
