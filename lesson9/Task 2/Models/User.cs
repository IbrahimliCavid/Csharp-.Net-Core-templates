using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace lesson9.Models
{
    public class User
    {
        public string Name;

        public User(string name)
        {
            Name = name;
        }


        public void GetName()
        {
            Console.WriteLine($"My name is: {Name}");
        }

        ~User()
        {
            Name = string.Empty;
        }
    }
}
