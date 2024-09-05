IList<IList<int>> MergeSimilarItems(int[][] items1, int[][] items2)
{
    List<IList<int>>res= new List<IList<int>>();

    Dictionary<int,int>items= new Dictionary<int,int>();

    for(int i=0; i<items1.Length;i++)
    {
        int value=items1[i][0];
        int weight=items1[i][1];

        if(items.ContainsKey(value))
        {
            items[value]+=weight;
        }
        else
        {
            items.Add(value,weight);
        }
    }
    for(int i=0;i<items2.Length;i++)
    {
        int value = items2[i][0];
        int weight = items2[i][1];

        if (items.ContainsKey(value))
        {
            items[value] += weight;
        }
        else
        {
            items.Add(value, weight);
        }
    }

    foreach(var item in items.OrderBy(i=>i.Key))
    {
        res.Add(new List<int>() { item.Key,item.Value});
    }

    return res;
}
int[][] items1 = [[1, 1], [4, 5], [3, 8]], items2 = [[3, 1], [1, 5]];
var res=MergeSimilarItems(items1, items2);
for(int i=0;i<res.Count;i++)
{
    Console.WriteLine(res[i][0] + "->" + res[i][1]);
}