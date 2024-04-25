int MostWordsFound(string[] sentences)
{
    int maxCount = 0;
    for(int i = 0; i < sentences.Length; i++)
    {
        string[] words = sentences[i].Split(" ");
        if (words.Length > maxCount)
        {
            maxCount = words.Length;
        }
    }
    return maxCount;
}
string[] sentences = ["alice and bob love leetcode", "i think so too", "this is great thanks very much"];
int words=MostWordsFound(sentences);
Console.WriteLine(words);
