using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    public class Dog
    {
        public string name;
        public string breed;
        public int age;
        public double weight;

        public void CanBark() 
        {
            Console.WriteLine("Bau - bau - bauuu - bau");
        }
         
        public int GrowUp()
        {
            return ++age; // parvo +1=> return
        }
    }
}
