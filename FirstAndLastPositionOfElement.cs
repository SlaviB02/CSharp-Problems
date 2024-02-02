int[] nums = [8];
int target = 8;
List<int>indexes= new List<int>();
for(int i = 0;i<nums.Length;i++)
{
   

    if (nums[i] == target)
    {
        indexes.Add(i);
    }
    

   
}

int[]result= new int[2];

if(indexes.Count()!=0)
{
    result[0] = indexes[0];
    result[1] = indexes[indexes.Count-1];
}
else
{
    result[0] = -1;
    result[1] = -1;
}

Console.WriteLine(String.Join(",", result));
