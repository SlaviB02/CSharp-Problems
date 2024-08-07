int LargestAltitude(int[] gain)
{
    int max = 0;
    int currentAltitude = 0;
    for(int i = 0; i < gain.Length; i++)
    {
        currentAltitude += gain[i];
        if(currentAltitude > max)
        {
            max = currentAltitude;
        }
    }
    return max;
}
int[] gain = [-5, 1, 5, 0, -7];
int largest=LargestAltitude(gain);
Console.WriteLine(largest);