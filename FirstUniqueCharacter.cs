var s = "abracadabra";
Dictionary<char,int>letters= new Dictionary<char,int>();
for (int i = 0; i < s.Length; i++)
{
    if (letters.ContainsKey(s[i]))
    {
        letters[s[i]]++;
    }
    else
    {
        letters.Add(s[i], 1);
    }

}
var orderedLetters = letters.OrderBy(x => x.Value);
var first = orderedLetters.First();
if(first.Value!=1)
{
    Console.WriteLine("-1");
}
else
{
    Console.WriteLine(s.IndexOf(first.Key));
}

    