using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searches
{
    internal enum HeuristicType
    {
        BFS
    }

    internal static class Heuristic
    {
        public static bool TryCalculateHeuristic<T>(HeuristicType type, AStarNode<T> node, T value, out int num)
        {
            switch (type)
            {
                case HeuristicType.BFS:
                    return BFSDistance(node, value, out num);
                default:
                    throw new InvalidOperationException("Heuristic type not supported.");
            }
        }

        private static bool BFSDistance<T>(AStarNode<T> node, T value, out int num)
        {
            if (node == null)
            {
                throw new ArgumentNullException(nameof(node));
            }

            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Queue<(AStarNode<T> Node, int Distance)> frontier = new Queue<(AStarNode<T>, int)>();
            frontier.Enqueue((node, 0));

            HashSet<AStarNode<T>> explored = new HashSet<AStarNode<T>>();

            while (frontier.Count > 0)
            {
                (AStarNode<T> current, int distance) = frontier.Dequeue();

                if (current == null)
                {
                    continue;
                }

                if (current.Value != null)
                {
                    if (current.Value.Equals(value))
                    {
                        num = distance;
                        return true;
                    }
                }

                explored.Add(current);

                if (current.Children != null)
                {
                    foreach (AStarNode<T> child in current.Children)
                    {
                        if (!explored.Contains(child))
                        {
                            frontier.Enqueue((child, distance + child.Cost));
                        }
                    }
                }
            }

            num = -1;
            return false;
        }
    }
}
