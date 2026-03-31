class Solution {
    public int[] twoSum(int[] nums, int target)
    {
        HashMap<Integer,Integer> map = new HashMap<Integer,Integer>();
        for(int i=0; i<nums.length;i++)
        {
            int total  = target - nums[i];
            if(map.containsKey(total))
            {
                return map.get(total) > i ? new int[] {i, map.get(total)} : new int[] {map.get(total),i};
            }

            map.put(nums[i],i);
        }   

        return null;
    }
}
