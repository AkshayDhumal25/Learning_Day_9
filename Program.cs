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
//using System;
//namespace EncapsulationWithProperties
//{
//    public class Person
//    {
//        private string name;
//        private int age;
//        private DateTime createdAt;


//        public string Name
//        {
//            get { return name; }
//            set { name = value; }
//        }

//        public int Age
//        {
//            get { return age; }
//            set 
//            {
//                if(value  > 0 && value <= 150)
//                {
//                    this.age = value;
//                }
//                else
//                {
//                    throw new Exception("Invalid Age");
//                }
//            }
//        }

//        public DateTime CreatedAt
//        {
//            get { return createdAt; }
//        }


//        public Person()
//        {
//            this.createdAt = DateTime.Now;
//        }

//    }

//    public class Program
//    {
//        static void Main()
//        {
//            Person person = new Person();
//            person.Name = "Akshay";
//            person.Age = 21;
//            Console.WriteLine($"Name is {person.Name} and age is {person.Age}");
//        }
//    }
//}

// Diamond Problem
//using System;
//namespace diamondProblem
//{

//    class A
//    {
//        public virtual void print()
//        {
//            Console.WriteLine("Class A");
//        }
//    }
//    class B : A
//    {

//    }

//    class C : A
//    {

//    }

//    class D : B, C // Here the class can't support for the multiple inheritance 
//    {

//    }
//    class Program
//    {
//        static void Main(string[] args)
//        {

//        }
//    }
//}


// Solution of Diamond Problem
//using System;
//using System.Runtime.InteropServices;
//namespace solutionOfDiamondProblem
//{
//    interface A
//    {
//        public void print()
//        {
//            Console.WriteLine("Interface A");
//        }
//    }

//    interface B : A { }
//    interface C : A { }

//    class D : B, C 
//    {
//        public void print()
//        {
//            Console.WriteLine("Class D");
//        }
//    }

//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            D d = new D();
//            d.print();
//        }
//    }
//}


// [12, 35, 1, 10, 34, 1, 35],
// Second Largest Number
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] arr = new int[] { 12, 35, 1, 10, 34, 1, 35 };
//            int large = 0;
//            int secLarge = 0;

//            for (int i = 0; i < arr.Length; i++)
//            {
//                if (arr[i] > large)
//                {
//                    secLarge = large;
//                    large = arr[i];
//                }
//                if (arr[i] < large && arr[i] > secLarge)
//                {
//                    secLarge = arr[i];
//                }
//            }
//            Console.WriteLine($"Second Large : {secLarge}");
//        }

//    }
//}


// 2. WAP to reverse an integer without converting it to a string, without using any built-in methods.
using System;
namespace logicals
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = 123;
            int result = 0;
            while (n > 0)
            {
                int remainder = n % 10;
                result = result * 10 + remainder;
                n = n / 10;
            }
            Console.WriteLine(result);
        }
    }
}