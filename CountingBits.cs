int[] CountBits(int n)
{
    int[]res= new int[n+1];
    for(int i = 0; i < n+1; i++)
    {
        int count = 0;
        int temp = i;
        while(temp>0)
        {
            int digit = temp % 2;
            if(digit==1)
            {
                count++;
            }
            temp /= 2;
        }
        res[i] = count;
    }
    return res;
}
int n = 2;
int[]res=CountBits(n);
Console.WriteLine(String.Join(", ", res));