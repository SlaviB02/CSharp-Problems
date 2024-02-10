
using System.Text;
int CountSubstrings(string s)
{
    int count = 0;
    for (int i = 0; i < s.Length; ++i)
    {
        StringBuilder subString = new StringBuilder(s.Length - i);
        for (int j = i; j < s.Length; ++j)
        {
            subString.Append(s[j]);
            if(checkPalindrome(subString.ToString()))
            {
                count++;
            }
        }
    }
    return count;
}
bool checkPalindrome(string s)
{
    char[]letters=s.ToCharArray();
    Array.Reverse(letters);
    string reversed=new string(letters);
    if(s==reversed)
    {
        return true;
    }
    return false;
}
string s = "aaa";

var a = CountSubstrings(s);
Console.WriteLine(a);