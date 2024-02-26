string ReverseWords(string s)
{
    char[]letters=s.ToCharArray();
    Array.Reverse(letters);
    string reversed=new string(letters);
    string[]words=reversed.Split(' ');
    string result = "";
    for(int i=words.Length-1; i>=0; i--)
    {
        result += words[i]+" ";
    }
    return result.TrimEnd();
}
string s = "Let's take LeetCode contest";
Console.WriteLine(ReverseWords(s));