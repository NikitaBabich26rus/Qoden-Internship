using System.Collections.Generic;

namespace task1
{
    public class HashTable
    {
        private readonly long _size;

        private ListNode[] _values;

        public IEnumerable<ListNode> Values
        {
            get => _values;
        }

        public HashTable(int size)
        {
            _size = size;
            _values = new ListNode[size];
        }

        public void Insert(long newValue) 
        {
            var hashCode = GetHashCode(newValue);

            if (_values[hashCode] == null)
            {
                _values[hashCode] = new ListNode(newValue);
                return;
            }

            _values[hashCode].Insert(newValue);
        }

        private long GetHashCode(long value)
           => value % _size;
    }
}
