MyLinkedList<string> list = new MyLinkedList<string>();
list.AddFirst("Honda");
list.AddFirst("Civic");
list.AddFirst("2024");
list.PrintAll();



public class MyLinkedList<T>
{
    private class Node
    {
        public Node? next;
        public T data;
    }

    private Node head;

    public void PrintAll()
    {
        Node current = head;
        while(current != null)
        {
            Console.WriteLine(current.data);
            current = current.next;
        }
    }
    public void AddFirst(T data)
    {
        Node element= new Node();
        element.data = data;
        element.next = head;

        head = element;
    }
 

}
