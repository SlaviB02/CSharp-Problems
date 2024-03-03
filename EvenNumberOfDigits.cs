using System;

int FindNumbers(int[] nums)
{
    int total = 0;
   for(int i=0; i<nums.Length; i++)
    {
        int countDigit = 0;
        while (nums[i] > 0)
        {
            nums[i] = nums[i] / 10;
            countDigit++;
        }
        if(countDigit%2== 0)
        {
            total++;
        }
    }
    return total;
}