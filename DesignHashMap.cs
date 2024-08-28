
public class MyHashMap
{
    private List<List<int>> map;
    public MyHashMap()
    {
        map= new List<List<int>>();
    }

    public void Put(int key, int value)
    {
        if (map.FirstOrDefault(k => k[0]==key)!=null)
        {
          var item=map.First(k => k[0] == key);
            map.Remove(item);
            item[1] = value;
           map.Add(item);
        }
        else
        {
            map.Add(new List<int>() { key,value});
        }
    }

    public int Get(int key)
    {
        var value=map.FirstOrDefault(k => k[0] == key);
        if(value == null)
        {
            return -1;
        }
        return value[1];
    }

    public void Remove(int key)
    {
        var item=map.FirstOrDefault(k=>k[0] == key);
        if (item != null)
        {
            map.Remove(item);
        }
    }
}
