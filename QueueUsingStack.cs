class MyQueue
{
    private Stack<int> list;
    public MyQueue()
    {
        list=new Stack<int>();
    }

    public void Push(int x)
    {
        list.Push(x);
    }

    public int Pop()
    {

        Stack<int>rev=new Stack<int> ();
     while(list.Count!=0)
        {
            rev.Push(list.Pop());
        }
       
        int item=rev.Pop();

        while (rev.Count != 0)
        {
            list.Push(rev.Pop());
        }

        return item;
    }

    public int Peek()
    {
        var temp=new Stack<int>(new Stack<int>(list));
        

        while (temp.Count != 1)
        {
            temp.Pop();
        }

        return temp.Pop();
    }

    public bool Empty()
    {
        if(list.Count<1)
        {
            return true;
        }
        return false;
    }
}