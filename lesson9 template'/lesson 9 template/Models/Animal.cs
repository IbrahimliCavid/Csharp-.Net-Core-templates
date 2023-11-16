using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace lesson_9_template.Models
{
    public class Animal
    {
        public string Name;
        public int Age;

        public Animal(string name)
        {
            Name = name;
        }
        public void Move()
        {
            Console.WriteLine("Animal Moving");
        }

        public void Eat()
        {
            Console.WriteLine("Animal eat");
            
        }
    }

   
}
