public class Solution
{
    private HashSet<int> _numberList = new HashSet<int>();

    public bool hasDuplicate(int[] nums)
    {
        return nums.Any(num => !_numberList.Add(num));
    }
}