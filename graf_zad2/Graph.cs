using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf_zad2
{
    internal class Graph
    {
        private int vertices;
        private List<int>[] adjList;
        public Graph(int v)
        {
            vertices = v;
            adjList = new List<int>[v];

            for (int i = 0; i < v; i++)
            {
                adjList[i] = new List<int>();
            }
        }
        public void AddEdge(int u, int v)
        {
            adjList[u].Add(v);
            adjList[v].Add(u);
        }
        public int FindShortestPath(int start, int target)
        {
            bool[] visited = new bool[vertices];
            int[] distance = new int[vertices];
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(start);
            visited[start] = true;
            distance[start] = 0;
            while (queue.Count > 0)
            {
                int current = queue.Dequeue();
                foreach (int neighbor in adjList[current])
                {
                    if (!visited[neighbor])
                    {
                        visited[neighbor] = true;
                        distance[neighbor] = distance[current] + 1;
                        queue.Enqueue(neighbor);
                        if (neighbor == target)
                            return distance[neighbor];
                    }
                }
            }
            return -1;
        }
    }
}
