using MilitaryEliteVersion2.Contracts;
using MilitaryEliteVersion2.Enums;
using System.Text;

namespace MilitaryEliteVersion2.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, Corp corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public Corp Corps { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString() + " ");
            sb.AppendLine($"{nameof(this.Corps)}: {this.Corps}");

            string output = sb.ToString().TrimEnd();

            return output;
        }

    }
}
