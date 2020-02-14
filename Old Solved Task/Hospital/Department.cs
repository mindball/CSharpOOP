using System;
using System.Collections.Generic;
using System.Linq;

class Department
{
    private const int CAPACITY = 20;
    public Department(string name, Doctor doctors)
    {
        this.Name = name;
        this.Doctor = new List<Doctor>();
        this.Rooms = new List<Room>();
        //MethodOne
        for (int i = 1; i <= CAPACITY; i++)
        {
            Rooms.Add(new Room(i));
        }
        //MethodTwo
        room = new Room[CAPACITY];
    }

    public string Name { get; set; }
    //methodOne
    public List<Room> Rooms { get; set; }
    //methodTwo
    public Room[] room { get; set; }
    public List<Doctor> Doctor { get; set; }

    public void AddPatientToRoom(Patient patient)
    {
        //MethodOne
        var room0 = this.Rooms.FirstOrDefault(r => r.Patient.Count < 3);
        if (room0 != null)
        {
            room0.AddPatient(patient);
        }

        //MethodTwo
        for (int i = 0; i < CAPACITY; i++)
        {
            if (this.room[i] != null)
            {
                if (this.room[i].Patient.Count < 3)
                {
                    this.room[i].AddPatient(patient);
                    break;
                }
                else
                    continue;
            }
            else
            {
                this.room[i] = new Room(i);
                room[i].AddPatient(patient);
                break;
            }
        }
    }

    public void AddDoctorToDepartment(Doctor doctor)
    {
        this.Doctor.Add(doctor);
    }
}

