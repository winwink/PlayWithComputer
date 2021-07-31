using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTest
{
    public class FibonacciClass1
    {
        private long[] _result;
        public FibonacciClass1()
        {
            _result = new long[10000];
            for (int i = 0; i < 10000; i++)
            {
                _result[i] = -1;
            }
            _result[0] = 0;
            _result[1] = 1;
            _result[2] = 1;
        }

        public int clacCount1 = 0;
        public int clacCount2 = 0;
        public int maxStackSize = 0;
        public int maxStackSizeNValue = 0;

        /// <summary>
        /// 斐波那契数列
        /// 1，1，2，3，5，8，13，21，34，55
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public long Fibonacci(int n)
        {
            if (n == 1 || n == 2) return 1;
            clacCount1++;
            if (Environment.StackTrace.Length > maxStackSize)
            {
                maxStackSize = Environment.StackTrace.Length;
                maxStackSizeNValue = n;
                Console.WriteLine($"max:{maxStackSize}, nValue:{maxStackSizeNValue}");
            }
            if (clacCount1 % 1000 == 0)
            {
                Console.WriteLine($"n:{n}, calcCount:{clacCount1}, maxStackSize:{maxStackSize}, maxStackNValue:{maxStackSizeNValue}");
                Console.WriteLine(Environment.StackTrace.Length);
            }
            
            var x1 = Fibonacci(n - 1);
            var x2 = Fibonacci(n - 2);
            
            return x1 + x2;
        }

        public long Fibonacci2(int n)
        {
            var r = _result[n];
            if (r == -1)
            {
                var x1 = Fibonacci2(n - 1);
                var x2 = Fibonacci2(n - 2);
                _result[n] = x1 + x2;
                //clacCount2++;
                return x1 + x2;
            }
            else
            {
                return r;
            }
        }

        public long Fibonacci3(int n)
        {
            for (int i = 3; i <= n; i++)
            {
                _result[i] = _result[i - 1] + _result[i - 2];
            }

            return _result[n];
        }


        public void Show(int n)
        {
            Console.WriteLine("1: 1");
            Console.WriteLine("2: 1");
            for (int i = 3; i <= n; i++)
            {
                _result[i] = _result[i - 1] + _result[i - 2];
                Console.WriteLine(i+": " + _result[i]);
            }
        }
    }
}
