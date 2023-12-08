using System.Numerics;

namespace _1903LargestOddNumberInString
{
    public class LargestOddNumberInString
    {
        public string LargestOddNumber(string num)
        {
            var number = string.Empty;
            BigInteger bigOdd = 0;

            for (int i = num.Length; i>0; i--)
            {
                if (Convert.ToInt32(num[i - 1]) % 2 != 0)
                {
                    number = num.Substring(0, i);

                    var newInt = BigInteger.Parse(number);

                    if (!newInt.IsEven && newInt > bigOdd)
                    {
                        bigOdd = newInt;
                        break;
                    }
                }
            }

            return bigOdd > 0? bigOdd.ToString() : "" ;
        }
    }
}