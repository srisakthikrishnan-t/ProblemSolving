using _100155DoubleModularExponentiation;
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

        int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

        [Fact]
        //[InlineData(new[,] { { 2, 3, 3, 10 }, { 3, 3, 3, 1 }, { 6, 1, 1, 4 } }, 3)]
        public void CountTestedDevicesAfterTestOperations_Test()
        {
            int[,] numbers = {{2, 3, 3, 10}, {3, 3, 3, 1}, {6, 1, 1, 4}};
            var target = 2;

            //int[,] numbers = {{ 39, 3, 1000, 1000 }};
            //var target = 7;

            var result = new DoubleModularExponentiation().GetGoodIndices(numbers, target);
            Assert.NotEmpty(result);
        }
    }
}