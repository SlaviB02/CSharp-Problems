int FindLucky(int[] arr)
{
    Dictionary<int,int>result=new Dictionary<int,int>();
    for(int i=0;i<arr.Length;i++)
    {
        if (result.ContainsKey(arr[i]))
        {
            result[arr[i]]++;
        }
        else
        {
            result.Add(arr[i], 1);
        }
    }
    foreach(var k in result.OrderByDescending(x=>x.Value))
    {
        if(k.Value==k.Key)
        {
            return k.Value;
        }
    }
    return -1;
}
int[] arr = new int[] { 2, 2, 3, 4 };
int result=FindLucky(arr);
Console.WriteLine(result);