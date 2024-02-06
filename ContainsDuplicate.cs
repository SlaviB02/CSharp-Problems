bool ContainsDuplicate(int[] nums)
{
    Dictionary<int,int> result = new Dictionary<int,int>();
    for(int i = 0; i < nums.Length; i++)
    {
        if (result.ContainsKey(nums[i]))
        {
            return true;
        }
        else
        {
            result.Add(nums[i],1);
        }
    }
    return false;
}
Console.WriteLine(ContainsDuplicate(new int[] { 1, 2, 3 }));