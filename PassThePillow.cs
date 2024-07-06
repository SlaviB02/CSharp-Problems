int PassThePillow(int n, int time)
{
    int index = 1;
    int count = 1;
    int countPassedTimes = 0;
    while(true)
    {
        if(count==n)
        {
            index = -1;
        }
        if (count == 1)
        {
            index = 1;
        }
        if(countPassedTimes==time)
        {
            break;
        }
        count += index;
        countPassedTimes++;
    }
    return count;
}

int n = 4, time = 5;
int res=PassThePillow(n,time);
Console.WriteLine(res);