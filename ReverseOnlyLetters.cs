string ReverseOnlyLetters(string s)
{
    string temp = "";

    for (int i = 0; i < s.Length; i++)
    {
        if (char.IsLetter(s[i]))
        {
            temp += s[i];
            s=s.Remove(i, 1).Insert(i,"~");
        }
    }
    char[]letters=temp.ToCharArray();

    Array.Reverse(letters);

    string ReversedLetters=new string(letters);
    int index = 0;
    for(int i=0;i<s.Length;i++)
    {
        if(s[i]=='~')
        {
            s=s.Remove(i, 1).Insert(i, ReversedLetters[index].ToString());
            index++;
        }
    }

    return s;

}

string s = "a-bC-dEf-ghIj";

string res=ReverseOnlyLetters(s);

Console.WriteLine(res);