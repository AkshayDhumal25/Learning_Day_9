// Encapsulation in c#
//using System;
//namespace Encapsulation
//{
//    public class Person
//    {
//        private string name;
//        private int age;


//        public void SetName(string pName)
//        {
//            this.name = pName;
//        }
//        public string GetName()
//        {
//            return this.name;
//        }

//        public void SetAge(int pAge)
//        {
//            if(pAge > 0 && pAge < 150)
//            {
//                this.age = pAge;
//            }
//            else
//            {
//                throw new Exception("Invalid Age");
//            }

//        }
//        public int GetAge()
//        {
//            return this.age;
//        }
//        public void DisplayPersonDetails()
//        {
//            Console.WriteLine($"name = {name}, age = {age}");
//        }

//    }

//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            Person p = new Person();
//            p.SetName("Akshay");
//            p.SetAge(-1);
//            p.DisplayPersonDetails();
//        }
//    }

//}


// Encapsulation using Properties
using System;
namespace EncapsulationWithProperties
{
    public class Person
    {
        private string name;
        private int age;
        private DateTime createdAt;


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set 
            {
                if(value  > 0 && value <= 150)
                {
                    this.age = value;
                }
                else
                {
                    throw new Exception("Invalid Age");
                }
            }
        }
        
        public DateTime CreatedAt
        {
            get { return createdAt; }
        }

        
        public Person()
        {
            this.createdAt = DateTime.Now;
        }

    }

    public class Program
    {
        static void Main()
        {
            Person person = new Person();
            person.Name = "Akshay";
            person.Age = 21;
            Console.WriteLine($"Name is {person.Name} and age is {person.Age}");
        }
    }
}