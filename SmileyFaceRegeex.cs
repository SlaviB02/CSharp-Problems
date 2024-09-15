using System.Text.RegularExpressions;

int CountSmileys(string[] smileys)
{
    string input = string.Join(" ",smileys);
   
    string regex = "(:|;){1}(-|~)*(\\)|D){1}";
    var matches = Regex.Matches(input, regex);

    return matches.Count;
}
string[] input = [":)", ";(", ";}", ":-D"];
int res=CountSmileys(input);
Console.WriteLine(res);
