using System;
using System.Security.Cryptography;

namespace Delegate_try
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> square = num => num*num;
            Console.WriteLine($"This is the square of the number (3): {square(3)}");
            Console.WriteLine($"This is the square of the number (4): {square(4)}");
            Console.WriteLine($"This is the square of the number (5): {square(5)}");
            Console.WriteLine($"This is the square of the number (6): {square(6)}");
            
            
                       
            Console.ReadLine();
        }

       
    }
}