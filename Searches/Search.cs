using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searches
{
    internal interface Search<T>
    {
        public static Action<Node<T>>? HasFoundItem;
        public static Action<T>? HasNotFoundItem;
        public static Action<Node<T>>? HasVisitedNode;
        public bool TryFind(Node<T> root, T value, out Node<T>? result);
    }
}
