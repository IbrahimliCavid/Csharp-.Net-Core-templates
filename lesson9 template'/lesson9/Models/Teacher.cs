using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9.Models
{
    public class Teacher : Person
    {

        public void Explain()
        {
            Console.WriteLine($"I am explaining");
        }
    }
}
