var nums = new int[] { 3,3 };
int target = 6;
int firstIndex = 0;
int secondIndex = 0;
bool flag = true;
for (int i = 0; i < nums.Length; i++)
{
    for(int j = i+1;j<nums.Length; j++)
    {
        var sum = nums[j] + nums[i];
        if(sum==target)
        {
            firstIndex = i;
            secondIndex = j;
            flag = false;
            break;
        }
    }
    if(!flag)
    {
        break;
    }
}
Console.WriteLine(firstIndex + "  " + secondIndex);