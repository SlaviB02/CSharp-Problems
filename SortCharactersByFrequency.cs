string FrequencySort(string s)
{
    Dictionary<char,int>letters= new Dictionary<char,int>();
    for(int i = 0; i < s.Length; i++)
    {
        if (letters.ContainsKey(s[i]))
        {
            letters[s[i]]++;
        }
        else
        {
            letters.Add(s[i], 1);
        }
    }
    string result = "";
    foreach(var let in letters.OrderByDescending(x=>x.Value))
    {
        for(int i = 0;i<let.Value;i++)
        {
            result += let.Key;
        }
    }
    return result;
}
string s = "Aabb";
Console.WriteLine(FrequencySort(s));