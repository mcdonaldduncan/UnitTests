using UnitTestingWeek7;

namespace UnitTests
{
    public class GetFloorTests
    {
        public Utility utility = new Utility();

        [Fact]
        public void TestGetFloorWithKnownValueA()
        {
            double value = 5;
            var result = utility.GetFloor(value);

            Assert.Equal(value, result);
        }

        [Fact]
        public void TestGetFloorWithKnownValueB()
        {
            double value = 10;
            var result = utility.GetFloor(value);

            Assert.Equal(value, result);
        }

        [Fact]
        public void TestGetFloorWithKnownValueC()
        {
            double value = 5.7;
            var result = utility.GetFloor(value);

            Assert.Equal(5, result);
        }

        [Theory]
        [InlineData(5.8)]
        [InlineData(10.5)]
        [InlineData(3.2)]
        public void TestGetFloorIsNaturalNumber(double input)
        {
            var result = utility.GetFloor(input);

            Assert.True(result % 1 == 0);
        }

        [Theory]
        [InlineData(5.8)]
        [InlineData(10.5)]
        [InlineData(3.2)]
        public void TestGetFloor_EqualMath_Floor(double input)
        {
            var result = utility.GetFloor(input);

            Assert.Equal(result, Math.Floor(input));
        }

        [Theory]
        [InlineData(5.8)]
        [InlineData(10.5)]
        [InlineData(3.2)]
        public void TestGetFloor_EqualMathF_Floor(double input)
        {
            var result = utility.GetFloor(input);

            Assert.Equal(result, MathF.Floor((float)input));
        }
    }
}