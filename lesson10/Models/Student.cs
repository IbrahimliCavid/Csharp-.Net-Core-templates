using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10.Models
{
    internal class Student : SchoolPerson
    {


        public override void GoToClasses()
        {
            Console.WriteLine($"I am {Name} {SurName}. I am student and I am going to class.");
        }

        public  void ShowAge() 
        {
            Console.WriteLine($"My age is {_age}");
        }
    }
}
