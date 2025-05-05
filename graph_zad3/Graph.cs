using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph_zad3
{
    internal class Graph
    {
        private int vertices;
        private List<int>[] adjList;
        public Graph(int n)
        {
            vertices = n;
            adjList = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                adjList[i] = new List<int>();
            }
        }
        public void AddEdge(int u, int v)
        {
            adjList[u].Add(v);
            adjList[v].Add(u);
        }
        public bool DFS(int start, int end)
        {
            bool[] visited = new bool[vertices];
            return DFSUtil(start, end, visited);
        }
        private bool DFSUtil(int current, int target, bool[] visited)
        {
            if (current == target)
                return true;

            visited[current] = true;

            foreach (int neighbor in adjList[current])
            {
                if (!visited[neighbor])
                {
                    if (DFSUtil(neighbor, target, visited))
                        return true;
                }
            }
            return false;
        }
    }
}
