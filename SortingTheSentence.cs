using System.Text;
string SortSentence(string s)
{
    string[]words=s.Split(" ");
    string[] ordered = new string[words.Length];
    foreach (string word in words)
    {
        int order = word[word.Length - 1]-'0';
        ordered[order - 1] = word.Substring(0,word.Length-1);
    }
    StringBuilder sb = new StringBuilder();
    foreach (string word in ordered)
    {
        sb.Append(word+" ");
    }
   
    return sb.ToString().TrimEnd();
}
string str = "is2 sentence4 This1 a3";
Console.WriteLine(SortSentence(str));
