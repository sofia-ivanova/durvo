using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf_zad4
{
    internal class SimplePriorityQueue
    {
        private List<(int Node, int Priority)> elements = new List<(int, int)>();

        public int Count => elements.Count;

        public void Enqueue(int item, int priority)
        {
            elements.Add((item, priority));
        }

        public int Dequeue()
        {
            int bestIndex = 0;
            for (int i = 1; i < elements.Count; i++)
            {
                if (elements[i].Priority < elements[bestIndex].Priority)
                {
                    bestIndex = i;
                }
            }
            int bestItem = elements[bestIndex].Node;
            elements.RemoveAt(bestIndex);
            return bestItem;
        }
    }
}
