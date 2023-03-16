using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingWeek7;

namespace UnitTests
{
    public class GetDivisionFloorTests
    {
        Utility utility = new Utility();

        [Fact]
        public void TestGetDivisionFloorWithNumeratorA()
        {
            int a = 15;
            int b = 10;

            var result = utility.GetDivisionFloor(a, b);

            Assert.Equal(result, Math.Floor((double)a / b));
        }

        [Fact]
        public void TestGetDivisionFloorWithNumeratorB()
        {
            int a = 5;
            int b = 50;

            var result = utility.GetDivisionFloor(a, b);

            Assert.Equal(result, Math.Floor((double)b / a));
        }

        [Fact]
        public void TestGetDivisionFloorIsZeroSafe()
        {
            int a = 0;
            int b = 0;

            var result = utility.GetDivisionFloor(a, b);

            Assert.True(result == 0);
        }


        [Theory]
        [InlineData(13, 0)]
        [InlineData(0, 3)]
        [InlineData(7, 0)]
        [InlineData(0, 2)]
        public void TestGetDivisionFloorIsZeroSafeTheory(int a, int b)
        {
            var result = utility.GetDivisionFloor(a, b);

            Assert.True(result == 0);
        }

        [Theory]
        [InlineData(14, 14)]
        [InlineData(1, 1)]
        [InlineData(8, 8)]
        [InlineData(20, 20)]
        public void TestGetDivisionFloorHandleEqualInputs(int a, int b)
        {
            var result = utility.GetDivisionFloor(a, b);

            Assert.True(result == 1);
        }

        [Theory]
        [InlineData(13, 8)]
        [InlineData(3, 1)]
        [InlineData(7, 5)]
        [InlineData(5, 2)]
        public void TestGetDivisionFloorHandleCaseATheory(int a, int b)
        {
            var result = utility.GetDivisionFloor(a, b);

            Assert.Equal(result, Math.Floor((double)a / b));
        }

        [Theory]
        [InlineData(13, 48)]
        [InlineData(3, 7)]
        [InlineData(7, 32)]
        [InlineData(5, 25)]
        public void TestGetDivisionFloorHandleCaseBTheory(int a, int b)
        {
            var result = utility.GetDivisionFloor(a, b);

            Assert.Equal(result, Math.Floor((double)b / a));
        }

    }
}
