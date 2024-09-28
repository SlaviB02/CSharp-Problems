
MyCircularDeque myCircularDeque = new MyCircularDeque(3);
Console.WriteLine(myCircularDeque.InsertLast(1));  // return True
Console.WriteLine(myCircularDeque.InsertLast(2));  // return True
Console.WriteLine(myCircularDeque.InsertFront(3)); // return True
Console.WriteLine(myCircularDeque.InsertFront(4)); // return False, the queue is full.
Console.WriteLine(myCircularDeque.GetRear());      // return 2
Console.WriteLine(myCircularDeque.IsFull());       // return True
Console.WriteLine(myCircularDeque.DeleteLast());   // return True
Console.WriteLine(myCircularDeque.InsertFront(4)); // return True
Console.WriteLine(myCircularDeque.GetFront());     // return 4


class MyCircularDeque
{
    private List<int> deque;
    private int maxCount;
    public MyCircularDeque(int k)
    {
         deque = new List<int>();
        maxCount = k;
    }

    public bool InsertFront(int value)
    {
        if(deque.Count<maxCount)
        {
            deque.Insert(0, value);
            return true;
        }
        return false;
    }

    public bool InsertLast(int value)
    {
        if(deque.Count<maxCount)
        {
            deque.Add(value);
            return true;
        }
        return false;
    }

    public bool DeleteFront()
    {
        if(deque.Count>0)
        {
            deque.RemoveAt(0);
            return true;
        }
        return false;
    }

    public bool DeleteLast()
    {
        if(deque.Count>0)
        {
            deque.RemoveAt(deque.Count-1);
            return true;
        }
        return false;
    }

    public int GetFront()
    {
        if(deque.Count>0)
        {
            return deque[0];
        }
        return -1;
    }

    public int GetRear()
    {
        if(deque.Count>0)
        {
            return deque[deque.Count-1];
        }
        return -1;
    }

    public bool IsEmpty()
    {
        if(deque.Count==0)
        {
            return true;
        }
        return false;
    }

    public bool IsFull()
    {
        if(deque.Count==maxCount)
        {
            return true;
        }
        return false;
    }
}
