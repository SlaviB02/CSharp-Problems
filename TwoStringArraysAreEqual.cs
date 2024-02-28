using System.Text;

bool ArrayStringsAreEqual(string[] word1, string[] word2)
{
    StringBuilder sb1 = new StringBuilder();
    StringBuilder sb2 = new StringBuilder();
    for (int i=0;i<word1.Length;i++)
    {
        sb1.Append(word1[i]);
    }
    foreach (var s in word2)
    {
        sb2.Append(s);
    }
  
    if(sb1.ToString()==sb2.ToString())
    {
        return true;
    }
    return false;
}
var res = ArrayStringsAreEqual(new string[] { "ab", "c" }, new string[] { "a", "bc" });
Console.WriteLine(res);