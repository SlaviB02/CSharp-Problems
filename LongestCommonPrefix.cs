string LongestCommonPrefix(string[] strs)
{
    string prefix = "";

    List<string> list =strs.OrderBy(x=>x.Length).ToList();
    string word = list[0];
    for(int i=0; i < word.Length; i++)
    {
        prefix += word[i];
        bool flag = true;
        for(int j=1;j<list.Count;j++)
        {
            string prf =list[j].Substring(0,prefix.Length);

            if(prf!=prefix)
            {
                flag= false;
                prefix=prefix.Substring(0,prefix.Length-1);
                break;
            }
            
        }
        if(!flag)
        {
            break;
        }
    }
    return prefix;
}
string[] strs = ["reflower", "flow", "flight"];

string res=LongestCommonPrefix(strs);

Console.WriteLine(res);