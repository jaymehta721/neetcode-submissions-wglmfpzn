public class Solution
{
    public int[] TopKFrequent(int[] nums, int k) 
    {
        // Caculated Frequency 
        Dictionary<int,int> fMap = new Dictionary<int,int>();
        for(int i=0; i < nums.Length;i++)
        {
            if(!fMap.ContainsKey(nums[i]))
            {
                fMap.Add(nums[i],0);
            }

            fMap[nums[i]]++;
        }        

        // Init Bucket List
        List<int>[] bucket = new List<int>[nums.Length + 1];
        for(int i=0;i<bucket.Length;i++)
        {
            bucket[i] = new List<int>();
        }

        // Map the bucket value
        foreach(var kvp in fMap)
        {
            int frequency = kvp.Value;
            int number =  kvp.Key;

            bucket[frequency].Add(number);
        }

        // Make result for it 
        List<int> result = new List<int>();
        for(int i = bucket.Length-1; i >= 0 && result.Count < k; i--)
        {
            if(bucket[i].Count > 0)
            {
                result.AddRange(bucket[i]);
            }
        }

        return result.Take(k).ToArray();
    }
}
