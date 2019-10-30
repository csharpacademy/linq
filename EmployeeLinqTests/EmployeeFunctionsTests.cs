using EmployeePersistence;
using FluentAssertions;
using System.Collections.Generic;
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

            result.Should().Be(483);
        }

        [Fact]
        public void ListSurnamesOfEmployeesEarningOver9900()
        {
            var result = EmployeeFunctions.ListSurnamesOfEmployeesEarningOver9900(employees);

            var expectedResult = new List<string>
            {
                "Licari", "Andrew", "Noyes", "MacLucais", "Worham",
                "Grimsdith", "Blundan", "Gorstidge", "McAvinchey", "O'Deoran"
            };

            result.Should().BeEquivalentTo(expectedResult);
        }

        [Fact]
        public void FindEmployeesYoungerThan18AndEarningMoreThan1000()
        {
            var result = EmployeeFunctions.FindEmployeesYoungerThan18AndEarningLessThan1100(employees);

            var expectedResult = new List<Employee>
            {
                new Employee
                {
                    Age = 10,
                    Id = 188,
                    Name = "Bondy",
                    Surname = "McGloughlin",
                    Wage = 1054
                }
            };

            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}