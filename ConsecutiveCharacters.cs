int MaxPower(string s)
{
    int maxPower = 0;
    for(int i= 0; i < s.Length; i++)
    {
        int letter= s[i];
        int currentPower = 1;
        for(int j=i+1; j < s.Length; j++)
        {
            if(letter== s[j])
            {
                currentPower++;
            }
            else
            {
                break;
            }
        }
        if(currentPower>maxPower)
        {
            maxPower = currentPower;
        }
    }
    return maxPower;
}
string s = "abbcccddddeeeeedcba";
int power=MaxPower(s);
Console.WriteLine(power);