using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingWeek7;

namespace UnitTests
{
    public class GetNonPrimeDivisorTests
    {
        Utility utility = new Utility();

        [Fact]
        public void TestGetNonPrimeDivisorsWithKnownOutcome()
        {
            int input = 24;

            var result = utility.GetNonPrimeDivisors(input);

            Assert.Equal(new List<int> { 4, 6, 8, 12 }, result);
        }

        [Fact]
        public void TestGetNonPrimeDivisorsWithPrimeInput()
        {
            int input = 19;

            var result = utility.GetNonPrimeDivisors(input);

            Assert.Empty(result);
        }

        [Fact]
        public void TestGetNonPrimeDivisorsWithInputOfOne()
        {
            int input = 1;

            var result = utility.GetNonPrimeDivisors(input);

            Assert.Empty(result);
        }


        [Theory]
        [InlineData(48)]
        [InlineData(72)]
        [InlineData(8)]
        [InlineData(50)]
        public void TestGetNonPrimeDivisorsNoPrimeEntries(int input)
        {
            var result = utility.GetNonPrimeDivisors(input);

            Assert.All(result, x => Assert.False(utility.IsPrime(x)));
        }

        [Theory]
        [InlineData(24)]
        [InlineData(72)]
        [InlineData(8)]
        [InlineData(20)]
        public void TestGetNonPrimeDivisorsResultsFound(int input)
        {
            var result = utility.GetNonPrimeDivisors(input);

            Assert.NotEmpty(result);
        }

        [Theory]
        [InlineData(48)]
        [InlineData(72)]
        [InlineData(8)]
        [InlineData(50)]
        public void TestGetNonPrimeDivisorsDivisorValidity(int input)
        {
            var result = utility.GetNonPrimeDivisors(input);

            Assert.All(result, x => Assert.True(input % x == 0));
        }
    }
}
