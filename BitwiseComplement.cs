int BitwiseComplement(int n)
{
    string num = "";
    if (n == 0) return 1;
    while(n>0)
    {
        int digit = n % 2;
        if(digit==0)
        {
            num += "1";
        }
        else
        {
            num += "0";
        }
        n /= 2;
    }
    char[]digits=num.ToCharArray();
    Array.Reverse(digits);
    string res = new string(digits);
   int result=Convert.ToInt32(res, 2);
    return result;
}
int n = 5;
int res=BitwiseComplement(n);
Console.WriteLine(res);