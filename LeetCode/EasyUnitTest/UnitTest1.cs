using _1662_CheckIfTwoStringArraysAreEquivalent;

namespace EasyUnitTest
{
    public class UnitTest
    {
        [Theory]
        [InlineData(new[]{ "ab", "c" }, new[] { "a", "bc" }, true)]
        [InlineData(new[] { "a", "cb" }, new[] { "ab", "c" }, false)]
        [InlineData(new[] { "abc", "d", "defg" }, new[] { "abcddefg" }, true)]
        public void CheckIfTwoStringArraysAreEquivalent_Test(string[] word1, string[] word2, bool expectedResult)
        {
            var result = new CheckIfTwoStringArraysAreEquivalent().ArrayStringsAreEqual(word1, word2);
            Assert.Equal(expectedResult,result);
        }

        [Theory]
        [InlineData(4, 10)]
        [InlineData(10,37)]
        [InlineData(20, 96)]
        public void CalculateMoneyInLeetcodeBank_Test(int days, int expectedSavings)
        {
            var result = new CalculateMoneyInLeetcodeBank.CalculateMoneyInLeetcodeBank().TotalMoney(days);
            Assert.Equal(expectedSavings, result);
        }
    }
}