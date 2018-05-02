using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace TestApp
{
    public class Util
    {
        public int Add(int i_a, int i_b)
        {
            return i_a + i_b;
        }


        [Fact]
        public void AddTestFact()
        {
            Assert.Equal(5, this.Add(2, 2));
        }

        [Theory]
        [InlineData(3, 5)]
        [InlineData(5, 2)]
        [InlineData(6, 1)]
        public void AddTestTheory(int value, int value2)
        {
            Assert.True(this.Add(value, value2) % 2 == 0);
        }
    }
}
