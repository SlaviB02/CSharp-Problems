char FindTheDifference(string s, string t)
{
    List<char>letters = new List<char>();
   letters=s.ToCharArray().ToList();
    
    for(int i=0; i<letters.Count; i++)
    {
        int index = t.IndexOf(letters[i]);
       t=t.Remove(index,1);
       
    }
    return t[0];
   
}
string s = "abcd", t = "abcde";
char res=FindTheDifference(s, t);
Console.WriteLine(res);