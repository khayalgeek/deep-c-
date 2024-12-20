using System;
using ClassDefine.Entity;

namespace ClassDefine
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Vuqar";
            person.Surname = "Aliyev";
            person.Nationality = "Azerbaycanlı";

            Console.WriteLine($"Ad: {person.Name} \nSoyad: ${person.Surname} \nMilliyyət: {person.Nationality}");
        }
    }
}

