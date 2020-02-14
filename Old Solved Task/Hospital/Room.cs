using System;
using System.Collections.Generic;
using System.Linq;

class Room
{
    static int count = 0;
    public Room(int id)
    {
        this.ID = id;
        this.Patient = new List<Patient>();
        count++;        
    }
       
    public int ID { get; private set; }

    public static int RoomCount { get { return count; } }

    public List<Patient> Patient { get; set; }

    public void AddPatient(Patient patient)
    {
        if(Patient.Count <= 3)
        {
            this.Patient.Add(patient);
        }
        else
        {
            throw new ArgumentException();
        }
    }

    public List<String> GetPatient()
    {
        var a = Patient.OfType<string>().ToList();
        return a;

    }

    //public object this[int index]
    //{
    //    get
    //    {
    //        if (index >= 21 || index < 0)
    //        {
    //            throw new ArgumentOutOfRangeException(
    //                "Invalid index: " + index);
    //        }

        //        return room[index];
        //    }
        //    set
        //    {
        //        if (index >= 21 || index < 0)
        //        {
        //            throw new ArgumentOutOfRangeException(
        //                  "Invalid index: " + index);
        //        }
        //        room[index] = (Room)value;
        //    }
        //}
}

