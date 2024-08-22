string RemoveDuplicates(string s)
{
    while(true)
    {
        bool flag = true;
        for(int i=0; i<s.Length-1; i++)
        {
            if (s[i] == s[i+1])
            {
                s=s.Remove(i,2);
                flag = false;
                break;
            }
        }

        if (flag)
        {
            break;
        }
        

       
    }
    return s;
}

string s = "abbaca";

var res=RemoveDuplicates(s);

Console.WriteLine(res);