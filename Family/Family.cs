using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family
{
    public class Family
    {
        public string familyName;

        public string FamilyName
        {
            get
            { 
                return familyName; 
            }
            set
            { 
                familyName = value; 
            }
        }

        private List<Person> members = new List<Person>();
        public List<Person> Members 
        { 
            get 
            { 
                return members; 
            } 
            set
            {
                members = value;
            }
        }

        public void PrintAll()
        {
            Console.WriteLine($"Family: {this.FamilyName}");
            foreach ( Person item in this.Members )
            {
                item.IntroduceYourself();
            }
        }

        public void PrintYoungest()
        {
            int minage = 0;
            Person younger = new Person();
            foreach (Person item in this.Members)
            {
                if (item.Age < minage)
                {
                    minage = item.Age;
                    younger = item;
                }
            }
            Console.WriteLine("The youngest human in family");
            younger.IntroduceYourself();
        }
        public void PrintOldest()
        {
            int minage = 0;
            Person younger = new Person();
            foreach (Person item in this.Members)
            {
                if (item.Age > minage)
                {
                    minage = item.Age;
                    younger = item;
                }
            }
            Console.WriteLine("The oldest human in family");
            younger.IntroduceYourself();
        }

        public int SumOfTheFamilies()
        {
            int sum = 0;
            foreach (Person item in this.Members)
            {

            }
        }
    }
}
