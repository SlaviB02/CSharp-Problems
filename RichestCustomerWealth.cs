int MaximumWealth(int[][] accounts)
{
    int maxWealth = 0;
    for(int i= 0; i < accounts.Length; i++)
    {
        int sum = 0;
        for(int j= 0; j < accounts[i].Length; j++)
        {
            sum+= accounts[i][j];
        }
        if(maxWealth < sum)
        {
            maxWealth = sum;
        }
    }
    return maxWealth;
}
int[][] accounts = [[1, 2, 3], [3, 2, 1]];
int result=MaximumWealth(accounts);
Console.WriteLine(result);