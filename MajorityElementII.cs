IList<int> MajorityElement(int[] nums)
{
    double times = nums.Length / 3;

    Dictionary<int,int>numbers=new Dictionary<int,int>();

    for(int i= 0; i < nums.Length; i++)
    {
        if (numbers.ContainsKey(nums[i]))
        {
            numbers[nums[i]]++;
        }
        else
        {
            numbers.Add(nums[i],1);
        }

    }

    List<int> res=numbers.Where(v=>v.Value>times).Select(k=>k.Key).ToList();

    return res;
}
int[] nums = [1,2];

var res=MajorityElement(nums);

Console.WriteLine(String.Join(",",res));
