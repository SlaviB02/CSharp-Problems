int[] FinalPrices(int[] prices)
{
    for(int i = 0; i < prices.Length; i++)
    {
        int product = prices[i];
        int discount= 0;
        for(int j = i+1;j<prices.Length;j++)
        {
            if (product >= prices[j])
            {
                discount = prices[j];
                break;
            }
        }
        prices[i] -= discount;
    }
    return prices;
}
int[] prices = [8, 4, 6, 2, 3];
int[]discount=FinalPrices(prices);
Console.WriteLine(String.Join(", ", prices));