﻿int CountEven(int num)
{
    int count = 0;
    for(int i=2;i<=num;i++)
    {
        int temp = i;
        int sum = 0;
        while(temp>0)
        {
            sum += temp % 10;
            temp /= 10;
        }
        if(sum%2==0)
        {
            count++;
        }
    }
    return count;
}
int num = 30;

int res=CountEven(num);

Console.WriteLine(res);