int CountPrefixes(string[] words, string s)
{
    int count = 0;
    for(int i=0; i<words.Length; i++)
    {
        int len=words[i].Length;
       if (len > s.Length)
        {
            continue;
        }
        if (s.Substring(0, len) == words[i])
        {
            count++;
        }
    }
    return count;   
}
string[] words = ["e", "s", "mi", "e", "ia", "ibwu", "e", "e", "k", "ci", "rip", "suw", "a", "l"];
string s = "e";
int count=CountPrefixes(words, s);
Console.WriteLine(count);