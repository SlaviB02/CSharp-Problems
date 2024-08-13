bool CheckPerfectNumber(int num)
{
    int sum = 1;

    if(num==1)
    {
        return true;
    }

    for(int i=2;i<=num/2;i++)
    {
        if(num%i==0)
        {
            sum += i;
        }


        if(sum>num)
        {
            return false;
        }
    }

    if(sum==num)
    {
        return true;
    }

    return false;
}

int num = 28;

var res=CheckPerfectNumber(num);

Console.WriteLine(res);