using System.Text;

string ReformatDate(string date)
{
    StringBuilder sb = new StringBuilder();

    string[] dateparts = date.Split(" ");

    string year=dateparts[2];
    string month=dateparts[1];
    string day=dateparts[0];

    day=day.Substring(0,day.Length-2);
    int m = 0;

    sb.Append(year+"-");
    switch(month)
    {
        case "Jan":m=1; break;
        case "Feb":m=2; break;
        case "Mar":m=3; break;
        case "Apr":m=4; break;
        case "May":m=5; break;
        case "Jun":m=6; break;
        case "Jul":m=7; break;
        case "Aug":m=8; break;
        case "Sep":m=9; break;
        case "Oct":m=10; break;
        case "Nov":m=11; break;
        case "Dec":m=12; break;
    }

    if(m<10)
    {
        sb.Append("0"+m+"-");
    }
    else
    {
        sb.Append(m+"-");
    }



    if(int.Parse(day)<10)
    {
        sb.Append("0"+day);
    }
    else
    {
        sb.Append(day);
    }

    return sb.ToString();
}

string date = "20th Oct 2052";

string res = ReformatDate(date);

Console.WriteLine(res);