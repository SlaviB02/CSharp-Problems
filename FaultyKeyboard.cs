string FinalString(string s)
{
    string res = "";
    for(int i= 0; i < s.Length; i++)
    {
        char letter= s[i];
        if(letter=='i')
        {
            char[]arr=res.ToCharArray();
            Array.Reverse(arr);
            res=new string(arr);
        }
        else
        {
            res+=letter;
        }
    }
    return res;
}
string s = "string";
string res=FinalString(s);
Console.WriteLine(res);