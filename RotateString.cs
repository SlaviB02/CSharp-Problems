bool RotateString(string s, string goal)
{
    int count = 0;
    while(true)
    {
        if(s==goal)
        {
            return true;
        }
        if(count==s.Length)
        {
            return false;
        }
        char last = s[s.Length-1];
        string temp=s.Substring(0, s.Length-1);
        string res = last + temp;
        s = res;
        count++;
    }
}
string s = "abcde", goal = "cdeab";
bool res=RotateString(s, goal);
Console.WriteLine(res);