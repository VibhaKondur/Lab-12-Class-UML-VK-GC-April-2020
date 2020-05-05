using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_Class_UML_VK_GC_April_2020_5_6_2020
{
    class Person
    {

        //properties 
        public string Name { get; set; }
        public string Address { get; set; }

        //overloaded constructor
        public Person(string name, string address)
        {
            Name = name;
            Address = address;            
        }

        //default constructor
        public Person()
        {

        }

        //public method
        public override string ToString()
        {
            return $"Name = {Name}, Address = {Address},";
        }
    }
}
