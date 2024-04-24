int MaxProduct(int[] nums)
{
    List<int>numbers=nums.ToList();
    int max1 = numbers.Max();
    int index=numbers.IndexOf(max1);
    numbers.RemoveAt(index);
    int max2=numbers.Max();
    return (max1-1)*(max2-1);
}
int[] nums = [3, 4, 5, 2];
int max=MaxProduct(nums);
Console.WriteLine(max);