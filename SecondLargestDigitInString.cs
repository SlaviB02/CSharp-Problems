int SecondHighest(string s)
{
    List<int> list = new List<int>();
    for (int i = 0; i < s.Length; i++)
    {
        if (Char.IsDigit(s[i]))
        {
            list.Add(s[i]-'0');
           
        }
    }
    var nums = list.Distinct().OrderByDescending(x => x).ToList();
    if (nums.Count<2)
    {
        return -1;
    }
   
    return nums[1];
}
string s = "dfa12321afd";
int result=SecondHighest(s);
Console.WriteLine(result);