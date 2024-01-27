var nums1 = new int[] { 1, 3 };
var nums2 = new int[] { 2,4 };
List<int> nums3 = new List<int>();
foreach(int i in nums1)
{
    nums3.Add(i);
}
foreach(int i in nums2)
{
    nums3.Add(i);
}
nums3.Sort();
double median = 0;
if(nums3.Count%2==0)
{
    int l = nums3.Count/2;
    median =(double)(nums3[l] + nums3[l-1])/2;
}
else
{
    median = nums3[nums3.Count/2];
}
Console.WriteLine(median);
