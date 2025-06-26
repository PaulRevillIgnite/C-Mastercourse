using UnitTestHomework;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(0, true)]
        [InlineData(1, false)]
        [InlineData(2, false)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, false)]
        [InlineData(6, true)]
        [InlineData(7, false)]
        [InlineData(8, false)]
        [InlineData(9, true)]
        public void IsDivisibleBy3(int number, bool expected)
        {
            // Arrange
            Functions functions = new Functions();

            // Act
            bool actual = functions.DivisibleBy3(number);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}