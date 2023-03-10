using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingWeek7;

namespace UnitTests
{
    public class ConcatNameTests
    {
        public Utility utility = new Utility();

        [Fact]
        public void TestConcatNames()
        {
            string first = "Jim";
            string last = "Doe";
            var result = utility.ConcatName(first, last);

            Assert.Equal("Jim, Doe", result);
        }

        [Fact]
        public void TestConcatNames2()
        {
            string first = "Ari";
            string last = "Smith";

            var result = utility.ConcatName(first, last);

            Assert.Equal("Ari, Smith", result);
        }

        [Fact]
        public void TestGetFloorRational()
        {
            double value = 5.7;
            var result = utility.GetFloor(value);

            Assert.Equal(5, result);
        }

        [Theory]
        [InlineData(5.8)]
        [InlineData(10.5)]
        [InlineData(3.2)]
        public void TestGetFloorNaturalNumber(double input)
        {
            var result = utility.GetFloor(input);

            Assert.True(result % 1 == 0);
        }

        [Theory]
        [InlineData(5.8)]
        [InlineData(10.5)]
        [InlineData(3.2)]
        public void TestGetFloorIsGetFloor(double input)
        {
            var result = utility.GetFloor(input);

            Assert.Equal(result, Math.Floor(input));
        }

        [Theory]
        [InlineData(5.8)]
        [InlineData(10.5)]
        [InlineData(3.2)]
        public void TestGetFloorIsGetFloor2(double input)
        {
            var result = utility.GetFloor(input);

            Assert.Equal(result, MathF.Floor((float)input));
        }
    }
}
