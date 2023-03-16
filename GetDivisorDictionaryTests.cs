using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingWeek7;

namespace UnitTests
{
    public class GetDivisorDictionaryTests
    {
        Utility utility = new Utility();

        [Fact]
        public void TestGetDivisorDictionaryWithKnownOutcome()
        {
            int input = 30;

            var result = utility.GetDivisorDictionary(input);

            var expected = new Dictionary<int, int>
            {
                { 1, 6 },
                { 3, 10 },
                { 5, 15 }
            };

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestGetDivisorDictionaryWithPrimeInput()
        {
            int input = 17;

            var result = utility.GetDivisorDictionary(input);

            Assert.Empty(result);
        }

        [Fact]
        public void TestGetDivisorDictionaryWithInputOfOne()
        {
            int input = 1;

            var result = utility.GetDivisorDictionary(input);

            Assert.Empty(result);
        }

        [Theory]
        [InlineData(48)]
        [InlineData(72)]
        [InlineData(8)]
        [InlineData(50)]
        public void TestGetDivisorDictionaryNoEvenKeys(int input)
        {
            var result = utility.GetDivisorDictionary(input);

            Assert.All(result, x => Assert.True(x.Key % 2 != 0));
        }

        [Theory]
        [InlineData(24)]
        [InlineData(72)]
        [InlineData(8)]
        [InlineData(20)]
        public void TestGetDivisorDictionaryResultsFound(int input)
        {
            var result = utility.GetDivisorDictionary(input);

            Assert.NotEmpty(result);
        }

        [Theory]
        [InlineData(48)]
        [InlineData(72)]
        [InlineData(8)]
        [InlineData(50)]
        public void TestGetDivisorDictionaryDivisorValidity(int input)
        {
            var result = utility.GetDivisorDictionary(input);

            Assert.All(result, x => Assert.True(input % x.Value == 0));
        }
    }
}
