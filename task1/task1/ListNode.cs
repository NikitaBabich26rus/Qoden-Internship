using System;

namespace task1
{
    public class ListNode
    {
        private readonly long _value;

        private ListNode _next;

        public ListNode(long value)
            => _value = value;

        public long Value
        {
            get => _value;
        }

        public ListNode Next
        {
            get => _next;
        }

        public void Insert(long newValue)
        {
            var currentNode = this;

            while (currentNode._next != null)
            {
                currentNode = currentNode._next;
            }

            currentNode._next = new ListNode(newValue);
        }
    }
}
