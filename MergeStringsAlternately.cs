string MergeAlternately(string word1, string word2)
{
    string res = "";
    while(true)
    {
        if(word1.Length==0 || word2.Length==0)
        {
            break;
        }
        res+= word1[0];
        res+= word2[0];
        word1 = word1.Remove(0, 1);
        word2 = word2.Remove(0, 1);
    }
    res += word1;
    res += word2;
    return res;
}
string word1 = "abc", word2 = "pqr";
string res=MergeAlternately(word1, word2);
Console.WriteLine(res);