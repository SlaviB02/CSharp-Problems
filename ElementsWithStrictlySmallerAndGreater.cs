int CountElements(int[] nums)
{
    int count = 0;
    Array.Sort(nums);
    for(int i=1;i<nums.Length-1; i++)
    {
        if(nums[i] < nums.Max() && nums[i]>nums.Min())
        {
            count++;
        }
    }
    return count;
}
int[] nums = [11, 7, 2, 15];
int res=CountElements(nums);
Console.WriteLine(res);