string MakeGood(string s)
{
    int index = 0;
    while(true)
    { 
        if(index+1>=s.Length)
        {
            break;
        }
        char letter1 = s[index];
        char letter2 = s[index+1];
         if (char.IsUpper(letter1) && char.IsLower(letter2) || char.IsUpper(letter2) && char.IsLower(letter1))
        {
            if (char.ToLower(letter1) == char.ToLower(letter2))
            {
              s=s.Remove(index,2);
                index = 0;
            }
            else
            {
                index++;
            }
        }
         else
        {
            index++;
        }
    }
    return s;
}
string s = "abBAcC";
var result=MakeGood(s);
Console.WriteLine(result);