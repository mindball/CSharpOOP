using MilitaryEliteVersion2.Contracts;
using MilitaryEliteVersion2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryEliteVersion2.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private ICollection<IRepair> repairs;
        public Engineer(int id, string firstName, string lastName, decimal salary, Corp corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.repairs = new List<IRepair>();
        }

        public IReadOnlyCollection<IRepair> Repairs => (IReadOnlyCollection<IRepair>)this.repairs;

        public void AddRepairs(IRepair repair)
        {
            this.repairs.Add(repair);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"{nameof(this.Repairs)}:");
            foreach (var repair in this.Repairs)
            {
                sb.AppendLine(repair.ToString());
            }
            string  output = sb.ToString().TrimEnd();

            return output;
        }
    }
}
