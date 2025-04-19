using System.Xml.Linq;

MyQueue<int> q = new MyQueue<int>();


q.Enqueue(1);
q.Enqueue(2);
q.Enqueue(3);
q.Enqueue(4);

while (!q.isEmpty())
{
    Console.WriteLine(q.Dequeue());
}

public class MyQueue<T>
{
    private const int MAX = 100;
    private T[]queue=new T[MAX];
    private int head=0;
    private int tail=0;
   
    public void Enqueue(T element)
    {
       if(tail>MAX)
        {
            Console.WriteLine("Max length of queue!");
        }
       else
        {
            queue[tail] = element;
            if(tail==MAX)
            {
                tail = 1;
            }
            else
            {
                tail++;
            }
        }
    }
    public T Dequeue()
    {
        if (head > MAX || isEmpty())
        {
            Console.WriteLine("Max length of queue!");
            return default;
        }
        else
        {
            T element= queue[head];
            if (head == MAX)
            {
                head = 1;
            }
            else
            {
                head++;
            }
            return element;
        }

    }
    public bool isEmpty()
    {
        if(tail==head)
        {
            return true;
        }
        return false;
    }
 
   
}