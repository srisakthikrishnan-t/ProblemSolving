//https://leetcode.com/problems/two-sum/

//Example 1:
//int[] nums = new int[] { 2, 7, 11, 15 };
//int target = 9;

//Example 2:
//int[] nums = new int[] { 3, 2, 4 };
//int target = 6;

//Example 3:
int[] nums = new int[] { 3, 3 };
int target = 6;


int[] output = null;

for (int i = 0; i < nums.Length; i++)
{
    for (int j = i + 1; j < nums.Length; j++)
    {
        if (nums[i] + nums[j] == target)
        {
            output = new int[] {i, j};
        }
    }
}

Console.ReadLine();


