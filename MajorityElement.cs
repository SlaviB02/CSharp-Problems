int MajorityElement(int[] nums)
{
    Dictionary<int,int> result = new Dictionary<int,int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if (result.ContainsKey(nums[i]))
        {
            result[nums[i]]++;
        }
        else
        {
            result.Add(nums[i], 1);
        }
    }
    return result.OrderByDescending(x => x.Value).First().Key;
}
