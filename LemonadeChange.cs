bool LemonadeChange(int[] bills)
{
    Dictionary<int,int>money= new Dictionary<int,int>();

    money.Add(5,0);
    money.Add(10,0);
    money.Add(20,0);

    for (int i = 0; i < bills.Length; i++)
    {
        money[bills[i]]++;
            
        if(bills[i]==10)
        {
            if (money[5]==0)
            {
                return false;
            }
            else
            {
                money[5]--;
            }
        }

        if (bills[i]==20)
        {
            if (money[5] == 0 && money[10] == 0)
            {
                return false;
            }
            else if (money[5] == 0)
            {
                return false;
            }
            else if (money[10]==0)
            {
                money[5]-=3;
            }
            else
            {
                money[5]--;
                money[10]--;
            }
        }

        if(money[5]<0)
        {
            return false;
        }
        //foreach(var k in money)
        //{
        //    Console.WriteLine($"{k.Key}->{k.Value}");
        //}
        //Console.WriteLine("----");

    }

    return true;

}

int[] bills = [5, 5, 5, 10, 5, 5, 10, 20, 20, 20];

var res=LemonadeChange(bills);

Console.WriteLine(res);