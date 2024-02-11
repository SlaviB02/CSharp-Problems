IList<int> SelfDividingNumbers(int left, int right)
{
    IList<int> result = new List<int>();
    for(int i = left; i <= right;i++)
    {
        int temp = i;
        bool flag = true;
        while(temp>0)
        {
            int digit=temp%10;
            if(digit==0 || i % digit != 0)
            {
                flag = false;
                break;
            }
            temp /= 10;
        }
        if(flag)
        {
            result.Add(i);
        }
    }
    return result;
}
var list = SelfDividingNumbers(47, 85);
Console.WriteLine(String.Join(",",list));