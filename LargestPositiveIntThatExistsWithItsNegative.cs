int FindMaxK(int[] nums)
{
    List<int>positive=nums.Where(x=>x>0).ToList();
    Console.WriteLine(String.Join(",",positive));
    List<int>negative=nums.Where(x=>x<0).ToList();
    positive=positive.OrderByDescending(x=>x).ToList();
    for (int i = 0; i < positive.Count; i++)
    {
        if (negative.Contains(-positive[i]))
        {
            return positive[i];
        }
    }
    return -1;
  
}
int[] nums = [-1, 2, -3, 3];
int res=FindMaxK(nums);
Console.WriteLine(res);