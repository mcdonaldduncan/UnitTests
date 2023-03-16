using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestingWeek7;

namespace UnitTests
{
    public class IsPrimeTests
    {
        Utility utility = new Utility();

        [Fact]
        public void IsNotPrimeFact()
        {
            int input = 15;

            var result = utility.IsPrime(input);

            Assert.False(result);
        }

        [Fact]
        public void IsPrimeFact()
        {
            int input = 13;


            var result = utility.IsPrime(input);
            Assert.True(result);
        }

        [Fact]
        public void IsOnePrime()
        {
            int input = 1;

            var result = utility.IsPrime(input);
            Assert.False(result);
        }


        [Theory]
        [InlineData(13)]
        [InlineData(3)]
        [InlineData(7)]
        [InlineData(2)]
        public void IsPrimeTheory(int input)
        {
            var result = utility.IsPrime(input);

            Assert.True(result);
        }

        [Theory]
        [InlineData(14)]
        [InlineData(1)]
        [InlineData(8)]
        [InlineData(20)]
        public void IsNotPrimeTheory(int input)
        {
            var result = utility.IsPrime(input);

            Assert.False(result);
        }

        [Theory]
        [InlineData(13)]
        [InlineData(3)]
        [InlineData(7)]
        [InlineData(5)]
        public void IsNotEven(int input)
        {
            var result = utility.IsPrime(input);

            Assert.Equal(result, input % 2 != 0);
        }
    }
}


