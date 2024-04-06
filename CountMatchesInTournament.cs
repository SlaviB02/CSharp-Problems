
int NumberOfMatches(int n)
{
    int count = 0;
    if(n%2==0)
    {
        int matches = n / 2;
        count = matches;
        while (matches>1) 
        {
            int advance = matches / 2;
            matches-=advance;
            count+=advance;
        }
    }
    else
    {
        int matches = (n - 1) / 2;
        count = matches;
        while (matches > 0)
        {
            int advance = (matches-1) / 2 +1;
            matches -= advance;
            count += advance;
        }
    }
    return count;
}
int n = 7;
int result=NumberOfMatches(n);
Console.WriteLine(result);