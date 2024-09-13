string CreatePhoneNumber(int[] numbers)
{
    string res = "(";
    for(int i=0;i<numbers.Length;i++)
    {
        if(i==2)
        {
            res += numbers[i] + ") ";
        }
        else if(i==5)
        {
            res += numbers[i] + "-";
        }
        else
        {
            res += numbers[i];
        }
    }
    return res;
}
int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
string res=CreatePhoneNumber(nums);
Console.WriteLine(res);