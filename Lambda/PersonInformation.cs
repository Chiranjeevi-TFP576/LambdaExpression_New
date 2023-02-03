using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    public class PersonInformation
    {
        public string SSN;
        public string Name;
        public string Address;
        public int Age;
        public PersonInformation(string ssn, string name, string address, int age)//PARAMETERISED CONSTRUCTOR
        {
            SSN = ssn;
            Name = name;
            Address = address;
            Age = age;
        }
    }
}
