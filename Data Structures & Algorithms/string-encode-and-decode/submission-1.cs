public class Solution {

    public string Encode(IList<string> strs) 
    {
        StringBuilder sb = new StringBuilder();

        for(int i=0;i<strs.Count;i++)
        {
            sb.Append(strs[i].Length).Append('#').Append(strs[i]);
        }

        return sb.ToString();
    }

    public List<string> Decode(string s) 
    {
      List<string> result = new List<string>();

      for(int i=0; i<s.Length;i++)
      {
         int j = i;
         while(s[j] != '#')
         {
            j++;
         }

         int length =  int.Parse(s.Substring(i,j-i));
         result.Add(s.Substring(j+1,length));
         i = j + length;

      }

      return result;
    }
}
