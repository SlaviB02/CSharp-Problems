using System.Text;

string ReplaceDigits(string s)
{
    StringBuilder sb = new StringBuilder();
    for(int i=0;i<s.Length-1;i+=2)
    {
       
     
        char c= s[i];
        char x = s[i + 1];
        int num = x - '0';
        sb.Append(s[i]);
        sb.Append((char)((int)c+num));
        
        
    }
    if (!char.IsDigit(s[s.Length - 1]))
        sb.Append(s[s.Length - 1]);
    return sb.ToString();

}
string s = "a1c1e1";
Console.WriteLine(ReplaceDigits(s));