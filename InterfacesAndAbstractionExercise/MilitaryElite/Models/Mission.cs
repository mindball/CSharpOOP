using MilitaryElite.Contracs;
using MilitaryElite.Enums;
using MilitaryElite.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    class Mission : IMission
    {
        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            ParseState(state);
        }

        public string CodeName { get; private set; }
        public State State { get; private set; }

        public void CompleteMission()
        {
            if(this.State == State.Finished)
            {
                throw new InvalidMissionCompleteException();
            }

            this.State = State.Finished;
        }
        private void ParseState(string state)
        {
            State stateObj;

            bool isState = Enum.TryParse<State>(state, out stateObj);
            if(!isState)
            {
                throw new InvalidStateException();
            }

            this.State = stateObj;
        }
    }
}
