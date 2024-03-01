int MinLength(string s)
{
    while(true)
    {
        if(s.Contains("AB"))
        {
            int index=s.IndexOf("AB");
            s=s.Remove(index,2);
        }
        else if(s.Contains("CD"))
        {
            int index = s.IndexOf("CD");
            s=s.Remove(index, 2);
        }
        else
        {
            break;
        }
    }
    return s.Length;
}
string s = "ABFCACDB";
Console.WriteLine(MinLength(s));