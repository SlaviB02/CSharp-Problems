bool ContainsNearbyDuplicate(int[] nums, int k)
{
    for(int i = 0; i < nums.Length; i++)
    {
        for(int j = i+1;j<nums.Length;j++)
        {
            if (nums[i] == nums[j])
            {
                if(Math.Abs(i-j)<=k)
                {
                    return true;
                }
            }
        }
    }
    return false;
}
int[] nums = [1, 2, 3, 1];
int k = 3;
bool result=ContainsNearbyDuplicate(nums, k);
Console.WriteLine(result);
