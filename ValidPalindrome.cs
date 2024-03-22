using System.Text.RegularExpressions;

bool IsPalindrome(string s)
{
    s= s.ToLower();
    Regex rgx = new Regex("[^a-zA-Z0-9]");
    s = rgx.Replace(s, "");
    string res=new string(s.ToCharArray()
         .Where(c => !Char.IsWhiteSpace(c))
         .ToArray());
    string start=res.Substring(0, res.Length/2);
    char[] letters = res.ToCharArray();
    Array.Reverse(letters);
    string temp=new string(letters);
    string end=temp.Substring(0, temp.Length/2);
    Console.WriteLine(start);
    Console.WriteLine(end);
    if (start==end)
    {
        return true;
    }
    return false;
}
string s = "A man, a plan, a canal -- Panama";
Console.WriteLine(IsPalindrome(s));