using EmployeePersistance;
using System;

namespace EmployeeManagement
{
    class Program
    {

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
