using System.Text;

string LongestPalindrome(string s)
{
    string result = "";
    int max = 0;
    for (int i = 0; i < s.Length; ++i)
    {
        StringBuilder sb = new StringBuilder(s.Length - i);
        for (int j = i; j < s.Length; ++j)
        {
            sb.Append(s[j]);
            if(isPalindrome(sb.ToString()) && sb.Length>max)
            {
                result= sb.ToString();
                max = sb.Length;
            }
        }
    }
    return result;
}
bool isPalindrome(string myString)
{
    string first = myString.Substring(0, myString.Length / 2);
    char[] arr = myString.ToCharArray();

    Array.Reverse(arr);

    string temp = new string(arr);
    string second = temp.Substring(0, temp.Length / 2);

    return first.Equals(second);
}
