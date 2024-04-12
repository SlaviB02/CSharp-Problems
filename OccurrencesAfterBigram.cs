string[] FindOcurrences(string text, string first, string second)
{
    string[]words=text.Split(' ');
    List<string> result = new List<string>();   
     for(int i=0; i<words.Length-2; i++)
    {
        if (words[i]==first && words[i+1]==second)
        {
            result.Add(words[i+2]);
        }
    }
     return result.ToArray();
}
string text = "alice is a good girl she is a good student", first = "a", second = "good";
var res=FindOcurrences(text, first, second);
Console.WriteLine(String.Join(",",res));