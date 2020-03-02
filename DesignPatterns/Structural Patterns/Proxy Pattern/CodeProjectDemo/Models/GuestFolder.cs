using CodeProjectDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeProjectDemo.Models
{
    internal class GuestFolder : IFolder
    {
        public void PerformOperations()
        {
            Console.WriteLine($"Performing user's operation on {this.GetType().Name}");
        }
    }
}
