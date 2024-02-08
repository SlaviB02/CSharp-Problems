int ArrangeCoins(int n)
{
    int count = 0;
    int row = 1;
    while(n>0)
    {
        n -= row;
       if(n>=0)
        {
            count++;
        }
        row++;
    }
    return count;
}
var a = ArrangeCoins(6);
Console.WriteLine(a);
