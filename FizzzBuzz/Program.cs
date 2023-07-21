using System;
using System.Security.Cryptography.X509Certificates;

namespace Algorithms
{
    public class FizzBuzz
    {
        public static void RunFizzBuzz(int number)
        {
            for(int i = 1; i <= number; i++)
            {  }
                if (number % 3 == 0 && number % 5 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                }
                else if (number % 3 == 0)
                {
                    Console.WriteLine("fizz");
                }
                else if (number % 5 == 0)
                {
                    Console.WriteLine("buzz");
                }
                else
                {
                    Console.WriteLine(number);
                }
               
          
           
        }
        public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a Number");
            num=Convert.ToInt32( Console.ReadLine());
            RunFizzBuzz(num);
            Console.ReadLine();
        }


    }


}
   
