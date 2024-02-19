using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Searches
{
    internal class AStarNode<T> : Node<T>
    {
        public int Cost { get; }
        public int? Heuristic { get; set; }
        public int TotalCost {
            get 
            {
                if (Heuristic.HasValue)
                {
                    return Cost + Heuristic.Value;
                }
                else
                {
                    throw new InvalidOperationException("Heuristic has not been set.");
                }
            } 
        }

        public AStarNode(Node<T> node, int cost, int? heuristic = null) : base(node.Value)
        {
            Cost = cost;

            if (heuristic.HasValue)
            {
                Heuristic = heuristic;
            }
        }

        public AStarNode(T value, int cost, int? heuristic = null) : base(value)
        {
            Cost = cost;

            if (heuristic.HasValue)
            {
                Heuristic = heuristic;
            }
        }
    }
}
