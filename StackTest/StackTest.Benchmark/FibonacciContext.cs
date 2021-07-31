using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace StackTest.Benchmark
{
    public class FibonacciContext
    {
        //Benchmark结果
        //当n=33时，Test1: 11075us, Test2: 8.442us, Test3: 8.350us。1000倍左右。
        //Test1大约执行了300万次加法，Test3执行了31次加法。10万倍。

        [Benchmark]
        public void Test1()
        {
            FibonacciClass1 obj = new FibonacciClass1();
            obj.Fibonacci(33);
        }

        [Benchmark]
        public void Test2()
        {
            FibonacciClass1 obj = new FibonacciClass1();
            obj.Fibonacci2(33);
        }

        [Benchmark]
        public void Test3()
        {
            FibonacciClass1 obj = new FibonacciClass1();
            obj.Fibonacci3(33);
        }
    }
}
