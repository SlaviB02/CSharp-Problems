int[] SortArrayByParity(int[] nums)
{
    List<int>even=new List<int>();
    List<int>odd=new List<int>();   
    for(int i=0; i<nums.Length; i++)
    {
        if (nums[i]%2==0)
        {
            even.Add(nums[i]);
        }
        else
        {
            odd.Add(nums[i]);
        }
    }
    int[]result=new int[nums.Length];
    int index = 0;
    for(int i=0;i<even.Count;i++)
    {
        result[index] = even[i];
        index++;
    }
    for(int i=0; i<odd.Count;i++)
    { 
        result[index] = odd[i];
    index++;
    }
    return result;
}
int[] nums = new int[] { 3, 1, 2, 4 };
var result=SortArrayByParity(nums);
Console.WriteLine(String.Join(",",result));