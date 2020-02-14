using MilitaryElite.Contracs;
using MilitaryElite.Enums;
using MilitaryElite.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, Corp corp) 
            : base(id, firstName, lastName, salary)
        {
            ParseCorps(corp);
        }

        public Corp Corps { get; private set; }

        private void ParseCorps(Corp corp)        {
            
            bool isParseCorp = Enum.TryParse<Corp>(corps, out corp);

            if(!isParseCorp)
            {
                throw new InvalidCorpsException();
            }

            this.Corps = corp;
        }
    }
}
