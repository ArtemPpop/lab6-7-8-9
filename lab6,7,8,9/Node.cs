using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6_7_8_9
{
     class Node<T>
    {
        public Node(T data)
        {
            Data = data;
            Next = null;
        }
        public T Data { get; set; }
        public Node<T> Next { get; set; }
    }
}
