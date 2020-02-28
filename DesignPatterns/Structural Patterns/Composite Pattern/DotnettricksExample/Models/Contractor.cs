﻿using DotnettricksExample.Contracts;

namespace DotnettricksExample.Models
{
    /// <summary>
    /// The 'Leaf' class
    /// </summary>
    public class Contractor : IEmployed
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
    }
}
