using System;
using System.Collections.Generic;
using System.Text;

namespace PetClinics
{
    public class Room
    {
        public Room(Pet pet)
        {
            this.Pet = pet;
        }

        public Pet Pet { get; set; }

        public override string ToString()
        {
            return this.Pet.ToString();
        }
    }
}
