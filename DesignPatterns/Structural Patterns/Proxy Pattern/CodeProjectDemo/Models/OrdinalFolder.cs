using CodeProjectDemo.Contracts;
using System;

namespace CodeProjectDemo.Models
{
    internal class OrdinalFolder : IFolder
    {
        public void PerformOperations()
        {
            Console.WriteLine($"Performing user's operation on {this.GetType().Name}");
        }
    }
}