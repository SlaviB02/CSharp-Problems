int CountConsistentStrings(string allowed, string[] words)
{
   List<char>allowedChars=allowed.ToList();
    int count = 0;
    for (int i = 0; i < words.Length; i++)
    {
        bool flag = true;
        for(int j = 0; j < words[i].Length;j++)
        {
            if (!allowedChars.Contains(words[i][j]))
            {
                flag = false;
                break;
            }
        }
        if(flag)
        {
            count++;
        }
    }

    return count;

}
string allowed = "ab";
string[] words = ["ad", "bd", "aaab", "baa", "badab"];
int res=CountConsistentStrings(allowed, words);
Console.WriteLine(res);