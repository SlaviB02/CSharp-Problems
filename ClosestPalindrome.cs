string NearestPalindromic(string n)
{
    int number=int.Parse(n);
    int left = number - 1;
    int right = number + 1;
   while(isPalindrome(left.ToString())==false)
    {
        left--;
    }
    while (isPalindrome(right.ToString()) == false)
    {
        right++;
    }
    if(Math.Abs(number-right)<Math.Abs(number-left))
    {
        return right.ToString();
    }
    else
    { 
        return left.ToString();
    }
   
}
bool isPalindrome(string n)
{
    int left = 0;
    int right = n.Length - 1;

    while (left < right)
    {
        if (n[left] != n[right])
        {
            return false;
        }
        left++;
        right--;
    }
    return true;
}
string n = "1213";
string res = NearestPalindromic(n);
Console.WriteLine(res);