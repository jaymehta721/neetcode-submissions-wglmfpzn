class Solution {
    public boolean hasDuplicate(int[] nums) 
    {
        HashSet<Integer> numsList = new HashSet<Integer>();
        for(int value : nums)
        {
            if(numsList.contains(value))
            {
                return true;
            }
            
            numsList.add(value);

        }
        return false;
    }
}