using MilitaryEliteVersion2.Contracts;
using System.Text;

namespace MilitaryEliteVersion2.Models
{
    public class Spy : Soldier, ISpy
    {
        public Spy(int id, string firstName, string lastName, int codeNumber)
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNumber;
        }

        public int CodeNumber { get; }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine(base.ToString());
            output.AppendLine($"Code Number: {this.CodeNumber}");

            return output.ToString().TrimEnd(); 
        }
    }
}
