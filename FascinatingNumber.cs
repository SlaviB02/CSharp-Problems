bool IsFascinating(int n)
{
    List<char>digits=new List<char>() { '1', '2', '3','4', '5','6', '7','8', '9' };
    string number = n.ToString();
    number += (n * 2).ToString();
    number += (n * 3).ToString();
    for(int i = 0;i<number.Length;i++)
    {
        char digit = number[i];
        if(digit==0)
        {
            return false;
        }
        if(digits.Contains(digit))
        {
            digits.Remove(digit);
        }
        else
        {
            return false;
        }
    }
    return true;
}
int n = 192;
bool res=IsFascinating(n);
Console.WriteLine(res);
