int ScoreOfString(string s)
{
    int sum = 0;
    for(int i=0;i<s.Length-1;i++)
    {
        int diff = Math.Abs(s[i]-s[i+1]);
        sum += diff;
    }
    return sum;
}
string s = "hello";
int score=ScoreOfString(s);
Console.WriteLine(score);