int SingleNonDuplicate(int[] nums)
{
    if(nums.Length==1)
    {
        return nums[0];
    }
    for(int i=0;i<nums.Length-1;i++)
    {
        if (nums[i] == nums[i+1])
        {
            i++;
        }
        else
        {
            return nums[i];
        }
        if(i==nums.Length-2)
        {
            return nums[i+1];
        }
    }
    return -1;
}
int[] nums = new int[] { 1,1,2};
Console.WriteLine(SingleNonDuplicate(nums));