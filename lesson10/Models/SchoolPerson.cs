using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson10.Models
{
    internal class SchoolPerson
    {
        public string SchoolName;
        public string Name;
        public string SurName;
        public int _age;
        public int DateOfBrith;
        public int _currentClass;

        public int Age {
            get
            {
                return _age;
            }
            set 
            { 
                if (value > 6 && value < 50) 
                {
                    _age = value;
                }
                else
                {
                    throw new Exception("assign invalid number");
                }
            }
        }
        public int CurrentClass { get; set; }

        public void Great()
        {
            Console.WriteLine($"Hello! My name is: {Name} {SurName} ");
        }

        public virtual void GoToClasses()
        {
            Console.WriteLine("Inside Base GoToClasses method");
        }

       
    }
}
