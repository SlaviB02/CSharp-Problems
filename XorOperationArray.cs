int XorOperation(int n, int start)
{
    int[]arr=new int[n];
    for(int i=0; i<n; i++)
    {
        arr[i] = start + 2 * i;
    }
    int result = 0;
    for(int i=0; i<n; ++i)
    {
        result ^= arr[i];
    }
    return result;
}
int n = 5, start = 0;
int res=XorOperation(n, start);
Console.WriteLine(res);