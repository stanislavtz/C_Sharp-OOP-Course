using Mankind.Models;
using System;

namespace Mankind.Core
{
    public class Engine
    {
        public void Run()
        {
            try
            {
                string[] studentInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Human student = new Student(studentInfo[0], studentInfo[1], studentInfo[2]);

                string[] workerInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Human worker = new Worker(workerInfo[0], workerInfo[1], decimal.Parse(workerInfo[2]), double.Parse(workerInfo[3]));

                Console.WriteLine(student);
                Console.WriteLine();
                Console.WriteLine(worker);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
