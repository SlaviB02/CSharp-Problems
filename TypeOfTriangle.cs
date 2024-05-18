string TriangleType(int[] nums)
{
    int a = nums[0];
    int b = nums[1];
    int c = nums[2];
    if(a==b && b==c)
    {
        return "equilateral";
    }
    if(a+b>c && a+c>b && b+c>a)
    {
        if(a==b || b==c || a==c)
        {
            return "isosceles";
        }
        else
        {
            return "scalene";
        }
    }
    else
    {
        return "none";
    }
}
int[] nums = [3, 3, 3];
string res=TriangleType(nums);
Console.WriteLine(res);