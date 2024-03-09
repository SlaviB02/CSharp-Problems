int GetCommon(int[] nums1, int[] nums2)
{
    for (int i = 0; i < nums1.Length; i++)
    {
        if (nums2.Contains(nums1[i]))
        {
            return nums1[i];
        }
    }
    return -1;
}
int res = GetCommon(new int[] { 1, 2, 3 }, new int[] { 2, 4 });
Console.WriteLine(res);