int GetLucky(string s, int k)
{
    string number = "";
    for(int i=0;i<s.Length; i++)
    {
        number += s[i] - 96;
    }
    for(int i=0;i<k;i++)
    {
        string temp = number;
        int sum = 0;
        for(int j=0;j<temp.Length;j++)
        {
            sum += int.Parse(temp[j].ToString());
        }
        number = sum.ToString();
      
    }
    return int.Parse(number);
}
string s = "leetcode";
int k = 2;
int res=GetLucky(s,k);
Console.WriteLine(res);