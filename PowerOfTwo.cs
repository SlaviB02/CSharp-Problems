bool IsPowerOfTwo(int n)
{
    if (n == 0) return false;
    if(n>0)
    {
        for (int i = 0; i < 31; i++)
        {
            double pow = Math.Pow(2, i);
            if (pow == n)
            {
                return true;
            }
        }
    }
   


    return false;
}

var a = IsPowerOfTwo(-4);
Console.WriteLine(a);