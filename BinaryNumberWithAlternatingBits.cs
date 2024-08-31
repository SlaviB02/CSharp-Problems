bool HasAlternatingBits(int n)
{
    int OldDigit = n % 2;
    n /= 2;
    while(n>0)
    {
        int CurrentDigit=n%2;
        if(OldDigit == CurrentDigit )
        {
            return false;
        }
        OldDigit = CurrentDigit;
        n /= 2;
    }
    return true;
}
int n = 11;
var res = HasAlternatingBits(n);
Console.WriteLine(res);