using System;
using System.Linq;
using P04_Hospital.Models;
using System.Collections.Generic;

namespace P04_Hospital.Core
{
    public class Engine
    {
        private Department department;
        private Doctror doctor;
        private Patient patient;

        private List<Doctror> doctors;
        private List<Department> departments;

        public Engine()
        {
            doctors = new List<Doctror>();
            departments = new List<Department>();
        }

        public void Run()
        {
            string inputLine = Console.ReadLine();

            while (inputLine != "Output")
            {
                string[] inputArgs = inputLine.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string departmentName = inputArgs[0];
                string doctorFullName = inputArgs[1] + " " + inputArgs[2];
                string patientName = inputArgs[3];

                try
                {
                    if (!departments.Any(d => d.Name == departmentName))
                    {
                        department = new Department(departmentName);
                        departments.Add(department);
                    }

                    if (!doctors.Any(d => d.Name == doctorFullName))
                    {
                        doctor = new Doctror(doctorFullName);
                        doctors.Add(doctor);
                    }

                    patient = new Patient(patientName);

                    var currentDepatment = departments.First(d => d.Name == departmentName);

                    foreach (var room in currentDepatment.Rooms)
                    {
                        if (room.PatientsInRoom.Count == 3)
                        {
                            continue;
                        }

                        room.AddPatient(patient);

                        break;
                    }

                    var currentDoctor = doctors.First(d => d.Name == doctorFullName);
                    currentDoctor.AddPatient(patient);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                inputLine = Console.ReadLine();
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    if (commandArgs.Length > 1)
                    {
                        bool isNumber = int.TryParse(commandArgs[1], out int roomNumber);

                        if (isNumber)
                        {
                            var currentDepartment = departments.First(d => d.Name == commandArgs[0]);

                            var currentRoom = currentDepartment.Rooms[roomNumber - 1];

                            var sortedPatients = currentRoom.PatientsInRoom.OrderBy(p => p.Name);

                            foreach (var patient in sortedPatients)
                            {
                                Console.WriteLine(patient.Name);
                            }
                        }
                        else
                        {
                            string dovtorName = commandArgs[0] + " " + commandArgs[1];

                            var currentDoctor = doctors.FirstOrDefault(d => d.Name == dovtorName);

                            foreach (var patient in currentDoctor.PatientList.OrderBy(p => p.Name))
                            {
                                Console.WriteLine(patient.Name);
                            }
                        }
                    }
                    else
                    {
                        var currentDepartment = departments.FirstOrDefault(d => d.Name == commandArgs[0]);

                        foreach (var room in currentDepartment.Rooms)
                        {
                            foreach (var patient in room.PatientsInRoom)
                            {
                                Console.WriteLine(patient.Name);
                            }
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                command = Console.ReadLine();
            }
        }
    }
}
