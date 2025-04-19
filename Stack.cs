MyStack<string> stack = new MyStack<string>();

stack.Push("Banana");
stack.Push("Orange");
stack.Push("Blueberry");
stack.Push("Coconut");
stack.Print();
stack.Peek();
Console.WriteLine($"Item popped from Stack : {stack.Pop()}");
stack.Print();


public class MyStack<T>
{
    private const int MAX = 100;
    private int top;
    private T[]stack= new T[MAX];
   public bool isEmpty()
    {
        if(top<0)
        {
            return true;
        }
        return false;
    }
    public MyStack()
    {
        top = -1;
    }
    public bool Push(T data)
    {
        if (top>=MAX)
        {
            Console.WriteLine("Max Length of stack");
            return false;
        }
        else
        {
            top++;
            stack[top] = data;
            return true;
        }
    }
    public T Pop()
    {
        if(top<0)
        {
            Console.WriteLine("No items in stack");
            return default;
        }
        else
        {
            T value= stack[top];
            top--;
            return value;
        }
    }
    public void Peek()
    {
        if (top < 0)
        {
            Console.WriteLine("No items in stack");
            return;
        }
        else
        {
            Console.WriteLine($"The top element in the stack is {stack[top]}");
        }
    }
    public void Print()
    {
        if (top < 0)
        {
            Console.WriteLine("No items in stack");
            return;
        }
        else
        {
            Console.WriteLine("The items in the stack");
            for(int i=top;i>=0;i--)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }


}