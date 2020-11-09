using RazorPagesLessons.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace RazorPagesLessons.Services
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee()
                {
                    Id = 0, Name = "Marry", Email = "marry@example.com", PhotoPath = "avatar.png", Department = Dept.HR
                },
                new Employee()
                {
                    Id = 1, Name = "Harry", Email = "harry@example.com", PhotoPath = "avatar1.png", Department = Dept.IT
                },
                new Employee()
                {
                    Id = 2, Name = "Alex", Email = "alex@gmail.com", PhotoPath = "avatar2.png", Department = Dept.IT
                },
                new Employee()
                {
                    Id = 3, Name = "Max", Email = "max@mail.com", PhotoPath = "avatar3.png", Department = Dept.HR
                },
                new Employee()
                {
                    Id = 4, Name = "Bob", Email = "bob@example.com", PhotoPath = "avatar4.png", Department = Dept.Payroll
                },
                new Employee()
                {
                    Id = 5, Name = "Genry", Email = "genry@example.com", Department = Dept.HR
                }
            };
        }
        public IEnumerable<Employee> GetAllEmployees()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(x => x.Id == id);
        }
    }
}
