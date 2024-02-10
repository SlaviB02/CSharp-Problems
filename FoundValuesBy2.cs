int FindFinalValue(int[] nums, int original)
{
    while(true)
    {
        if(nums.Contains(original))
        {
            original *= 2;
        }
        else
        {
            break;
        }
    }
    return original;
}
int[] nums = new int[] { 5, 3, 6, 1, 12 };
int original = 3;
Console.WriteLine(FindFinalValue(nums, original));