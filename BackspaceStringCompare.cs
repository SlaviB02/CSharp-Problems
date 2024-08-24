bool BackspaceCompare(string s, string t)
{
    while(true)
    {
        if(!s.Contains("#"))
        {
            break;
        }
       
        int index=s.IndexOf("#");

        if (index == 0)
        {
            s=s.Substring(1);
        }
        else
        {
            s=s.Remove(index-1,2);
        }

    }

    while(true)
    {

        if (!t.Contains("#"))
        {
            break;
        }

        int index = t.IndexOf("#");

        if (index == 0)
        {
            t = t.Substring(1);
        }
        else
        {
            t = t.Remove(index - 1, 2);
        }
    }


    return s == t;
}

string s = "ab#c", t = "ad#c";

bool res=BackspaceCompare(s, t);

Console.WriteLine(res);