public class MyStack
{
    private Queue<int> list;
    public MyStack()
    {
        list = new Queue<int>();
    }

    public void Push(int x)
    {
        list.Enqueue(x);
    }

    public int Pop()
    {
        list=new Queue<int>(list.Reverse());
        int res=list.Dequeue();
        list = new Queue<int>(list.Reverse());
        return res;
    }

    public int Top()
    {
        list = new Queue<int>(list.Reverse());
        int res = list.Peek();
        list = new Queue<int>(list.Reverse());
        return res;
    }

    public bool Empty()
    {
        if (list.Count == 0)
        {
            return true;
        }
        return false;
    }
}
