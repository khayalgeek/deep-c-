using System;
using System.Collections.Generic;
using DayOne.Models;

namespace DayOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new()
            {
                Id = Guid.NewGuid(),
                Name = "Vasif",
                Surname = "Agayev",
                Birthday = new DateTime(1997, 12, 25)
            };

            EmployeeContact employeeContact = new()
            {
                Id = Guid.NewGuid(),
                Phone = "+994515155097",
                Address = "M.Hadi 191",
                EmployeeId = employee.Id
            };

            EmployeeContact employeeContact2 = new()
            {
                Id = Guid.NewGuid(),
                Phone = "+994515155097",
                Address = "M.Hadi 191",
                EmployeeId = employee.Id
            };

            employee.EmployeeContacts = new List<EmployeeContact>
            {
                employeeContact,
                employeeContact2
            };

            Console.WriteLine(employee.Birthday.ToString("dd.MM.yyyy"));
            employee.GetEmployeeContacts();
        }
    }
}

