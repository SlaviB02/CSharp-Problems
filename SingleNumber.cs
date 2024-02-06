int SingleNumber(int[] nums)
{
    Dictionary<int,int>numbers= new Dictionary<int,int>();
    for(int i = 0; i < nums.Length; i++)
    {
        if (numbers.ContainsKey(nums[i])) 
        {
            numbers[nums[i]]++;
        }
        else
        {
            numbers.Add(nums[i], 1);
        }
    }

    return numbers.First(x => x.Value == 1).Key;
}
var num=SingleNumber(new int[] { 2, 2, 1 });
Console.WriteLine(num);
