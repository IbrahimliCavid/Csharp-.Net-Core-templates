using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9.Models
{
    public class Student : Person
    {

        public void Study()
        {
            Console.WriteLine($"I am studying.");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is {Age} years old.");
        }
    }
}
