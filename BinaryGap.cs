int BinaryGap(int n)
{
    string num=binary(n);
    int maxGap = 0;
    for(int  i = 0; i < num.Length; i++)
    {
        if (num[i]=='1')
        {
            int index = i;
            for(int j=index+1;j<num.Length;j++)
            {
                if (num[j]=='1')
                {
                    int ln = j - index;
                    if(maxGap<ln)
                    {
                        maxGap = ln;
                    }
                    break;
                }
            }
        }
    }
    return maxGap;

}
string binary(int n)
{
    string res = "";
    while(n > 0)
    {
        if(n%2 == 0)
        {
            res += "0";
        }
        else
        {
            res += "1";
        }
        n /= 2;
    }
    char[]numbers=res.ToCharArray();
    Array.Reverse(numbers);
    return new string(numbers);
}
int n = 22;
int res=BinaryGap(n);
Console.WriteLine(res);