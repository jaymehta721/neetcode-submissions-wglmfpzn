public class Solution 
{
    public bool IsAnagram(string s, string t)
    {
        if(s == null || t == null) return false;

        int sLen = s.Length;
        int tLen = t.Length;

        if(sLen != tLen) return false;

        int[] list = new int[26];
        
        for(int i = 0; i < sLen; i++)
        {
            list[s[i] - 'a']++;
            list[t[i] - 'a']--;
        }

        for(int i = 0; i < list.Length; i++)
        {
            if(list[i] != 0)
            {
                return false;
            }
        }

        return true;

    }
}
