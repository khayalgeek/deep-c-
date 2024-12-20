using System;
using System.Collections;
using System.Collections.Generic;

namespace DayOne.Models
{
    public class Employee
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public ICollection<EmployeeContact> EmployeeContacts { get; set; } 

        public void GetEmployeeContacts()
        {
            foreach(var employeContact in EmployeeContacts)
            {
                Console.WriteLine(employeContact.Address, employeContact.Phone);
            }
        }
    }
}

