using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("Hannah", true)]
        [InlineData("wow",true)]
        [InlineData("house", false)]
        [InlineData("street car", false)]
        
        public void Test1(string word, bool expected)
        {
            //arrange
            var wordTest1 = new WordSmith(); 

            //act
            var actual = wordTest1.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);





        }
    }
}
