bool UniqueOccurrences(int[] arr)
{
    Dictionary<int,int> result = new Dictionary<int,int>(); 
    for (int i = 0; i < arr.Length; i++)
    {
        if (result.ContainsKey(arr[i]))
        {
            result[arr[i]]++;
        }
        else {

            result.Add(arr[i], 1);
        }
    }
   var temp= result.DistinctBy(x=>x.Value);
     if(temp.Count()!=result.Count())
    {
        return false;
    }
    return true;
}