namespace _1662_CheckIfTwoStringArraysAreEquivalent
{
    public class CheckIfTwoStringArraysAreEquivalent
    {
        public bool ArrayStringsAreEqual(string[] word1, string[] word2)
        {
            string stringOne = null;
            string stringTwo = null;

            foreach (var element in word1)
            {
                stringOne += element;
            }

            foreach (var element in word2)
            {
                stringTwo += element;
            }

            return stringOne == stringTwo;
        }
    }
}