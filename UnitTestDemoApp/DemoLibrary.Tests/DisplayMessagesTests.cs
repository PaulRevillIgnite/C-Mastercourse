using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Arrange, Act, Assert
// expected and actual

// Red (test fails), Green (test passes), Refactor (change code)

namespace DemoLibrary.Tests
{
    public class DisplayMessagesTests
    {
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage()
        {
            //Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good morning Paul";

            //Act
            string actual = messages.Greeting("Paul", 2);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            //Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good afternoon Paul";

            //Act
            string actual = messages.Greeting("Paul", 14);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GreetingShouldReturnGoodEveningMessage()
        {
            //Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good evening Paul";

            //Act
            string actual = messages.Greeting("Paul", 23);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("Paul", 0, "Good morning Paul")]
        [InlineData("Paul", 1, "Good morning Paul")]
        [InlineData("Paul", 2, "Good morning Paul")]
        [InlineData("Paul", 3, "Good morning Paul")]
        [InlineData("Paul", 4, "Good morning Paul")]
        [InlineData("Paul", 5, "Good morning Paul")]
        [InlineData("Paul", 6, "Good morning Paul")]
        [InlineData("Paul", 7, "Good morning Paul")]
        [InlineData("Paul", 8, "Good morning Paul")]
        [InlineData("Paul", 9, "Good morning Paul")]
        [InlineData("Paul", 10, "Good morning Paul")]
        [InlineData("Paul", 11, "Good morning Paul")]
        [InlineData("Paul", 12, "Good afternoon Paul")]
        [InlineData("Paul", 13, "Good afternoon Paul")]
        [InlineData("Paul", 14, "Good afternoon Paul")]
        [InlineData("Paul", 15, "Good afternoon Paul")]
        [InlineData("Paul", 16, "Good afternoon Paul")]
        [InlineData("Paul", 17, "Good afternoon Paul")]
        [InlineData("Paul", 18, "Good evening Paul")]
        [InlineData("Paul", 19, "Good evening Paul")]
        [InlineData("Paul", 20, "Good evening Paul")]
        [InlineData("Paul", 21, "Good evening Paul")]
        [InlineData("Paul", 22, "Good evening Paul")]
        [InlineData("Paul", 23, "Good evening Paul")]
        public void GreetungShouldReturnExpectedValue(
            string firstName,
            int hourOfDay,
            string expected)
        {
            //Arrange
            DisplayMessages messages = new DisplayMessages();

            //Act
            string actual = messages.Greeting(firstName, hourOfDay);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
