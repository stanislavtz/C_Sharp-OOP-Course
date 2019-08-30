using P04_Hospital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P04_Hospital.Core
{
    public class Engine 
    {
        private string inputLine;
        private string departmentName;
        private string doctorFullName;
        private string patientName;

        public void Run()
        {
            inputLine = Console.ReadLine();

            while (inputLine != "Output")
            {
                string[] inputArgs = inputLine.Split();

                departmentName = inputArgs[0];
                doctorFullName = inputArgs[1] + " " + inputArgs[2];
                patientName = inputArgs[3];

                var hospital = new Hospital();
                var department = new Department(departmentName);
                var doctor = new Doctor(doctorFullName);

                if (!hospital.Depatments.Any(x => x.Name == departmentName))
                {
                    hospital.Depatments.Add(department);
                }

                if (!hospital.Doctors.Any(x => x.FullName == doctorFullName))
                {
                    hospital.Doctors.Add(doctor);
                }



                inputLine = Console.ReadLine();
            }
        }
    }
}
