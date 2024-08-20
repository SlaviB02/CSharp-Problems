IList<string> StringMatching(string[] words)
{

    List<string> result = new List<string>();

    for(int i=0;i< words.Length;i++)
    {
        string word=words[i];
        for(int j=0;j< words.Length;j++)
        {
            if(j==i)
            {
                continue;
            }

            if (words[j].Contains(word))
            {
                result.Add(word);
            }

        }
    }

    return result.Distinct().ToList();
}

string[] words = ["mass", "as", "hero", "superhero"];

var res=StringMatching(words);

Console.WriteLine(string.Join(",",res));