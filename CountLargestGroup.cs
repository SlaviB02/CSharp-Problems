int CountLargestGroup(int n)
{
   Dictionary<int,int>result= new Dictionary<int,int>();
    for(int i=1;i<=n; i++)
    {
        int sum=digitSum(i);
        if(result.ContainsKey(sum))
        {
            result[sum]++;
        }
        else
        {
            result.Add(sum,1);
        }
    }
    var ordered=result.OrderByDescending(x => x.Value).ToDictionary();
    int largest=ordered.First().Value;
    int count = 0;
    foreach(var group in ordered)
    {
        if(group.Value==largest)
        {
            count++;
        }
        else
        {
            break;
        }
    }
    return count;
}
int digitSum(int n)
{
    int sum = 0;
    while (n > 0)
    {
        int digit = n % 10;
        sum += digit;
        n/= 10;
    }
    return sum;
}
int n = 13;
int result=CountLargestGroup(n);
Console.WriteLine(result);