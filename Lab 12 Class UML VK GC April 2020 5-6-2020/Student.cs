using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Lab_12_Class_UML_VK_GC_April_2020_5_6_2020
{
    class Student : Person
    {
        //properties 
        public string Program { get; set; }

        public int Year { get; set; }

        public double Fee { get; set; }


        //overloaded constructor
        public Student(string name, string address, string program, int year, double fee) : base(name, address)
        {
            Program = program;
            Year = year;
            Fee = fee;
        }

        //default constructor
        public Student()
        {

        }

        //public method
        public override string ToString()
        {
            return $"Student {base.ToString()}, Program = {Program}, Year = {Year}, Fee = {Fee:C}";
        }

    }
}
