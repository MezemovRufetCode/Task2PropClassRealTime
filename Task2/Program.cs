using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime time = DateTime.Now;
            int year = time.Year;

            Console.WriteLine("Add person's name:");
            string name = Console.ReadLine();
            Console.WriteLine("Add person's surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Add person year of birth:");
            int n = int.Parse(Console.ReadLine());
            if (n > year)
            {
                Console.WriteLine("It can not be!!!");
                return;
            }
            Person p1 = new Person(name,surname,n);
            p1.Find();
        }
    }
}
