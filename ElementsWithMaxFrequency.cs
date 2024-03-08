int MaxFrequencyElements(int[] nums)
{
    Dictionary<int,int>result= new Dictionary<int,int>();
    foreach(int el in nums)
    {
        if(result.ContainsKey(el))
        {
            result[el]++;
        }
        else
        {
            result.Add(el, 1 );
        }
    }
    int maxFrequency=result.Max(x=>x.Value);
    return result.Where(x=>x.Value==maxFrequency).Sum(a=>a.Value);
}
