namespace _100155DoubleModularExponentiation
{
    public class DoubleModularExponentiation
    {
        public IList<int> GetGoodIndices(int[,] variables, int target)
        {
                IList<int> result = new List<int>();
                for (int i=0; i< variables.GetLength(0); i++)
                {
                    for (int j = 0; j < variables.GetLength(1); j++)
                    {
                        var step1 = Math.Pow(variables[i, 0], variables[i, 1]) % 10;
                        var step2 = Math.Pow(step1, variables[i, 2]);
                        var step3 = step2 % variables[i, 3];

                        if (step3 == target)
                        {
                            result.Add(i);
                            break;
                        }
                    }
                }
                return result;
        }

    }
}