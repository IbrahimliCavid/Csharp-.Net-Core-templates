using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9.Models
{
    public class Person
    {
        public string Name;

        public int Age;

        public void SetAge()
        {

        }

        public void Greet()
        {
            Console.WriteLine($"Hello! My name is: {Name}");
        }
    }


}
