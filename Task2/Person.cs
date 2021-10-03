using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int BirthdayYear { get; set; }

        public Person(string Name,string Surname,int Year)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.BirthdayYear = Year;
        }

        public void Find()
        {
            DateTime time = DateTime.Now;
            int year = time.Year;
            BirthdayYear = year - BirthdayYear;
            Console.WriteLine($"{Name} {Surname} {BirthdayYear}");
        }
    }
}
