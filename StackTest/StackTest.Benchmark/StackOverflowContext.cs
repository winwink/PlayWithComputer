using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace StackTest.Benchmark
{
    public class StackOverflowContext
    {
        [Benchmark]
        public void Test1()
        {
            StackOverflow obj = new StackOverflow();
            obj.Calc(100000);
        }

    }
}
