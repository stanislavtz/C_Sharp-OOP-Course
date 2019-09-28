using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Hospital
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
            Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();


            string inputLine = Console.ReadLine();

            while (inputLine != "Output")
            {
                string[] tokens = inputLine.Split();

                var departament = tokens[0];

                var doctorFirstName = tokens[1];
                var doctorLastName = tokens[2];
                var doctorFullName = doctorFirstName + doctorLastName;

                var pacpatientNameient = tokens[3];

                if (!doctors.ContainsKey(doctorFirstName + doctorLastName))
                {
                    doctors[doctorFullName] = new List<string>();
                }
                if (!departments.ContainsKey(departament))
                {
                    departments[departament] = new List<List<string>>();

                    for (int rooms = 0; rooms < 20; rooms++)
                    {
                        departments[departament].Add(new List<string>());
                    }
                }

                bool availableFreeBed = departments[departament].SelectMany(x => x).Count() < 60;

                if (availableFreeBed)
                {
                    int staq = 0;

                    doctors[doctorFullName].Add(pacpatientNameient);

                    for (int st = 0; st < departments[departament].Count; st++)
                    {
                        if (departments[departament][st].Count < 3)
                        {
                            staq = st;
                            break;
                        }
                    }
                    departments[departament][staq].Add(pacpatientNameient);
                }

                inputLine = Console.ReadLine();
            }

            inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                string[] args = inputLine.Split();

                if (args.Length == 1)
                {
                    Console.WriteLine(string.Join("\n", departments[args[0]].Where(x => x.Count > 0).SelectMany(x => x)));
                }
                else if (args.Length == 2 && int.TryParse(args[1], out int staq))
                {
                    Console.WriteLine(string.Join("\n", departments[args[0]][staq - 1].OrderBy(x => x)));
                }
                else
                {
                    Console.WriteLine(string.Join("\n", doctors[args[0] + args[1]].OrderBy(x => x)));
                }
                inputLine = Console.ReadLine();
            }
        }
    }
}
