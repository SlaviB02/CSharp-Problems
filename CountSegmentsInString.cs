int CountSegments(string s)
{
    var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    return words.Length;
}
string s = "Hello, my name is John";
Console.WriteLine(CountSegments(s));