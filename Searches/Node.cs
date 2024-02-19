using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searches
{
    internal class Node<T>
    {
        public T Value { get; }
        public List<Node<T>>? Children { get; set; }
        public Node(T value)
        {
            Value = value;
        }

        public void AddChild(Node<T> child)
        {
            if (Children == null)
            {
                Children = new List<Node<T>>();
            }

            Children.Add(child);
        }
    }
}
