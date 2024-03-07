bool DetectCapitalUse(string word)
{
    string toUpper=word.ToUpper();
    if(word==toUpper) return true;
    string toLower=word.ToLower();
    if(word==toLower) return true;
    string thenLower = word.Substring(1).ToLower();
    if (Char.IsUpper(word[0]))
    {
        if(thenLower==word.Substring(1))
        {
            Console.WriteLine(thenLower);
            return true;
        }
    }
    return false;
}
var res = DetectCapitalUse("FlaG");
Console.WriteLine(res);