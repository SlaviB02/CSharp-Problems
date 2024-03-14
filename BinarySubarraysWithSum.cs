int NumSubarraysWithSum(int[] nums, int goal)
{
    int count = 0;
  
    for(int i = 0; i < nums.Length; i++)
    {
        int sum = 0;
        if (nums[i] ==goal)
        {
            count++;
        }
        sum += nums[i];
        for (int j=i+1; j<nums.Length; j++)
        {
            
            sum += nums[j];

            if (sum == goal)
            {
                count++;
                
            }
        }
        

    }
   return count;
}
int[] nums = new int[] { 0, 0, 0, 0, 0 };
int goal = 0;
int result = NumSubarraysWithSum(nums, goal);
Console.WriteLine(result);  