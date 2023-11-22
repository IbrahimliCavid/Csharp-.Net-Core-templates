using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson_9_template.Models
{
    public class Dog : Animal
    {
        public string Voice;

        private string Color;
        protected string Loyality;
        internal string SomeProperty;
        public Dog(string name, string voice) : base(name)
        {
            Voice = voice;
            Color = "red";
        }

        public void Inf()
        {
            Console.WriteLine(Voice + " " + Name);
        }

        public new static void Move()
        {
            Console.WriteLine("Dog moving");
        }

        private void Rub()
        {
            Console.WriteLine(Color + " dog moving");
        }
    }

    public class Reks : Dog
    {
        public string Cins;
        public Reks(string name, string voice, string cins) : base(name, voice)
        {
            

           Cins = cins;

        }
    }

    

   


}
