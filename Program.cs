// Encapsulation in c#
using System;
namespace Encapsulation
{
    public class Person
    {
        private string name;
        private int age;


        public void SetName(string pName)
        {
            this.name = pName;
        }
        public string GetName()
        {
            return this.name;
        }

        public void SetAge(int pAge)
        {
            if(pAge > 0 && pAge < 150)
            {
                this.age = pAge;
            }
            else
            {
                throw new Exception("Invalid Age");
            }
            
        }
        public int GetAge()
        {
            return this.age;
        }
        public void DisplayPersonDetails()
        {
            Console.WriteLine($"name = {name}, age = {age}");
        }

    }

    public class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.SetName("Akshay");
            p.SetAge(-1);
            p.DisplayPersonDetails();
        }
    }
    
}