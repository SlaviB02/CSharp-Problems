bool KLengthApart(int[] nums, int k)
{
    int count = 0;
    for(int i=0; i<nums.Length; i++)
    {
        count = 0;
        if (nums[i] == 1)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[j] != 1)
                {
                    count++;
                }
                else
                {
                    if(count<k)
                    {
                        return false;
                    }
                    i = j-1;
                    break;
                }
         
            }
        }
       
    }
    return true;
}
int[] nums = [1, 0, 0, 1, 0, 1];
int k = 2;
bool res=KLengthApart(nums, k);
Console.WriteLine(res); 