int CountOperations(int num1, int num2)
{
    int count = 0;
    while(num1!=0 && num2!=0)
    {
        if(num1>num2)
        {
            num1-=num2;
        }
        else if(num1<num2)
        {
            num2-=num1;
        }
        else
        {
            num1 = 0;
            num2= 0;
        }
        count++;
    }
    return count;
}
int num1 = 2, num2 = 3;
int result=CountOperations(num1, num2);
Console.WriteLine(result);