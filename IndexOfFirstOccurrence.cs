int StrStr(string haystack, string needle)
{
    if(haystack.Contains(needle))
    {
          int index=haystack.IndexOf(needle);
        return index;
    }
    else
    {
        return -1;
    }
}