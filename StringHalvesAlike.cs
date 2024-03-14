bool HalvesAreAlike(string s)
{
    s= s.ToLower();
    string a=s.Substring(0, s.Length / 2);
    string b=s.Substring(s.Length/2);
    char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
    int aCount = 0;
    int bCount = 0;
    for(int i=0;i<a.Length;i++)
    {
        if (vowels.Contains(a[i]))
        {
            aCount++;
        }
        if (vowels.Contains(b[i]))
        {
            bCount++;
        }
    }
    if(aCount==bCount)
    {
        return true;
    }
    return false;
}
string s = "textbook";
var result = HalvesAreAlike(s);
Console.WriteLine(result);