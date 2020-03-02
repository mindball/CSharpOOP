using CodeProjectDemo.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeProjectDemo.Models
{
    internal class UserFolder : IFolder
    {
        public void PerformOperations()
        {
            // access folder and perform various operations like copy or cut files
            Console.WriteLine($"Performing user's operation on {this.GetType().Name}");

        }
    }
   
}
