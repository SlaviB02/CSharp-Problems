IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
{
    IList<IList<int>>result=new List<IList<int>>();
    IList<int>res1 = new List<int>();
    IList<int>res2= new List<int>();
    for(int i=0; i<nums1.Length; i++)
    {
        if (!nums2.Contains(nums1[i]))
        {
            res1.Add(nums1[i]);
        }
    }
    for(int i= 0; i<nums2.Length; i++)
    {
        if (!nums1.Contains(nums2[i]))
        {
            res2.Add(nums2[i]);
        }
    }
    result.Add(res1.Distinct().ToList());
    result.Add(res2.Distinct().ToList());
    return result;
}