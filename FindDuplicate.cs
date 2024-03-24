int FindDuplicate(int[] nums)
{
    List<int>numbers=new List<int>();
    for(int i = 0; i < nums.Length; i++)
    {
        if (!numbers.Contains(nums[i]))
        {
            numbers.Add(nums[i]);
        }
        else
        {
            return nums[i];
        }
    }
    return 0;
}