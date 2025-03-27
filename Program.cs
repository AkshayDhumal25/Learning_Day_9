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
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int n = 123;
//            int result = 0;
//            while (n > 0)
//            {
//                int remainder = n % 10;
//                result = result * 10 + remainder;
//                n = n / 10;
//            }
//            Console.WriteLine(result);
//        }
//    }
//}


// 2. Swap Values without using any variable a=10, b=12.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int a = 10;
//            int b = 12;

//            a = a + b;//10+12 = 22
//            b = a - b; //22-12 = 10
//            a = a - b; //22 -10 =12

//            Console.WriteLine($"A : {a} and B : {b}");
//        }
//    }
//}


// 3. Logic for anagram program with its time complexity. (for large strings).
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str1 = "listen";
//            string str2 = "silent";

//            int[] charCount = new int[256];

//            if (str1.Length != str2.Length)
//            {
//                Console.WriteLine("Invalid input.");
//                return;
//            }
//            for (int i = 0; i < str1.Length; i++)
//            {
//                charCount[str1[i]]++;
//                charCount[str2[i]]--;
//            }
//            bool isAnagram = true;
//            for (int i = 0; i < 256; i++)
//            {
//                if (charCount[i] != 0)
//                {
//                    isAnagram = false;
//                    break;
//                }
//            }
//            if (isAnagram)
//            {
//                Console.WriteLine("Anagram");
//            }
//            else
//            {
//                Console.WriteLine("Not Anagram");
//            }
//        }
//    }
//}


// 4. Find the reverse of the string.
//using System;
//using System.Linq;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = "Akshay";
//            string reversed = "";
//            for (int i = str.Length - 1; i >= 0; i--)
//            {
//                reversed += str[i];
//            }
//            Console.WriteLine($"Reversed String : {reversed} ");

//        }
//    }
//}

// 5. WAP to find missing elements from the array?
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            int[] array = new int[] { 1, 2, 3, 5, 6 };
//            int n = array.Length + 1;
//            int ExpectedSum = n * (n + 1) / 2;
//            int currentSum = 0;
//            for (int i = 0; i < array.Length; i++)
//            {
//                currentSum += array[i];
//            }
//            Console.WriteLine(ExpectedSum - currentSum);
//        }
//    }
//}

// 6. WAP to find the given string is Palindrome or not.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            string str = "abba";
//            if (isPalindrome(str))
//            {
//                Console.WriteLine("Palindrome");
//            }
//            else
//            {
//                Console.WriteLine("Not Palindrome");
//            }

//        }

//        static bool isPalindrome(string str)
//        {
//            int left = 0;
//            int right = str.Length - 1;
//            while (left < right)
//            {
//                if (str[left] != str[right])
//                {
//                    return false;
//                }
//                left++;
//                right--;
//            }
//            return true;
//        }
//    }
//}


// 7. WAP to print Fibonacci series with recursion.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number to get the Fibonacci Series : ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine(fibonacci(i));
//            }

//        }
//        public static int fibonacci(int n)
//        {
//            if (n <= 1) return n;

//            return fibonacci(n - 1) + fibonacci(n - 2);
//        }

//    }
//}

// 8. WAP to print Fibonacci series without recursion.
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number to get the Fibonacci Series : ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            for (int i = 0; i < n; i++)
//            {
//                Console.WriteLine(Fibo(i));
//            }
//        }
//        public static int Fibo(int n)
//        {
//            if (n <= 0)
//            {
//                return n;
//            }
//            int a = 0;
//            int b = 1;
//            int c = 0;
//            for (int i = 2; i < n; i++)
//            {
//                c = a + b;
//                a = b;
//                b = c;
//            }
//            return b;
//        }
//    }
//}


// 11. Find prime numbers from 1 ....n
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number : ");
//            int n = Convert.ToInt32(Console.ReadLine());
//            for (int i = 2; i < n; i++)
//            {
//                if (isPrime(i))
//                {
//                    Console.WriteLine(i);
//                }
//            }
//        }

//        public static bool isPrime(int n)
//        {
//            for (int j = 2; j * j <= n; j++)
//            {
//                if (n % j == 0)
//                {
//                    return false;
//                }
//            }
//            return true;
//        }
//    }
//}




// ENums
//using System;
//namespace logicals
//{
//    class Program
//    {
//        public enum shippingMethod
//        { // Enum declared at the class level
//            RegularAirMail = 1,
//            RegisteredAirMail = 2,
//            Express = 3
//        }

//        public static void Main(string[] args)
//        {
//            var method = shippingMethod.Express;
//            Console.WriteLine(method);
//            Console.WriteLine((int)method); //Added to show integer value
//        }
//    }
//}


// Method Hiding 
using System;
namespace methodHiding
{

    class Base
    {
        public void Print()
        {
            Console.WriteLine("Class A");
        }
    }
    class Child : Base
    {
        public new void Print()
        {
            Console.WriteLine("Class B");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Base chld = new Child();
            chld.Print();
        }
    }
}