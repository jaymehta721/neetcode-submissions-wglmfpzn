class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        List = set()
        for i in nums:
            if(i in List):
                return True;
            List.add(i)    
        return False;
        