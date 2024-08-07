bool IsArraySpecial(int[] nums)
{
    for (int i = 0; i < nums.Length - 1; i++)
    {
        if (nums[i] % 2 == 0 && nums[i + 1] % 2 == 0 || nums[i] % 2 != 0 && nums[i + 1] % 2 != 0)
        {
            return false;
        }
    }
    return true;
}
int[] nums = [2, 1, 4];
bool res=IsArraySpecial(nums);
Console.WriteLine(res);