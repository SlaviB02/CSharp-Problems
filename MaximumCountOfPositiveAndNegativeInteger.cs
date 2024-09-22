int MaximumCount(int[] nums)
{
    int PCount = 0;
    int NCount = 0;
    for(int i=0; i<nums.Length; i++)
    {
        if (nums[i] < 0)
        {
            NCount++;
        }
        else
        {
            PCount++;
        }
    }
    return Math.Max(PCount, NCount);
}
int[] nums = [-2, -1, -1, 1, 2, 3];
int res=MaximumCount(nums);
Console.WriteLine(res);