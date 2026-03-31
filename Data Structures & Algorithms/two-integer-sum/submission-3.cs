public class Solution 
{
    public int[] TwoSum(int[] nums, int target) 
    {
        Dictionary<int,int> dict = new Dictionary<int,int>();

        for(int i=0;i<nums.Length;i++)
        {
           int temp = target - nums[i];
           if(dict.ContainsKey(temp))
           {
              return new int[] {dict[temp],i};
           }

           dict.TryAdd(nums[i],i);
        }

        return null;
    }
}
