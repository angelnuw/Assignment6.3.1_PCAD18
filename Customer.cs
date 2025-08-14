using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6._3._1
{
    internal class Customer
    {
        public string PhoneNumber { get; set; }
        public DateTime EnqueueTime { get; private set; }
        public string Name { get; set; }

        public Customer(string phoneNumber, string name)
        {
            PhoneNumber = phoneNumber;
            Name = name;
            EnqueueTime = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Name} ({PhoneNumber}) - Enqueued at {EnqueueTime:t}";
        }
    }
}
