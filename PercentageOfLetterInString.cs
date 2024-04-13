int PercentageLetter(string s, char letter)
{
    int times = 0;
    for(int i = 0; i < s.Length; i++)
    { 
        if (s[i] == letter) 
        { 
            times++;
        }    
    }
    double result = (times / (double)s.Length)*100;
    return (int)result;
}
string s = "foobar";
char letter = 'o';
int res = PercentageLetter(s, letter);
Console.WriteLine(res);
