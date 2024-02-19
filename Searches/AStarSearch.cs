using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searches
{
    internal class AStarSearch<T> : Search<T>
    {
        private HeuristicType _heuristicType;

        public AStarSearch(HeuristicType heuristic)
        {
            _heuristicType = heuristic;
        }

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

            AStarNode<T> start = (AStarNode<T>)root;
            if (start == null)
            {
                throw new InvalidOperationException("The root node is not an AStarNode.");
            }

            PriorityQueue<AStarNode<T>, int> frontier = new PriorityQueue<AStarNode<T>, int>();
            HashSet<AStarNode<T>> explored = new HashSet<AStarNode<T>>();

            if (Heuristic.TryCalculateHeuristic(_heuristicType, start, value, out int heuristic))
            {
                start.Heuristic = heuristic;
            } else
            {
                result = null;
                Search<T>.HasNotFoundItem?.Invoke(value);
                return false;
            }

            frontier.Enqueue(start, start.TotalCost);

            while(frontier.Count > 0)
            {
                AStarNode<T> current = frontier.Dequeue();

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
                    foreach (AStarNode<T> child in current.Children)
                    {
                        if (!explored.Contains(child))
                        {
                            if (Heuristic.TryCalculateHeuristic(_heuristicType, child, value, out int h))
                            {
                                child.Heuristic = h;
                                frontier.Enqueue(child, child.TotalCost);
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                }
            }

            result = null;
            Search<T>.HasNotFoundItem?.Invoke(value);
            return false;
        }
    }
}
