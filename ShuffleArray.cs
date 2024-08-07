int[] Shuffle(int[] nums, int n)
{
    List<int> result = new List<int>();
    int[] x = new int[n];
    int[] y = new int[n];
    for (int i = 0; i < n; i++)
    {
        x[i] = nums[i];
        y[i] = nums[n + i];
    }
   
    for (int i = 0; i < n; i++)
    {
        result.Add(x[i]);
        result.Add(y[i]);
    }
    return result.ToArray();
}

int[] nums = [2, 5, 1, 3, 4, 7];
int n = 3;
var res=Shuffle(nums, n);
Console.WriteLine(String.Join(",",res));
