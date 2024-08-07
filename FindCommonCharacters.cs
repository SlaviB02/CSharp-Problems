IList<string> CommonChars(string[] words)
{
    List<string> result = new List<string>();
    string word=words[0];

    while (true)
    {
        bool flag = true;
        if(word.Length==0)
        {
            break;
        }

        for (int j = 1; j < words.Length; j++)
        {
            if (!words[j].Contains(word[0]))
            {
                flag= false;
                break;
            }
        }
        if(flag)
        {
            for (int j = 1; j < words.Length; j++)
            {
                int index = words[j].IndexOf(word[0]);
               words[j]=words[j].Remove(index, 1);
                
            }
            result.Add(word[0].ToString());
        }
        word=word.Substring(1);
       
    }
  return result;
}
string[] words = ["cool", "lock", "cook"];
var res=CommonChars(words);
Console.WriteLine(String.Join(",",res));