int FindLeastNumOfUniqueInts(int[] arr, int k)
{
    Dictionary<int,int> res = new Dictionary<int,int>();
    foreach(int el in arr)
    {
        if(res.ContainsKey(el))
        {
            res[el]++;
        }
        else
        {
            res.Add(el, 1);
        }
    }
    var ordered=res.OrderBy(x => x.Value).ToDictionary();
    
   foreach(var kvp in ordered)
    {
        if(k>0)
        {
            if(k>=kvp.Value)
            {
                k-=kvp.Value;
                ordered.Remove(kvp.Key);
            }
            else
            {
                ordered[kvp.Key]-=k;
                k = 0;
            }
        }
        else
        {
            break;
        }
    }
    return ordered.Count;
}
var a = FindLeastNumOfUniqueInts(new int[] { 4, 3, 1, 1, 3, 3, 2 }, 3);
Console.WriteLine(a);
