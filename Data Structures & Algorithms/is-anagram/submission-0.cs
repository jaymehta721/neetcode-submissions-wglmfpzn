public class Solution {
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        int[] charArr = new int[26];

        for(int i = 0;i < s.Length; i++)
        {
            charArr[s[i] - 'a']++;
            charArr[t[i] - 'a']--;
        }

        for(int i = 0; i < charArr.Length; i++)
        {
            if(charArr[i] != 0)
            {
                return false;
            }
        }

        return true;

    }
}
