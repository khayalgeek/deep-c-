using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Override
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp = new Emp();
            emp.Add(new Emp { FirstName = "Farid", LastName = "D" });
            emp.Add(new Emp { FirstName = "Arif", LastName = "B" });
            emp.Add(new Emp { FirstName = "Murad", LastName = "C" });
            emp.Add(new Emp { FirstName = "Ruslan", LastName = "S" });
            emp.GetEmps();
        }
    }

    
    public class Emp
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private List<Emp> _emps;

        public Emp() => _emps = new List<Emp>();

        public void Add(Emp emp)
        {
            _emps.Add(emp);
        }

        public void GetEmps()
        {
            foreach(Emp emp in _emps)
            {
                Console.WriteLine(emp);
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }


   
}

