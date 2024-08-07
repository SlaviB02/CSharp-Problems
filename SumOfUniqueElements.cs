int SumOfUnique(int[] nums)
{
    Dictionary<int, int> result = new Dictionary<int, int>();   
    for(int i=0; i<nums.Length; i++)
    {
        if (!result.ContainsKey(nums[i]))
        {
            result.Add(nums[i],1);
        }
        else
        {
            result[nums[i]]++;
        }
    }
    int sum = 0;
    foreach(var item in result)
    {
        if(item.Value==1)
        {
            sum += item.Key;
        }
    }
    return sum;
}
int[] nums = [1, 2, 3, 2];
int sum=SumOfUnique(nums);
Console.WriteLine(sum);