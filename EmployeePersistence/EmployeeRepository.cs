using EmployeePersistence;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace EmployeePersistence
{
    public class EmployeeRepository
    {
        public IEnumerable<Employee> Employees { get; }

        public EmployeeRepository()
        {
            using (var r = new StreamReader("empList.json"))
            {
                var json = r.ReadToEnd();
                Employees = JsonConvert.DeserializeObject<List<Employee>>(json);
            }
        }

    }

}
