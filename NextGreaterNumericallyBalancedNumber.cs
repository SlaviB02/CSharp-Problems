int NextBeautifulNumber(int n)
{
    while(true)
    {
        n++;
        if(isBalanced(n))
        {
            return n;
        }
    }
}
bool isBalanced(int n)
{
    Dictionary<int, int> digits = new Dictionary<int, int>();

    while (n > 0)
    {
        int digit = n % 10;
        if (digit == 0)
        {
            return false;
        }

        if (digits.ContainsKey(digit))
        {
            digits[digit]++;
        }
        else
        {
            digits.Add(digit, 1);
        }
        n /= 10;
    }

    foreach (var kvp in digits)
    {
        if(kvp.Key !=kvp.Value)
        {
            return false;
        }
    }
    return true;
}

int n = 1000;

int res = NextBeautifulNumber(n);

Console.WriteLine(res);