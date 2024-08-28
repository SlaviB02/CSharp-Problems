int AlternateDigitSum(int n)
{
    Stack<int>digits= new Stack<int>();

    while(n>0)
    {
        int digit=n%10;
        digits.Push(digit);
        n/=10;
    }
    int index = 0;
    int sum = 0;
    while (digits.Count > 0)
    {
        int digit=digits.Pop();
        if (index % 2 == 0)
        {
            sum += digit;
        }
        else
        {
            sum-= digit;
        }
        index++;
    }
    return sum;
}
int n = 521;
int res=AlternateDigitSum(n);   
Console.WriteLine(res);