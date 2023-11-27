using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lesson10.Models
{
    internal class Teacher : SchoolPerson
    {
        public string subject;

        public string Subject {  set {  subject = value; } }

        public void Explain()
        {
            Console.WriteLine($"Explanation begin on subject {subject}");
        }

        public override void GoToClasses()
        {
            Console.WriteLine($"I’m {Name} {SurName}, I am a teacher.");
        }
    }
}
