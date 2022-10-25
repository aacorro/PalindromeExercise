using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("house", false)]
        [InlineData("nun", true)]
        [InlineData("Nun", true)]
        [InlineData("madam", true)]
        [InlineData("project", false)]
        [InlineData("level", true)]
        [InlineData("", false)]
        
        public void PalindromeTester(string word, bool expected)
        {
            //Arrange
            var input = new WordSmith();

            //Act
            bool actual = input.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
