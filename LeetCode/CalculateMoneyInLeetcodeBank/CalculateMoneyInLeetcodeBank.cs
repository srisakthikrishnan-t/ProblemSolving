namespace CalculateMoneyInLeetcodeBank
{
    public class CalculateMoneyInLeetcodeBank
    {
        public int TotalMoney(int n)
        {
            var contribution = 1;
            var saving = 0;
            var j = 1;
            var weeklyHike = 1;

            for (int i = 1; i <= n; i++)
            {
                saving += contribution++;

                if (j++ == 7)
                {
                    contribution = ++weeklyHike;
                    j = 1;
                }
            }
            return saving;
        }
    }
}