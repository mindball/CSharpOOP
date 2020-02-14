using MilitaryEliteVersion2.Contracts;
using MilitaryEliteVersion2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryEliteVersion2.Models
{
    class Mission : IMission
    {
        public Mission(string codeName, State state)
        {
            this.CodeName = codeName;
            this.State = state;
        }
        public string CodeName { get; set; }
        public State State { get; set; }

        public void CompleteMission()
        {
            if(!(this.State == State.Finished))
            {
                this.State = State.Finished;
            }
            
        }

        public override string ToString()
        {
            return $"  Code Name: {this.CodeName} {nameof(this.State)}: {this.State}";
        }
    }
}
