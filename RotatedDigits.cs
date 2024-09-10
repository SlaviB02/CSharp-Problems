int RotatedDigits(int n)
{
    int count = 0;
    for(int i=2;i<=n;i++)
    {
        int temp = i;
        int digitRev=0;
        int digitNotRev = 0;
        bool flag = true;
        while(temp>0)
        {
            
            int digit = temp % 10;
            
            if (digit==2 || digit==5 || digit==6 || digit==9)
            {
                digitRev++;
            }
           else if  (digit==1 || digit==8 || digit==0)
            {
                digitNotRev++;
            }
            else
            {
                flag=false;
                break;
            }
            temp /= 10;
        }
        if (flag && digitRev>=1 && digitNotRev>=0)
        {
            count++;
           
        }
    }
    return count;
}
int n = 10;
int res=RotatedDigits(n);
Console.WriteLine(res);