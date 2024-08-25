int FindPeakElement(int[] nums)
{
    if(nums.Length==1)
    {
        return 0;
    }
    for(int i=0;i<nums.Length;i++)
    {
        int number=nums[i];

        if(i==0)
        {
            if (number > nums[i+1])
            {
                return i;
            }
        }
        if(i==nums.Length-1)
        {
            if(number> nums[i-1])
            {
                return i;
            }
        }

        if(number> nums[i+1] && number > nums[i-1])
        {
            return i;
        }
    }
    return -1;
}
int[] nums = [1, 2, 3, 1];
int res=FindPeakElement(nums);
Console.WriteLine(res);