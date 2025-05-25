using graf_zad4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deikstra_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var graph = new Dictionary<int, List<Edge>>
            {
                { 0, new List<Edge> { new Edge(1, 2), new Edge(2, 4) } },
                { 1, new List<Edge> { new Edge(2, 1), new Edge(3, 7) } },
                { 2, new List<Edge> { new Edge(3, 3) } },
                { 3, new List<Edge>() }
            };
            Dijkstra(graph, 0);
            Console.ReadKey();
        }
        static void Dijkstra(Dictionary<int, List<Edge>> graph, int start)
        {
            var distances = new Dictionary<int, int>();
            var visited = new HashSet<int>();
            var pq = new SimplePriorityQueue();

            foreach (var vertex in graph.Keys)
                distances[vertex] = int.MaxValue;

            distances[start] = 0;
            pq.Enqueue(start, 0);

            while (pq.Count > 0)
            {
                int current = pq.Dequeue();

                if (visited.Contains(current))
                    continue;

                visited.Add(current);

                foreach (var edge in graph[current])
                {
                    int neighbor = edge.To;
                    int newDist = distances[current] + edge.Weight;

                    if (newDist < distances[neighbor])
                    {
                        distances[neighbor] = newDist;
                        pq.Enqueue(neighbor, newDist);
                    }
                }
            }

            foreach (var pair in distances)
            {
                Console.WriteLine($"Разстояние от {start} до {pair.Key}: {pair.Value}");
            }
        }
    }
}
