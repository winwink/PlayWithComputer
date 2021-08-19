using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTest
{
   public class StackOverflow
    {
        /// <summary>
        /// StackOverflow，n=100000时， 在84068溢出。一个栈帧用了130B。默认最大栈大小1572864B
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public long Calc(long n)
        {
            if (n == 0) return 0;
            
            if (n % 100 == 0)
            {
                Console.WriteLine(n);
                Console.WriteLine(Environment.StackTrace.Length);
            }

            return n+ Calc(n - 1);
        }
      
    }
}
