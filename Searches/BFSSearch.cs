using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searches
{
    internal class BFSSearch<T> : Search<T> 
    {
        public bool TryFind(Node<T> root, T value, out Node<T>? result)
        {
            if (root == null)
            {
                throw new ArgumentNullException(nameof(root));
            }

            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Queue<Node<T>> frontier = new Queue<Node<T>>();
            HashSet<Node<T>> explored = new HashSet<Node<T>>();

            frontier.Enqueue(root);

            while (frontier.Count > 0)
            {
                Node<T> current = frontier.Dequeue();

                if (current == null)
                {
                    continue;
                }

                if (current.Value != null)
                {
                    if (current.Value.Equals(value))
                    {
                        result = current;
                        Search<T>.HasFoundItem?.Invoke(result);
                        return true;
                    }
                }

                Search<T>.HasVisitedNode?.Invoke(current);
                explored.Add(current);

                if (current.Children != null)
                {
                    foreach (Node<T> child in current.Children)
                    {
                        if (!explored.Contains(child))
                        {
                            frontier.Enqueue(child);
                        }
                    }
                }
            }

            Search<T>.HasNotFoundItem?.Invoke(value);
            result = null;
            return false;
        }
    }   
}
