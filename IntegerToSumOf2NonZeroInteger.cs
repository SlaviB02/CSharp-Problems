int[] GetNoZeroIntegers(int n)
{
    int left=1; int right=n-1;
    while(true)
    {
        if (checkIfHasZero(left) && checkIfHasZero(right))
        {
            return [left, right];
        }
        left++;
        right--;
    }
   
}
bool checkIfHasZero(int n)
{
    while(n>0) {
        int digit=n%10;
        if(digit==0)
        {
            return false;
        }
        n /= 10;
    }
    return true;
}
int n = 11;
var result=GetNoZeroIntegers(n);
Console.WriteLine(String.Join(",",result));