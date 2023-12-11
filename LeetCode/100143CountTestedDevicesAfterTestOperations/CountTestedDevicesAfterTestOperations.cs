using System.Text.Json.Serialization;

namespace _100143CountTestedDevicesAfterTestOperations
{
    public class CountTestedDevicesAfterTestOperations
    {
        public int CountTestedDevices(int[] batteryPercentages)
        {
            for (int i = 0; i<batteryPercentages.Length-1; i++)
            {
                if (batteryPercentages[i] >0)
                {
                    for (int j = i+1; j < batteryPercentages.Length; j++)
                    {
                        if (batteryPercentages[j] > 0)
                        {
                            batteryPercentages[j] -= 1;
                        }
                    }
                }
            }

            int deviceCount = 0;

            foreach (var device in batteryPercentages)
            {
                if (device > 0)
                {
                    deviceCount++;
                }
            }

            return deviceCount;
        }
    }
}