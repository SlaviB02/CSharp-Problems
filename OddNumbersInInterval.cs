int CountOdds(int low, int high)
{
    int count = 0;
    while (low<=high)
    {
       
        if (low % 2 != 0)
        {
            count++;
        }
        if (low == high)
        {
            break;
        }
        if (high % 2 != 0)
        {
            count++;
        }
        low++;
        high--;
    }
    return count;
}
int low = 3, high = 7;
int res=CountOdds(low, high);
Console.WriteLine(res);