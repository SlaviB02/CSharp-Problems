int[] Intersection(int[] nums1, int[] nums2)
{
    HashSet<int>result=new HashSet<int>();
    for (int i = 0; i < nums1.Length; i++)
    {
        foreach(int n in nums2)
        {
            if (nums1[i]==n)
            {
                result.Add(nums1[i]);
            }
        }
    }
    return result.ToArray();
}