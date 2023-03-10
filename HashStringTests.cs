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

        /*
        public string HashString(string input)
        {
            using (SHA256 hasher = SHA256.Create())
            {
                var bytes = hasher.ComputeHash(Encoding.UTF8.GetBytes(input));

                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                return builder.ToString();
            }
        }
         * 
         * 
         * 
         * 
         * 
         * 
         */



        [Fact]
        public void TestHashString()
        {
            string input = "";
            string expected = "";

            var result = utility.HashString(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestHashString2()
        {
            string input = "";
            string expected = "";

            var result = utility.HashString(input);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void TestConcatNames3()
        {
            string input = "";
            string expected = "";

            var result = utility.HashString(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData("password")]
        [InlineData("Test123")]
        [InlineData("test123")]
        public void TestConcatTheory(string input)
        {
            var result = utility.HashString(input);

            Assert.Equal(result, "");
        }

        [Theory]
        [InlineData("Jim", "Doe")]
        [InlineData("Ari", "Smith")]
        [InlineData("Jeff", "Jones")]
        public void TestConcatTheory2(string first, string last)
        {
            var result = utility.ConcatName(first, last);

            Assert.True(result == $"{first}, {last}");
        }

        [Theory]
        [InlineData("Jim", "Doe")]
        [InlineData("Ari", "Smith")]
        [InlineData("Jeff", "Jones")]
        public void TestConcatTheory3(string first, string last)
        {
            var result = utility.ConcatName(first, last);

            Assert.False(result == string.Empty);
        }
    }
}
