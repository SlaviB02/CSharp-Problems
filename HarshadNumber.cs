int SumOfTheDigitsOfHarshadNumber(int x)
{
    int temp = x;
    int sum = 0;
    while (temp > 0)
    {
        sum += temp % 10;
        temp /= 10;
    }

    if(x%sum==0)
    {
        return sum;
    }

    return -1;
}

int x = 18;

int res = SumOfTheDigitsOfHarshadNumber(x);

Console.WriteLine(res);
