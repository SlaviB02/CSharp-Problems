IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
{
    List<T>res=new List<T>();
    int index = 0;
    foreach (T item in iterable)
    {
        if(index==0)
        {
            res.Add(item);
            index++;
            
        }
        else if (!item.Equals(res[index-1]))
        {
            res.Add(item);
            index++;
        }
        
    }
    return res;
 }
string a = "AAAABBBCCDAABBB";
var res=UniqueInOrder(a);
Console.WriteLine(string.Join(",",res));