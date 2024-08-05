string KthDistinct(string[] arr, int k)
{
    Dictionary<string,int>distinct= new Dictionary<string,int>();

    for(int i=0; i<arr.Length; i++)
    {
        if (distinct.ContainsKey(arr[i]))
        {
            distinct[arr[i]]++;
        }
        else
        {
            distinct.Add(arr[i], 1);
        }
    }

    var res=distinct.Where(e=>e.Value==1).Select(k=>k.Key).ToList();

    if(k>res.Count)
    {
        return "";
    }



    return res[k-1];
}

string[] arr = ["d", "b", "c", "b", "c", "a"];
int k = 2;

var res=KthDistinct(arr, k);

Console.WriteLine(res);