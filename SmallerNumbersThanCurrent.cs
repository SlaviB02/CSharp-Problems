int[] SmallerNumbersThanCurrent(int[] nums)
{
    int index = 0;
    int[]result= new int[nums.Length];
    while(true)
    {
        if(index>=nums.Length)
        {
            break;
        }
        int current= nums[index];
        int count = 0;
        for(int i=0;i<nums.Length;i++)
        {
            if (nums[index] >nums[i])
            {
                count++;
            }
        }
        result[index] = count;
        index++;
    }
    return result;
}
int[] nums = [8, 1, 2, 2, 3];
int[]res=SmallerNumbersThanCurrent(nums);
Console.WriteLine (String.Join (", ",res));
