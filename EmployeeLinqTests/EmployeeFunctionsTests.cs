using System;
using System.Collections;
using System.Collections.Generic;
using EmployeePersistence;
using Xunit;

namespace EmployeeLinqTests
{
    public class EmployeeFunctionsTests
    {
        private readonly IEnumerable<Employee> employees;

        public EmployeeFunctionsTests()
        {
            var employeeRepository = new EmployeeRepository();
            employees = employeeRepository.Employees;
        }

        [Fact]
        public void CountEmployeesOlderThan50()
        {
            var result = EmployeeFunctions.CountEmployeesOlderThan50(employees);

            Assert.Equal(483, result);
        }

        [Fact]
        public void ListSurnamesOfEmployeesEarningOver9900()
        {
            var result = EmployeeFunctions.ListSurnamesOfEmployeesEarningOver9900(employees);

            Assert.Equal(
                new List<string> {
                "Licari",
                "Andrew",
                "Noyes",
                "MacLucais",
                "Worham",
                "Grimsdith",
                "Blundan",
                "Gorstidge",
                "McAvinchey",
                "O'Deoran"
                }, result);
        }
    }
}
