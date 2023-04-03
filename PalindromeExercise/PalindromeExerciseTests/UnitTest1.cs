using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("mule", false)]
        [InlineData("huell", false)]
        [InlineData("fuel", false)]
        [InlineData("tacocat", true)]
        [InlineData("racecar", true)]
        public void PalindromeTester(string word, bool expected)
        {
            WordSmith tester = new WordSmith();

            var actual = tester.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
