public class Solution 
{
    public int[] TwoSum(int[] nums, int target)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int expectedNumber = target - nums[i];

            if (dict.TryGetValue(expectedNumber, out var number))
            {
                return new int[] {number,i};
            }

            dict.Add(nums[i],i);
        }

        return null;
    }
}
