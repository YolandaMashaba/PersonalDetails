using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your surname");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());//Type Casting

            Console.WriteLine("\nDetails Entered: ");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Surname: " + surname);
            Console.WriteLine("Age: " + age);
        }
    }
}
