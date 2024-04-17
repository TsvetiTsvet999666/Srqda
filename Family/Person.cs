using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    public class Person
    {
        public string name;
        public int age;

        public string Name 
        { get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Age 
        {
            get 
            {
                return age;
            }
            set 
            { 
                if (value < 0 || value > 117)
                {
                    Console.WriteLine("Nevalidni godini za vazrast!");
                    this.age = 0; 
                }
                else
                {
                    this.age = value;
                }
                this.age = value; 
            }
        }

        public void IntroduceYourself ()
        {
            Console.WriteLine($"My name is {name} and I'm {age} years old.");
        }
    }
}
