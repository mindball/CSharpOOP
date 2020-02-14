using MilitaryEliteVersion2.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryEliteVersion2.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        //private List<IPrivate> privates;
        private ICollection<IPrivate> privates;
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<IPrivate>();
        }

        //public IReadOnlyCollection<IPrivate> Privates
        //{
        //    get;
        //    set;
        //}

        public IReadOnlyCollection<IPrivate> Privates => (IReadOnlyCollection<IPrivate>)this.privates;

        public void AddPrivate(IPrivate privateSoldier)
        {
            this.privates.Add(privateSoldier);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString() + " ");
            sb.AppendLine($"{nameof(this.Privates)}: ");
            foreach (var privateSoldier in this.Privates)
            {
                sb.AppendLine("  " + privateSoldier.ToString());
            }

            string output = sb.ToString().TrimEnd(); ;
            return output;
        }
    }
}
