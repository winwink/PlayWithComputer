using System;
using BenchmarkDotNet.Running;

namespace StackTest.Benchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            //var summary = BenchmarkRunner.Run<FibonacciContext>();
            BenchmarkRunner.Run<StackOverflowContext>();
            Console.ReadLine();
        }
    }
}
