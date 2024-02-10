IList<int> FindDisappearedNumbers(int[] nums)
{
    IList<int> result = new List<int>();
       for(int i = 1; i <=nums.Length; i++)
        {
       if(!nums.Contains(i))
        {
            result.Add(i);
        }
        }
    return result;
    
}
int[] nums = new int[] { 4, 3, 2, 7, 8, 2, 3, 1 };
var list = FindDisappearedNumbers(nums);
Console.WriteLine(String.Join(",", list));