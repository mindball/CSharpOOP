using MilitaryEliteVersion2.Contracts;
using MilitaryEliteVersion2.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryEliteVersion2.Models
{
    class Commando : SpecialisedSoldier, ICommando
    {
        private ICollection<IMission> newMission;
        public Commando(int id, string firstName, string lastName, decimal salary, Corp corps) 
            : base(id, firstName, lastName, salary, corps)
        {
            this.newMission = new List<IMission>();
        }

        public IReadOnlyCollection<IMission> Missions => (IReadOnlyCollection<IMission>) this.newMission;

        public void AddMission(IMission missionCodeName)
        {
            this.newMission.Add(missionCodeName);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"{nameof(this.Missions)}:");

            foreach (var mission in this.Missions)
            {
                sb.AppendLine(mission.ToString());
            }

            string output = sb.ToString().TrimEnd();

            return output;
        }
    }
}
