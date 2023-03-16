using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingWeek7;

namespace UnitTests
{
    public class HashStringTests
    {
        public Utility utility = new Utility();

        private int hashLength = 64;

        [Fact]
        public void TestHashStringWithKnownOutcomeA()
        {
            string input = "password";
            string expected = "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8";

            var result = utility.HashString(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestHashStringWithKnownOutcomeB()
        {
            string input = "Test123";
            string expected = "d9b5f58f0b38198293971865a14074f59eba3e82595becbe86ae51f1d9f1f65e";

            var result = utility.HashString(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestHashStringWithKnownOutcomeC()
        {
            string input = "test123";
            string expected = "ecd71870d1963316a97e3ac3408c9835ad8cf0f3c1bc703527c30265534f75ae";

            var result = utility.HashString(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("password")]
        [InlineData("Test123")]
        [InlineData("test123")]
        public void TestHashString_HashLengthTheory(string input)
        {
            var result = utility.HashString(input);

            Assert.Equal(result.Length, hashLength);
        }

        [Theory]
        [InlineData("password", "password")]
        [InlineData("Test123", "Test123")]
        [InlineData("test123", "test123")]
        public void TestHashString_HashConsistencyTheory(string input, string input2)
        {
            var result = utility.HashString(input);
            var result2 = utility.HashString(input2);

            Assert.Equal(result, result2);
        }

        [Theory]
        [InlineData("password", "Test123")]
        [InlineData("Test123", "test123")]
        [InlineData("test123", "password")]
        public void TestHashString_HashCollisionTheory(string input, string input2)
        {
            var result = utility.HashString(input);
            var result2 = utility.HashString(input2);

            Assert.NotEqual(result, result2);
        }

        
    }
}
