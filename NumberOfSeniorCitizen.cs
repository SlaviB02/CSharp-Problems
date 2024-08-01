int CountSeniors(string[] details)
{
    int count = 0;
    foreach (var d in details)
    {
        string ageString=d.Substring(11,2);
        int age = int.Parse(ageString);
        if(age>60)
        {
            count++;
        }
        
    }
    return count;
}
string[] details = ["7868190130M7522", "5303914400F9211", "9273338290F4010"];
int res = CountSeniors(details);
Console.WriteLine(res);