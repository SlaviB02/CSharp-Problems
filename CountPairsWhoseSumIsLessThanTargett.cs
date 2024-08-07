﻿int CountPairs(IList<int> nums, int target)
{
    int count = 0;
    for(int i=0;i<nums.Count;i++)
    {
        for(int j=i+1;j<nums.Count;j++)
        {
            if (nums[i] + nums[j]<target)
            {
                count++;
            }
        }
    }
    return count;
}


int[] nums = [-1, 1, 2, 3, 1];
int target = 2;
int res=CountPairs(nums, target);
Console.WriteLine(res);