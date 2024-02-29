int FindSpecialInteger(int[] arr)
{
    Dictionary<int,int>res=new Dictionary<int,int>();
    foreach(int num in arr)
    {
        if(res.ContainsKey(num))
        {
            res[num]++;
        }
        else
        {
            res.Add(num, 1);
        }
    }
    return res.OrderByDescending(x=>x.Value).First().Key;
}
int[] arr = new int[] { 1, 2, 2, 6, 6, 6, 6, 7, 10 };
Console.WriteLine(FindSpecialInteger(arr));