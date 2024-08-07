int PrefixCount(string[] words, string pref)
{
    int count = 0;
    int prefLength = pref.Length;
    for(int i = 0; i < words.Length; i++)
    {
        
        if (words[i].Length<prefLength)
        {
            continue;
        }
        string current = words[i].Substring(0, prefLength);
        if (current == pref)
        {
            count++;
        }
    }
    return count;
}
string[] words = ["leetcode", "win", "loops", "success"];
string pref = "code";
int res=PrefixCount(words, pref);
Console.WriteLine(res);