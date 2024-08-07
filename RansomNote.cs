bool CanConstruct(string ransomNote, string magazine)
{
   
    for (int i = 0; i < magazine.Length; i++)
    {
        if(ransomNote=="")
        {
            return true;
        }
        char letter = magazine[i];
        if(ransomNote.Contains(letter))
        {
            int index=ransomNote.IndexOf(letter);
           ransomNote=ransomNote.Remove(index,1);
        }
        
        
    }
    if(ransomNote=="")
    {
        return true;
    }
    return false;
}
string ransomNote = "aab", magazine = "baa";
bool res=CanConstruct(ransomNote, magazine);
Console.WriteLine(res);
