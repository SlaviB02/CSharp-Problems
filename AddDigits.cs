int AddDigits(int num)
{
    while(true)
    {
        if(num<10)
        {
            return num;
        }
        int temp = num;
        int sum = 0;
        while(temp>0)
        {
            int digit = temp%10;
            sum+= digit;
            temp /=10;
        }
        num = sum;
    }

}
int n = 38;
int res=AddDigits(n);
Console.WriteLine(res);