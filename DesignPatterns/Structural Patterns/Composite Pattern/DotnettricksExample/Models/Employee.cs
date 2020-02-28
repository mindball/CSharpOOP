using DotnettricksExample.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DotnettricksExample.Models
{
    /// <summary>
    /// The 'Composite' class
    /// </summary>
    public class Employee : IEmployed, IEnumerable<IEmployed>
    {
        private List<IEmployed> subordinates = new List<IEmployed>();

        public int EmpID { get; set; }
        public string Name { get; set; }

        public void AddSubordinate(IEmployed subordinate)
        {
            this.subordinates.Add(subordinate);
        }

        public void RemoveSubordinate(IEmployed subordinate)
        {
            this.subordinates.Remove(subordinate);
        }

        public IEmployed GetSubordinate(int index)
        {
            return this.subordinates[index];
        }

        public IEnumerator<IEmployed> GetEnumerator()
        {
            foreach (IEmployed subordinate in this.subordinates)
            {
                yield return subordinate;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
