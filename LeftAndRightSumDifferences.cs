int[] LeftRightDifference(int[] nums)
{
    int[]result=new int[nums.Length];
    int[]rightSum=new int[nums.Length];
    int[] leftSum = new int[nums.Length];
    leftSum[0]=0;
    rightSum[nums.Length-1]=0;
    for(int i=1; i<nums.Length; i++)
    {
        int sum = 0;
        for(int j=0; j<i; j++)
        {
            sum+= nums[j];
        }
        leftSum[i]=sum;

    }
    Console.WriteLine(String.Join(",", leftSum));
    for (int i = nums.Length-2;i>=0;i--)
    {
        int sum = 0;
        for (int j =nums.Length-1; j >i; j--)
        {
            sum += nums[j];
        }
        rightSum[i] = sum;

    }
    Console.WriteLine(String.Join(",", rightSum));
    for (int i=0;i<nums.Length; i++)
    {
        result[i] = Math.Abs(leftSum[i] - rightSum[i]);
    }
    return result;

}
int[] nums = new int[] { 10, 4, 8, 3 };
var result=LeftRightDifference(nums);
Console.WriteLine(String.Join(",",result));