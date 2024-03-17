using System.Text;

long CountSubstrings(string s, char c)
{
    long count = 0;
    for (int i = 0; i < s.Length; ++i)
    {
        StringBuilder sb = new StringBuilder(s.Length - i);
        for (int j = i; j < s.Length; ++j)
        {
            sb.Append(s[j]);
            if (sb[0]==c && sb[sb.Length-1]==c)
            {
                count++;
            }
        }
    }
    return count;
}
string s = "abada";
char c = 'a';
var result = CountSubstrings(s, c);
Console.WriteLine(result);