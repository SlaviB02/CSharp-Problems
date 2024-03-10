bool IsAnagram(string s, string t)
{
    char[]sLetters= s.ToCharArray();
    Array.Sort(sLetters);
    char[]tLetters= t.ToCharArray();
    Array.Sort(tLetters);
    if(new string(sLetters)==new string(tLetters))
    {
        return true;
    }
    return false;
}
string s = "anagram", t = "nagaram";
Console.WriteLine(IsAnagram(s,t));