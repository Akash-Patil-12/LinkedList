using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructure
{
    public class NodeGeneric<T>
    {
        public T data;
        public NodeGeneric<T> next;
        public NodeGeneric(T value)
        {
            data = value;
            next = null;
        }
    }
}
