char RepeatedCharacter(string s)
{
    List<char>letters=new List<char>();

    for(int i=0; i<s.Length; i++)
    {
        if (!letters.Contains(s[i]))
        {
            letters.Add(s[i]);
        }
        else
        {
            return s[i];
        }
    }
    return '-';
}
string s = "abccbaacz";
char res=RepeatedCharacter(s);
Console.WriteLine(res);