static int DigitalRoot(long n)
{
    long current = 0;
    while (true)
    {
        current = 0;
        while (n > 0)
        {
            current += n % 10;
            n /= 10;
        }
        if (current < 10)
        {
            return int.Parse(current.ToString());
        }
        n = current;
    }
}
long n = 493193;
int res=DigitalRoot(n);
Console.WriteLine(res);