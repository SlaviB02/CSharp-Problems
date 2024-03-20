using System.Text;

string CapitalizeTitle(string title)
{
    string[]words=title.Split(' ');
    StringBuilder sb = new StringBuilder();
    for(int i = 0; i < words.Length; i++)
    {
        if (words[i].Length <=2)
        {
            sb.Append(words[i].ToLower()+" ");
        }
       else
        {
            string word = words[i].Substring(0,1);
            word = word.ToUpper();
            word += words[i].Substring(1).ToLower();
            sb.Append(word+" ");
        }
    }
    return sb.ToString().TrimEnd();
}
string title = "capiTalIze tHe titLe";
string result=CapitalizeTitle(title);
Console.WriteLine(result);