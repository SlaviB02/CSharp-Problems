int[] FrequencySort(int[] nums)
{
    Dictionary<int,int>res=new Dictionary<int, int>();

    for(int i=0;i<nums.Length;i++)
    {
        if(res.ContainsKey(nums[i]))
        {
            res[nums[i]]++;
        }
        else
        {
            res.Add(nums[i], 1);
        }
    }

    int[] result = new int[nums.Length];
    int index = 0;
    foreach (var kvp in res.OrderBy(x => x.Value).ThenByDescending(x => x.Key))
    {
        for(int i=0;i<kvp.Value;i++)
        {
            result[index] = kvp.Key;
            index++;
        }
        
    }
    return result;
}

int[] nums = [1, 1, 2, 2, 2, 3];

var res=FrequencySort(nums);

Console.WriteLine(String.Join(",", res));