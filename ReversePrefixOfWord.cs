string ReversePrefix(string word, char ch)
{
    int index=word.IndexOf(ch);
    if(index==-1)
    {
        return word;
    }
    string prefix=word.Substring(0,index+1);
    char[]letters=prefix.ToCharArray();
    Array.Reverse(letters);
    string reversedPrefix=new string(letters);
    string result=word.Substring(index+1);
    return reversedPrefix + result;
}
string word = "abcdefd";
char ch = 'd';
string res=ReversePrefix(word, ch);
Console.WriteLine(res);