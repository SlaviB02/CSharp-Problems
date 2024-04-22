int NumWaterBottles(int numBottles, int numExchange)
{
    int count = numBottles;
    while(true)
    {
      
        if (numBottles<numExchange)
        {
            break;
        }
        int remainder=numBottles%numExchange;
        numBottles /= numExchange;
        count += numBottles;
        numBottles=remainder+numBottles;

    }
    return count;
}
int bottles = 15, exchange = 8;
int res=NumWaterBottles(bottles, exchange);
Console.WriteLine(res);