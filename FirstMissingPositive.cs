int FirstMissingPositive(int[] nums)
{
    for(int i=1;i<int.MaxValue;i++)
    {
        if(!nums.Contains(i))
        {
            return i;
        }
    }
    return -1;
}