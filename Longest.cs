string Longest(string s1, string s2)
{
    char letter = 'a';
    string res = "";
    while(true)
    {
        if (s1.Contains(letter))
        {
            res += letter;
        }
        else if (s2.Contains(letter))
        {
            res += letter;
        }
        else if(letter=='z')
        {
            break;
        }
        letter++;
        
    }
    return res;
}
string a = "xyaabbbccccdefww",b = "xxxxyyyyabklmopq";
var res=Longest(a,b);
Console.WriteLine(res);