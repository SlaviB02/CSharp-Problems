int[] ArrayChange(int[] nums, int[][] operations)
{
    for(int i = 0; i<operations.Length;i++)
    {
        int number= operations[i][0];
        int replacement= operations[i][1];
        int index = Array.IndexOf(nums, number);
        nums[index] = replacement;
    }
    return nums;
}