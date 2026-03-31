public class Solution {
    public int LongestConsecutive(int[] nums) 
    {

        HashSet<int> set = new HashSet<int>(nums);
        int longestSequence = 0;

     
        foreach (var num in set)
        {
            if (!set.Contains(num - 1))
            {
                int currentNumber = num;
                int currentSequence = 1;

                while (set.Contains(currentNumber + 1))
                {
                    currentNumber++;
                    currentSequence++;
                }

                longestSequence = Math.Max(longestSequence, currentSequence);
            }
        }

       return longestSequence;    
        
    }
}
