using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagementWebApp.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> employeesList;

        public MockEmployeeRepository()
        {
            employeesList = new List<Employee>()
            {
                new Employee(){Id = 1, Name= "Mary", Department = Department.IT, Email="mary@test.dk"},
                new Employee(){Id = 2, Name= "John", Department = Department.HR, Email="john@test.dk"},
                new Employee(){Id = 3, Name= "Sam", Department = Department.HR, Email="sam@test.dk"},
                new Employee(){Id = 4, Name= "Mary", Department = Department.IT, Email="mary2@test.dk"},
                new Employee(){Id = 5, Name= "Ben", Department = Department.AR, Email="ben@test.dk"}
            };
        }

        public Employee Add(Employee employee)
        {
            employee.Id = employeesList.Max(e => e.Id) + 1;
            employeesList.Add(employee);
            return employee;

        }

        public Employee GetEmployee(int id)
        {
            return employeesList.FirstOrDefault(e => e.Id == id);
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            return employeesList;
        }

        public Employee Update(Employee employee)
        {
            if (employee != null)
            {
                Employee employeeUpdate = employeesList.FirstOrDefault(e => e.Id == employee.Id);
                if (employeeUpdate != null)
                {
                    employeeUpdate.Name = employee.Name;
                    employeeUpdate.Email = employee.Email;
                    employeeUpdate.Department = employee.Department;
                    employeeUpdate.PhotoPath = employee.PhotoPath;
                }
                return employeeUpdate;
            }

            return employee;

        }

        public Employee Delete(int id)
        {
            Employee employee = employeesList.FirstOrDefault(e => e.Id == id);
            if (employee != null)
            {
                employeesList.Remove(employee);
            }
            return employee;


        }
    }
}
