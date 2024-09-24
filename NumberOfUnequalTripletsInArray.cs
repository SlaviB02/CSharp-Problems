int UnequalTriplets(int[] nums)
{
    int count = 0;
    for(int i=0; i<nums.Length; i++)
    {
        for(int j=i+1; j<nums.Length; j++)
        {
            for(int z=j+1; z<nums.Length; z++)
            {
                if (nums[i]!=nums[j] && nums[i] != nums[z] && nums[j] != nums[z])
                {
                    count++;
                }
            }
        }
    }
    return count;
}
int[] nums = [4, 4, 2, 4, 3];
int res=UnequalTriplets(nums);
Console.WriteLine(res);