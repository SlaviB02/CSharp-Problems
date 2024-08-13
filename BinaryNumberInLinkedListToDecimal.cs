

int GetDecimalValue(ListNode head)
{
    string bitNumber = "";
    while(head != null)
    {
        bitNumber += head.val;
        head = head.next;
    }

    int res=Convert.ToInt32(bitNumber,2);

    return res;
}
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}