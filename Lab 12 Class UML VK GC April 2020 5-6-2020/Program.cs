using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Lab_12_Class_UML_VK_GC_April_2020_5_6_2020
{
    class Program
    {
        public static List<Person> Person = new List<Person>
            {
                new Student("Mary", "45 Cherry Lane", "architecture", 1995, 45489.38),
                new Student("Bob", "68 Grapes Blvd", "civil engineering", 2020, 64239.95),
                new Student("Dan", "15 Orange Street", "English", 1985, 23389.8),
                new Staff("Stephan", "46 Candy Lane", "LTU", 159283.2),
                new Staff("Vibha", "29 Pineable Lane", "UofM", 30398.3)

            };

        static void Main(string[] args)
        {

            DisplayPersonList();

            Console.WriteLine();

            AddPerson();

            Console.WriteLine();

            DisplayPersonList();
        }

        public static void DisplayPersonList()
        {
            foreach (Person p in Person)
            {
                Console.WriteLine(p.ToString());
            }
        }
        public static void AddPerson()
        {
            Console.WriteLine("Would you like to add a student (s) or a Staff (t) to the list?");
            string input = Console.ReadLine().ToLower();

            try
            {
                if (input != "s" && input != "t")
                {
                    throw new FormatException("Invalid selection");
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                AddPerson();
            }
            if (input == "s")
            {
                Console.WriteLine($"Enter name:   ");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter address:   ");
                string address = Console.ReadLine();

                Console.WriteLine($"Enter program:   ");
                string program = Console.ReadLine();

                Console.WriteLine($"Enter year:   ");
                int year = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter fee:   ");
                double fee = double.Parse(Console.ReadLine());

                Person.Add(new Student(name, address, program, year, fee));
            }
            else if (input == "t")
            {
                Console.WriteLine($"Enter name:   ");
                string name = Console.ReadLine();

                Console.WriteLine($"Enter address:   ");
                string address = Console.ReadLine();

                Console.WriteLine($"Enter school:   ");
                string school = Console.ReadLine();

                Console.WriteLine($"Enter pay:   ");
                double pay = double.Parse(Console.ReadLine());

                Person.Add(new Staff(name, address, school, pay));
            }
            else
            {
                DisplayPersonList();
            }
        }
        


    }

}
