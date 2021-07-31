using System;

namespace StackTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //StackOverflow obj = new StackOverflow();
            //var result = obj.Calc(100000);
            //Console.WriteLine(result);
            FibonacciClass1 obj = new FibonacciClass1();
            var result = obj.Fibonacci(33);
            Console.WriteLine(result);
            Console.WriteLine("Press any key to continue..");
            Console.Read();
        }
    }
}
