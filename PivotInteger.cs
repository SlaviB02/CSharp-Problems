int PivotInteger(int n)
{
    int sumX = 0;
    for (int i = 1; i <=n; i++)
    {
        int sumN = 0;
        sumX += i;
        for (int j = i; j <=n; j++)
        {
            sumN += j;
        }
      
        if(sumX==sumN)
        {
            return i;
        }
    }
    return -1;
}
int n = 8;
Console.WriteLine(PivotInteger(n));