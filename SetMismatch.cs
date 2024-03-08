int[] FindErrorNums(int[] nums)
{
    int[] result = new int[2];
    int start = 1;
    int end = nums.Length;
    int doubledElement = 0;
    int missingElement = 0;
    Console.WriteLine(end);
    Dictionary<int,int>doubled= new Dictionary<int,int>();
    for(int i=0;i<nums.Length;i++)
    {
        if (doubled.ContainsKey(nums[i]))
        {
            doubledElement = nums[i];
            break;
        }
        else
        {
            doubled.Add(nums[i], 1);
        }
    }
    for(int i = start; i <= end; i++)
    {
        
        if (!nums.Contains(i))
        {
            missingElement = i;
        }
    }
    result[0]= doubledElement;
    result[1]= missingElement;
    return result;

}
int[]arr= new int[] { 1, 2, 2, 4 };
var result=FindErrorNums(arr);
Console.WriteLine(String.Join(",", result));