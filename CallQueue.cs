using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._3._1
{
    public class CallQueue
    {
        private readonly LinkedList<Customer> list = new();

        public int Count => list.Count;
        public bool IsEmpty => list.Count == 0;

        internal void Enqueue(Customer customer)
        {
            if (customer == null) throw new ArgumentNullException(nameof(customer));
            list.AddLast(customer); // Add to tail
        }

        internal Customer? Peek()
        {
            return list.First?.Value; // Look at head; null if empty
        }

        internal Customer? Dequeue()
        {
            if (list.First is null) return null; // Empty
            var value = list.First.Value;
            list.RemoveFirst(); // Remove head
            return value;
        }

        // Optional: get snapshot for displaying in UI
        internal IEnumerable<Customer> GetSnapshot()
        {
            foreach (var customer in list)
            {
                yield return customer;
            }
        }
    }
}
