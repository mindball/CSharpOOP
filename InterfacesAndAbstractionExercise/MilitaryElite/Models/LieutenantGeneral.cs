using MilitaryElite.Contracs;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private List<IPrivate> _privates;
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) 
            : base(id, firstName, lastName, salary)
        {
            this._privates = new List<IPrivate>(); 
        }

        public IReadOnlyCollection<IPrivate> Privates => this._privates;        

        public void AddPrivate(IPrivate privateSoldier)
        {
            this._privates.Add(privateSoldier);
        }
    }
}
