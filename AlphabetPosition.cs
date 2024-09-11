string AlphabetPosition(string text)
{
    string res = "";
    for(int i=0;i<text.Length;i++)
    {
        char letter=text[i];
        if(char.IsLetter(letter))
        {
            if (char.IsUpper(letter))
            {
                res += letter - 64 + " ";
            }
            else
            {
                res += letter - 96 + " ";
            }
           
        }
    }
    return res.TrimEnd();
}
string text = "The sunset sets at twelve o' clock.";
string res=AlphabetPosition(text);
Console.WriteLine(res);