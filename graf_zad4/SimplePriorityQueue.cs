using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf_zad4
{
    internal class SimplePriorityQueue
    {
        private List<(string, int)> elements = new List<(string, int)>();
        public int Count => elements.Count;
        public void Enqueue(string item, int priority)
        {
            elements.Add((item, priority));
        }
        public string Dequeue()
        {
            int bestIndex = 0;
            for (int i = 1; i < elements.Count; i++)
            {
                if (elements[i].Item2 < elements[bestIndex].Item2)
                {
                    bestIndex = i;
                }
            }
            string bestItem = elements[bestIndex].Item1;
            elements.RemoveAt(bestIndex);
            return bestItem;
        }
    }
}
