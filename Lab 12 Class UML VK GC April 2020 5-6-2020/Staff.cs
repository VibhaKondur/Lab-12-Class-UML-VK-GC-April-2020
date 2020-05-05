using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_12_Class_UML_VK_GC_April_2020_5_6_2020
{
    class Staff : Person
    {
        //properties
        public string School { get; set; }
        
        public double Pay { get; set; }


        //overloaded constructor
        public Staff (string name, string address, string school, double pay) : base(name, address)
        {
            School = school;
            Pay = pay;
        }

        //default constructor
        public Staff()
        {

        }

        //public method
        public override string ToString()
        {
            return $"Staff {base.ToString()}, School = {School}, Pay = {Pay:C}";
        }

    }
}
