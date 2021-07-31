using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace StackTest.UnitTest
{
    public class StackOverflowTest
    {
        [Fact]
        public void CalcTest()
        {
            StackOverflow obj = new StackOverflow();
            Assert.Equal(15, obj.Calc(5));
        }

        [Fact]
        public void CalcTest2()
        {
            StackOverflow obj = new StackOverflow();
            var result = obj.Calc(100000);

        }
    }
}
