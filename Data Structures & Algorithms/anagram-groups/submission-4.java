class Solution 
{
    public List<List<String>> groupAnagrams(String[] strs) 
    {
        HashMap<String,List<String>> hList = new HashMap<String,List<String>>();
        for(int i=0; i<strs.length;i++)
        {
            int[] array = new int[26];
            for(int j=0; j<strs[i].length();j++)
            {
                int temp = strs[i].charAt(j) - 'a';
                array[temp]++;
            }

             String result = Arrays.toString(array);
             if(hList.containsKey(result))
             {
                hList.get(result).add(strs[i]);
             }
             else
             {
                 hList.put(result, new ArrayList<>(Arrays.asList(strs[i])));
             }

        }

        return new ArrayList<>(hList.values());
    }
}
