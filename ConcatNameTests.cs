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
        public void TestConcatNamesWithKnownOutcomeA()
        {
            string first = "Jim";
            string last = "Doe";

            var result = utility.ConcatName(first, last);

            Assert.Equal("Jim, Doe", result);
        }

        [Fact]
        public void TestConcatNamesWithKnownOutcomeB()
        {
            string first = "Ari";
            string last = "Smith";

            var result = utility.ConcatName(first, last);

            Assert.Equal("Ari, Smith", result);
        }

        [Fact]
        public void TestConcatNamesWithKnownOutcomeC()
        {
            string first = "Jeff";
            string last = "Jones";

            var result = utility.ConcatName(first, last);

            Assert.Equal("Jeff, Jones", result);
        }

        [Theory]
        [InlineData("Jim", "Doe")]
        [InlineData("Ari", "Smith")]
        [InlineData("Jeff", "Jones")]
        public void TestConcatNames_StringConcat(string first, string last)
        {
            var result = utility.ConcatName(first, last);

            Assert.Equal(result, string.Concat(first, ", ", last));
        }

        [Theory]
        [InlineData("Jim", "Doe")]
        [InlineData("Ari", "Smith")]
        [InlineData("Jeff", "Jones")]
        public void TestConcatNames_StringInterpolation(string first, string last)
        {
            var result = utility.ConcatName(first, last);

            Assert.True(result == $"{first}, {last}");
        }

        [Theory]
        [InlineData("Jim", "Doe")]
        [InlineData("Ari", "Smith")]
        [InlineData("Jeff", "Jones")]
        public void TestConcatNames_StringNotEmpty(string first, string last)
        {
            var result = utility.ConcatName(first, last);

            Assert.False(result == string.Empty);
        }
    }
}
