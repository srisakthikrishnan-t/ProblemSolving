namespace _867TransposeMatrix
{
    public class TransposeMatrix
    {
        public int[][] Transpose(int[][] matrix)
        {
            var transpose = new int[matrix.Length][];

            for (var i = 0; i < matrix.Length; i++)
            {
                var tempArray = new int[matrix.Length];

                for (var j = 0; j < matrix[i].Length; j++)
                {
                    tempArray[j] = matrix[j][i];
                }

                transpose[i] = tempArray;
            }
            return transpose;
        }
    }
}