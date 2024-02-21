int SubtractProductAndSum(int n)
{
    int sum = 0;
    int mult = 1;
    while(n>0)
    {
        int digit=n%10;
        sum += digit;
        mult *= digit;
        n /= 10;
    }
    return mult - sum;
}
int n = 114;
Console.WriteLine(SubtractProductAndSum(n));
