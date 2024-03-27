IList<int> FindDuplicates(int[] nums)
{
    Dictionary<int,int>numbers=new Dictionary<int,int>(); 
    List<int>result=new List<int>();
    for(int i=0; i<nums.Length; i++)
    {
        if (!numbers.ContainsKey(nums[i]))
        {
            numbers.Add(nums[i],1);
        }
        else
        {
            result.Add(nums[i]);
        }
    }
    return result;
}