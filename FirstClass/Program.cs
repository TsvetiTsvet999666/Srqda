using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Program
    {
        static void Main()
        {
            Dog dog1 = new Dog();
            Dog dog2 = new Dog();

            dog1.name = "Tara";
            dog1.breed = "Mini Pincher";
            dog1.age = 6;
            dog1.weight = 4;
            
            dog1.CanBark();

            dog2.name = "Archi";
            dog2.breed = "Pumeran";
            dog2.age = 4;
            dog2.weight = 3.6; 
            
            dog2.CanBark();
        }
    }
}
