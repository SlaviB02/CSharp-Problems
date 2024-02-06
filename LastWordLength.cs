int LengthOfLastWord(string s)
{
    var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    var lastWord = words[words.Length-1];
    return lastWord.Length;
}
string word = "Hello World";
Console.WriteLine(LengthOfLastWord(word));