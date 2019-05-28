using MathPuzzles;
using Xunit;

namespace Tests
{
    public class Program1Test
    {
        [Fact]
        public void Test()
        {
            Assert.Equal(585, Program1.GetAnswer());
        }
    }
}