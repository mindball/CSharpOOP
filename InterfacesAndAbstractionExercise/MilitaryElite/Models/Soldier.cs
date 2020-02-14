using MilitaryElite.Contracs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public abstract class Soldier : ISoldier
    {
        private string id;

        public Soldier(string id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public string Id
        {
            get => this.id;            
            //TODO define validy
            private set => this.id = value;
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

    }
}
