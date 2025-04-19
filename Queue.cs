MyQueue<int> q = new MyQueue<int>();


q.Enqueue(1);
q.Enqueue(2);
q.Enqueue(3);
q.Enqueue(4);

while(q.Count()>0)
{
    Console.WriteLine(q.Dequeue());
}

public class MyQueue<T>
{
    private List<T>elements=new List<T>();
   
    public void Enqueue(T element)
    {
       elements.Add(element);
    }
    public T Dequeue()
    {
        if(isEmpty())
        {
            Console.WriteLine("Queue is empty");
            return default;
        }
        else
        {
            T item=elements[0];
            elements.RemoveAt(0);
            return item;
        }

    }
    public bool isEmpty()
    {
        return elements.Count == 0;
    }

    public T Peek()
    {
        if (isEmpty())
        {
            Console.WriteLine("Queue is empty");
            return default;
        }
            return elements[0];
        
    }
    public int Count()
    {
        return elements.Count;
    }
   
}