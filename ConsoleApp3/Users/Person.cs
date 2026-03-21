using ConsoleApp3.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Users
{
    public class Person
    {
        public string Name { get; set; } = default!;
        public string? Surname { get; set; }

        public EGender ECinsiyet { get; set; }

        public string Fax { get; set; }

        public Person(string fax)
        {
            Fax = fax;
            
        }
        public Person()
        {
         
        }
    }
}
