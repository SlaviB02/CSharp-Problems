bool IsSameAfterReversals(int num)
{
    int reversedNum = 0;
    int temp = num;
    

    while (temp > 0)
    {
        reversedNum += temp % 10;
        reversedNum *= 10;
        temp /= 10;

    }

    reversedNum /= 10;
    

    int doubleReversed = 0;

    while(reversedNum>0)
    {
        doubleReversed += reversedNum % 10;
        doubleReversed *= 10;
        reversedNum /= 10;
    }

    doubleReversed /= 10;

    

    if(doubleReversed==num)
    {
        return true;
    }

    return false;
}
int num = 526;
bool res=IsSameAfterReversals(num);
Console.WriteLine(res);