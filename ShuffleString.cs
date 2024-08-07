string RestoreString(string s, int[] indices)
{
    string res = "";
    int index = 0;
   
    while(true)
    {
        if(index>=indices.Length)
        {
            break;
        }
        int i = indices.ToList().IndexOf(index);
        res += s[i];
        index++;
    }
    
    return res;
}
string s = "codeleet";
int[] indices = [4, 5, 6, 7, 0, 2, 1, 3];
string res=RestoreString(s, indices);
Console.WriteLine(res); 