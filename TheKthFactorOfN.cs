int KthFactor(int n, int k)
{
    List<int>factors= new List<int>();
    for(int i = 1; i <= n; i++)
    {
        if(n%i == 0)
        {
            factors.Add(i);
        }
    }
    if(k>factors.Count())
    {
        return -1;
    }
    return factors[k-1];
}