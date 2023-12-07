using LongStringLib;
using Xunit;

namespace UnitTest.Medium
{
    public class LongestSubstringWithoutRepeatingCharactersTest
    {
        [Theory]
        [InlineData("abcabcbb", 3)]
        [InlineData("bbbbb", 1)]
        [InlineData("pwwkew", 3)]
        [InlineData(" ", 1)]
        [InlineData("au", 2)]
        [InlineData("aab", 2)]
        [InlineData("dvdf", 3)]
        [InlineData("ckilbkd", 5)]
        public void Test1(string inputStr, int expectedResult)
        {
            LongestSubstringWithoutRepeatingCharacters x = new LongestSubstringWithoutRepeatingCharacters();

            var result = x.GetLongestSubString(inputStr);

            Assert.Equal(expectedResult, result);
        }
    }
}