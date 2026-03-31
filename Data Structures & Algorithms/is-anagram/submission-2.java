class Solution {
    public boolean isAnagram(String s, String t)
    {
        if(s == null || t == null)
        {
             return false;
        }   

        int sLen = s.length();
        int tLen = t.length();

        if(sLen != tLen)
        {
            return false;
        }

        int[] array = new int[26];
        for(int i = 0; i < sLen; i++)
        {
            array[s.charAt(i) - 'a']++;
            array[t.charAt(i) - 'a']--;
        }

        for(int i =0; i < array.length; i++)
        {
            if(array[i] != 0)
            {
                return false;
            }
        }

        return true;
    }
}
