using System;
using Xunit;

namespace StackTest.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            FibonacciClass1 obj = new FibonacciClass1();

            Assert.Equal(5,obj.Fibonacci(5));
        }

        [Fact]
        public void Test2()
        {
            FibonacciClass1 obj = new FibonacciClass1();
            Assert.Equal(3524578, obj.Fibonacci(33));
        }


        [Fact]
        public void Test3()
        {
            FibonacciClass1 obj = new FibonacciClass1();
            Assert.Equal(3524578, obj.Fibonacci2(33));
        }
    }
}
