int FindNonMinOrMax(int[] nums)
{
    var list=nums.ToList();
    var max=list.Max();
    var min=list.Min();
    list.Remove(max);
    list.Remove(min);
    if(list.Count > 0)
    {
        return list[0];
    }
    return -1;
}