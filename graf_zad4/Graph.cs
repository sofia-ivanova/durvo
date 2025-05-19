using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf_zad4
{
    internal class Graph
    {
        public Dictionary<string, List<(string, int)>> AdjacencyList = new Dictionary<string, List<(string, int)>>();
        public void AddEdge(string city1, string city2, int distance)
        {
            if (!AdjacencyList.ContainsKey(city1))
                AdjacencyList[city1] = new List<(string, int)>();
            if (!AdjacencyList.ContainsKey(city2))
                AdjacencyList[city2] = new List<(string, int)>();

            AdjacencyList[city1].Add((city2, distance));
            AdjacencyList[city2].Add((city1, distance));
        }
        public int Dijkstra(string start, string end)
        {
            var distances = new Dictionary<string, int>();
            var visited = new HashSet<string>();
            var pq = new SimplePriorityQueue();

            foreach (var city in AdjacencyList.Keys)
                distances[city] = int.MaxValue;

            distances[start] = 0;
            pq.Enqueue(start, 0);

            while (pq.Count > 0)
            {
                var current = pq.Dequeue();
                if (visited.Contains(current)) continue;
                visited.Add(current);

                foreach (var neighbor in AdjacencyList[current])
                {
                    int newDist = distances[current] + neighbor.Item2;
                    if (newDist < distances[neighbor.Item1])
                    {
                        distances[neighbor.Item1] = newDist;
                        pq.Enqueue(neighbor.Item1, newDist);
                    }
                }
            }

            return distances.ContainsKey(end) ? distances[end] : -1;
        }
    }
}
