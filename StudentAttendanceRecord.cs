bool CheckRecord(string s)
{
    int AbsentDays = 0;
    int LateDays = 0;
    for(int i= 0; i < s.Length; i++)
    {
        if(s[i] =='A')
        {
            AbsentDays++;
            LateDays = 0;
        }
        else if (s[i]=='L')
        {
            LateDays++;
        }
        else
        {
            LateDays = 0;
        }
        if(LateDays>=3)
        {
            return false;
        }
    }
    if(AbsentDays<2)
    {
        return true;
    }
    return false;
}