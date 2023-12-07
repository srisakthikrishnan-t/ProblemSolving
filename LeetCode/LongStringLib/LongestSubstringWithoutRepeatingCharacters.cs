namespace LongStringLib
{
    public class LongestSubstringWithoutRepeatingCharacters
    {
        public int GetLongestSubString(string s)
        {
            var substring = string.Empty;
            var stringLen = 0;
            //var selectedSubString = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                if (substring.Contains(s[i]))
                {
                    int foundIndex = substring.IndexOf(s[i]);
                    //for (i = 0; i <= foundIndex; i++)
                    //{
                        substring = substring.Remove(0, foundIndex+1);
                    //}

                    substring += s[i];

                    //substring = substring. Substring( + 1, i - substring.IndexOf(s[i]) - 1);

                    //if (s[i - 1] == s[i])
                    //{
                    //    substring = s[i].ToString();
                    //}
                    //else
                    //{
                    //    substring = substring.Substring(substring.IndexOf(s[i])+1, i - substring.IndexOf(s[i])-1);
                    //    substring += s[i];
                    //}
                }
                else
                {
                    substring += s[i];
                }

                if (substring.Length > stringLen)
                {
                    stringLen = substring.Length;
                }
            }

            //if (substring.Length > selectedSubString.Length)
            //{
            //    selectedSubString = substring;
            //}

            return stringLen;
        }

    }
}