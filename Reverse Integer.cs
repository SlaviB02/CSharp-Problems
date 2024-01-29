int x = 120;
int reverse = 0;
bool flag = true;
if(x<0)
{
    flag = false;
    x = -x;
}
while(x>0)
{
    int digit = x % 10;
    x = x / 10;
    reverse = reverse + digit;
    reverse = reverse * 10;
}
reverse = reverse / 10;
if(flag==false)
{
    reverse = -reverse;
}
Console.WriteLine(reverse);