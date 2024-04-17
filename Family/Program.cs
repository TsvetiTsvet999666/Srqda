using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    Person chovek = new Person();
            //    chovek.Name = "Tsveti";
            //    chovek.Age = 15;
            //    chovek.IntroduceYourself();

            //    List<Person> Group2 = new List<Person>();
            //    string prompt = "YES";
            //    int index = 0;
            //    while (prompt == "YES")
            //    {
            //        Console.WriteLine($"Inter name on {index} human: ");
            //        Person person = new Person();

            //        Console.WriteLine($"Inter name on {index} human: ");
            //        person.Age = int.Parse( Console.ReadLine() );

            //        Group2.Add( person );
            //        Console.WriteLine("Do you want more? ");
            //        prompt = Console.ReadLine();
            //    }
            //    foreach (Person person in Group2)
            //    {
            //        Console.WriteLine(person.Name);
            //    }


            //Creat family
            Family myFamily = new Family();
            myFamily.FamilyName = "Todorovi";
            Console.WriteLine("Input count of family members = ");
            int countMembers = int.Parse(Console.ReadLine());

            for (int i = 0; i < countMembers; i++)
            {
                Console.WriteLine($"Inter {i + 1} person ");
                Person currentPerson = new Person();
                Console.Write("Input name: ");
                currentPerson.Name = Console.ReadLine();
                Console.Write("Input age: ");
                currentPerson.Age = int.Parse(Console.ReadLine());

                myFamily.Members.Add(currentPerson);
            }

            //Bublle sort Ascending
            for (int i = 0; i < myFamily.Members.Count; i++)
            {
                for (int j = 0; j < myFamily.Members.Count; j++)
                {
                    if (myFamily.Members[j].Age > myFamily.Members[j + 1].Age)
                    {
                        Person temp = myFamily.Members[j];
                        myFamily.Members[j] = myFamily.Members[j + 1];
                        myFamily.Members[j + 1] = temp;
                    }
                }
            }


            // PRINT ALL FAMILY
            myFamily.PrintAll();

             myFamily.PrintYoungest();
            myFamily.PrintOldest();
            int sum = myFamily.SumOfTheFamilies();
            Console.WriteLine($"The sum of all members age is {sum}.");
        }
        
    }
}
