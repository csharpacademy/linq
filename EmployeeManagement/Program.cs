using EmployeeManagement.Contracts;
using EmployeePersistance;
using System;
using System.Collections.Generic;

namespace EmployeeManagement
{
    class Program
    {
        // this is the list 
        private static List<IEmployee> employees = new List<IEmployee>();

        static void Main(string[] args)
        {
            var repo = new EmployeeRepository();

            foreach (var emp in repo.Employees())
            {
                Console.WriteLine($"{emp.Id} {emp.Name}");
            }
            Console.ReadLine();
        }
    }
}
