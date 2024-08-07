int DistinctAverages(int[] nums)
{
    List<int>numbers=nums.ToList();
    List<double>averages=new List<double>();
    while(numbers.Count > 0)
    {
        int max=numbers.Max();
        int min=numbers.Min();
        double average = (double)(max + min) / 2;
        if(!averages.Contains(average))
        {
            averages.Add(average);
        }
        numbers.Remove(max);
        numbers.Remove(min);
     
    }
    return averages.Count;
}
int[] nums = [9, 5, 7, 8, 7, 9, 8, 2, 0, 7];
int res=DistinctAverages(nums);
Console.WriteLine(res);