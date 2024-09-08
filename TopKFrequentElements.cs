int[] TopKFrequent(int[] nums, int k)
{
    List<int>res= new List<int>();
    Dictionary<int,int>map = new Dictionary<int,int>();
    for (int i = 0; i < nums.Length; i++)
    {
        if(map.ContainsKey(nums[i]))
        {
        map[nums[i]]++;
           
        }
        else
        {
            map.Add(nums[i],1);
            
        }

    }
    int count = 0;
    foreach(var kvp in map.OrderByDescending(x=>x.Value))
    {
        res.Add(kvp.Key);
        count++;
        if (count == k)
        {
            break;
        }
    }
    return res.ToArray();
}
int[] nums = [1, 1, 1, 2, 2, 3];
int k = 2;
int[]res=TopKFrequent(nums,k);
Console.WriteLine(string.Join(",",res));