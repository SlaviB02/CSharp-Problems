int TriangleNumber(int[] nums)
{
    Array.Sort(nums);
    int count = 0;
    for(int i=0;i<nums.Length;i++)
    {
        for(int j=i+1;j<nums.Length;j++)
        {
            for(int k=j+1;k<nums.Length;k++)
            {
                int a = nums[i];
                int b = nums[j];
                int c = nums[k];
                if (checkTriangle(a, b, c))
                {
                    count++;
                    Console.WriteLine($"{a},{b},{c}");
                }
            }
           
         
        }
    }
    return count;
}
bool checkTriangle(int a,int b,int c)
{
    if(a+b<=c || a+c<=b || b+c<=a) return false;
    return true;
}
int[] nums = new int[] { 2, 2, 3, 4 };
Console.WriteLine(TriangleNumber(nums));