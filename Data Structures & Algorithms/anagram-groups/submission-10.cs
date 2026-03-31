public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        int[] sb = new int[26];
        Dictionary<string,List<string>> dictList = new  Dictionary<string,List<string>>();
        for(int i = 0; i < strs.Length; i++)
        {
               Array.Fill(sb, 0);
               for(int j = 0; j < strs[i].Length; j++)
                {
                    int temp = strs[i][j] - 'a';
                    sb[temp]++;
                }
                
                string hashKey = string.Join('#',sb);
              
                if (dictList.TryGetValue(hashKey, out var list))
                {

                  dictList[hashKey].Add(strs[i]);
                }
                else
                {
                   dictList[hashKey] = new List<string> { strs[i] };
                }
        }


        return dictList.Values.ToList();
    }
}
