IList<int> SequentialDigits(int low, int high)
{
    List<int> result = new List<int>();
    int left=low;
    int right = high;
    while(true)
    {

        if(left==right || left>right)
        {
            break;
        }
        if(checkDigits(left))
        {
            result.Add(left);
        }
        if (checkDigits(right))
        {
            result.Add(right);
        }
        left++;
        right--;
        
    }
    result.Sort();
    return result;
}
bool checkDigits(int n)
{
    int current = n % 10;
    n/=10;
    while(n>0)
    {
        int digit = n % 10;
        if(current-1!=digit)
        {
            return false;
        }
        current=digit; 
        n /= 10;
    }
    return true;
}
int low = 58, high = 155;
var res=SequentialDigits(low, high);
Console.WriteLine(String.Join(",", res));