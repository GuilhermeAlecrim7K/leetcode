namespace SharpLeetCode.Problems.Easy;

public class Leet00083RemoveDuplicatesFromSortedList
{
    public class ListNode(int val = 0, ListNode? next = null)
    {
        public int val = val;
        public ListNode? next = next;
    }

    public ListNode? DeleteDuplicates(ListNode head)
    {
        if (head is null)
            return head;
        var cur = head;
        while (cur is not null)
        {
            if (cur.next is null)
                break;
            while (cur.next?.val == cur.val)
            {
                cur.next = cur.next.next;
            }
            cur = cur.next;
        }
        return head;
    }
}