int[] RunningSum(int[] nums)
{
    int sum = 0;
    int[]res = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        sum += nums[i];
res[i] = sum;
    }
    return res;
}
int[] nums = [1, 2, 3, 4];
int[]res=RunningSum(nums);
Console.WriteLine(String.Join(",", res));