using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Hobby { get; set; }
        public string Skills { get; set; }
        public string Pet { get; set; }
    
        public Person() 
        {
            Age = 18;
            Name = "Vika";
            Hobby = "Stretching";
            Skills = "Basic programing skills";
            Pet = "Kitty Simona";
        }
    }
}
