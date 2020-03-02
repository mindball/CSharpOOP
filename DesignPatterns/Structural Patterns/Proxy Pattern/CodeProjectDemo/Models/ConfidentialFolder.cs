using CodeProjectDemo.Contracts;
using System;

namespace CodeProjectDemo.Models
{
    internal class ConfidentialFolder : IFolder
    {
        public void PerformOperations()
        {
            // access folder and perform various operations like copy or cut files
            Console.WriteLine($"Performing user's operation on {this.GetType().Name}");

        }
    }
}
