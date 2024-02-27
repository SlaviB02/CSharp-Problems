int TotalMoney(int n)
{
    int mondayMoney = 1;
    int total = 0;
    int currentMoney = 1;
    for(int i=1;i<=n;i++)
    {
        total += currentMoney;
        currentMoney++;
        if (i%7==0)
        {
            mondayMoney += 1;
            currentMoney = mondayMoney;
        }
        
       
    }
    return total;
}
var res = TotalMoney(10);
Console.WriteLine(res);