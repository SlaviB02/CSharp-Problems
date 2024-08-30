using System.Globalization;

int DaysBetweenDates(string date1, string date2)
{
    DateTime firstDate=DateTime.ParseExact(date1,"yyyy-MM-dd",CultureInfo.InvariantCulture);
    DateTime secondDate = DateTime.ParseExact(date2, "yyyy-MM-dd", CultureInfo.InvariantCulture);

    return Math.Abs((firstDate-secondDate).Days);
}
string date1 = "2019-06-29", date2 = "2019-06-30";
int res=DaysBetweenDates(date1, date2);
Console.WriteLine(res);