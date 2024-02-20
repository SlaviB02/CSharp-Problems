int MissingNumber(int[] nums)
{
    for (int i = 0; i <= nums.Length; i++)
    {
        if (!nums.Contains(i))
        {
            return i;
        }
    }
    return 0;
}
int a = MissingNumber(new int[] { 3, 0, 1 });
Console.WriteLine(a);