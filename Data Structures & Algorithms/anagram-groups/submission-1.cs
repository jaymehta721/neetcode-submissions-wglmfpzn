public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        int[] sb = new int[26];
        Dictionary<string,List<string>> dictList = new  Dictionary<string,List<string>>();
        for(int i = 0; i < strs.Length; i++)
        {
               Array.Clear(sb);
               for(int j = 0; j < strs[i].Length; j++)
                {
                    int temp = strs[i][j] - 'a';
                    sb[temp]++;
                }
                
                string hashKey = string.Join('#',sb);
                if(dictList.ContainsKey(hashKey))
                {
                  dictList[hashKey].Add(strs[i]);
                }
                else
                {
                     dictList.TryAdd(hashKey,new List<string>{strs[i]});
                }
        }


        return dictList.Values.ToList();
    }
}
