using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace PetClinics.Core
{
    class ClinicsManager
    {
        private Dictionary<string, Pet> petCollection;
        private Dictionary<string, Clinic> clinicCollection;
        public ClinicsManager()
        {
            petCollection = new Dictionary<string, Pet>();
            clinicCollection = new Dictionary<string, Clinic>();
        }

        internal void CreatePet(string petName, int age, string typeOfPet)
        {
            Pet newPet = new Pet(petName, typeOfPet, age);
            petCollection.Add(petName, newPet);
        }

        internal void CreateClinic(string clinicName, int countRoom)
        {
            try
            {
                if(!clinicCollection.ContainsKey(clinicName))
                {
                    clinicCollection.Add(clinicName, new Clinic(clinicName, countRoom));
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        internal void AddPet(string petName, string clinicName)
        {
            if (petCollection.ContainsKey(petName) &&
                 clinicCollection.ContainsKey(clinicName))
            {
                clinicCollection[clinicName].AddPet(petCollection[petName]);
            }
        }

        internal void Release(string clinicName)
        {
            clinicCollection[clinicName].ReleasePet();
        }

        internal void HasEmptyRooms(string clinicName)
        {
            clinicCollection[clinicName].HasEmptyRooms();
        }

        internal void PrintAllRooms(string clinicName)
        {
            foreach (var item in clinicCollection[clinicName])
            {
                if (item is null)
                    Console.WriteLine("Room empty");
                else
                    Console.WriteLine(item);
            }
        }

        internal void PrintSpecifiedRoom(string clinicName, int roomNumber)
        {
            Clinic existClinit;
           if(clinicCollection.TryGetValue(clinicName, out existClinit))
            {
                Console.WriteLine(existClinit[roomNumber - 1]);
            }
        }
    }
}

