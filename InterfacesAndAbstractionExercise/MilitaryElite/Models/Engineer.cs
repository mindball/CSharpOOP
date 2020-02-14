using MilitaryElite.Contracs;
using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private readonly List<IRepair> _repears;
        public Engineer(string id, string firstName, string lastName, decimal salary, Corp corp) 
            : base(id, firstName, lastName, salary, corps)
        {
            this._repears = new List<IRepair>();
        }

        public IReadOnlyCollection<IRepair> Repairs => this._repears;

        public void AddRepair(IRepair repair)
        {
            this._repears.Add(repair);
        }
    }
}
