class Solution 
{

    
private static String keyFromCounts(int[] counts) {
    StringBuilder sb = new StringBuilder(26 * 3); // a rough capacity
    for (int c : counts) {
        sb.append('#').append(c);  // "#1#0#2..."
    }
    return sb.toString();
}

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

             String result = keyFromCounts(array);
             hList.computeIfAbsent(result, k -> new ArrayList<>()).add(strs[i]);

             
        }

        return new ArrayList<>(hList.values());
    }
}
