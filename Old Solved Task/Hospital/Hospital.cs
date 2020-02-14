using System;
using System.Collections.Generic;
using System.Linq;

public class Hospital
{
    static Dictionary<string, List<Patient>> doctor = new Dictionary<string, List<Patient>>();
    static Dictionary<string, Department> dep = new Dictionary<string, Department>();
    public static void Main()
    {   
        //adding, checking even exist: department and doctor
        while (true)
        {
            string input = Console.ReadLine();
            if (input.Equals("Output"))
                break;

            String[] dataArray = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string department = dataArray[0];
            string doctorFirstName = dataArray[1];
            string doctorLastName = dataArray[2];
            string fullNameDoctor = doctorFirstName + " " + doctorLastName;
            string patienName = dataArray[3];

            if (doctor.ContainsKey(fullNameDoctor))
            {
                doctor[fullNameDoctor].Add(new Patient(patienName));
            }
            else
            {
                doctor.Add(fullNameDoctor, new List<Patient>() { new Patient(patienName) });
            }

            if (dep.ContainsKey(department))
            {
                dep[department].AddPatientToRoom(new Patient(patienName));
                dep[department].AddDoctorToDepartment(new Doctor(doctorFirstName, doctorLastName));
            }
            else
            {
                dep.Add(department, new Department(department, new Doctor(doctorFirstName, doctorLastName)));
                dep[department].AddPatientToRoom(new Patient(patienName));
            }
        }
        
        PrintInformation();        
    }

    private static void PrintInformation()
    {
        Department departmentName;
        while(true)
        {
            string[] command = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            if (command.Equals("End"))
                break;
            
            if (command.Length == 1)
            {
                if (dep.TryGetValue(command[0], out departmentName))
                {
                    var patientFromDeparment = departmentName.Rooms.Select(x => x.Patient).Where(x => x.Count > 0);
                    foreach (var item in patientFromDeparment)
                    {
                        var pat = item.Select(x => x);
                        foreach (var item2 in pat)
                        {
                            Console.WriteLine(item2.Name);
                        }
                    }
                }
            }
            else
            {
                int roomNumber;
                List<Patient> patientsOfDoctor;
                bool isNumberOfRoom = int.TryParse(command[1], out roomNumber);

                if (isNumberOfRoom)
                {
                    dep.TryGetValue(command[0], out departmentName);
                    var patientFromRoom = departmentName.Rooms.Where(x => x.ID == roomNumber)
                                                .SelectMany(x => x.Patient)
                                                .OrderBy(x => x.Name);                    

                    foreach (var item in patientFromRoom)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
                else
                {
                    string fullNameDoctor = command[0] + " " + command[1];
                    if (doctor.TryGetValue(fullNameDoctor, out patientsOfDoctor))
                    {
                        var listOfPatients = patientsOfDoctor.OrderBy(x => x.Name);
                        foreach (var item in listOfPatients)
                        {
                            Console.WriteLine(item.Name);
                        }
                    }
                }
            }
        }
        
    }
}

