public class Solution
{
   public int[] TopKFrequent(int[] nums, int k)
    {
    
        Dictionary<int, int> dic = new Dictionary<int, int>();
        foreach (int t in nums)
        {
          dic[t] = dic.GetValueOrDefault(t) + 1;
        }


        List<int>[] buckets = new List<int>[nums.Length + 1];
        foreach (KeyValuePair<int, int> pair in dic)
        {
            int number = pair.Key;
            int count = pair.Value;

            buckets[count] ??= new List<int>();
            buckets[count].Add(number);
        }

              List<int> result = new List<int>();
        for(int i=buckets.Length - 1; i >= 0 && result.Count < k; i--)
        {
            if(buckets[i] != null)
            {
                result.AddRange(buckets[i]);
            }
        }

        return result.ToArray();
    }

}
