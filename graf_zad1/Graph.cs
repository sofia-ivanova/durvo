using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf_zad1
{
    internal class Graph
    {
        private int vertices; // брой върхове
        private List<int>[] adjList;
        public Graph(int v)
        {
            vertices = v;
            adjList = new List<int>[vertices];
            for (int i = 0; i < vertices; i++)
            {
                adjList[i] = new List<int>();
            }
        }
        public void AddEdge(int u, int v)
        {
            adjList[u].Add(v);
            adjList[v].Add(u);
        }
        public void RemoveEdge(int u, int v)
        {
            adjList[u].Remove(v);
            adjList[v].Remove(u); 
        }
        public void PrintGraph()
        {
            for (int i = 0; i < vertices; i++)
            {
                Console.Write($"Връх {i}: ");
                foreach (int neighbor in adjList[i])
                {
                    Console.Write(neighbor + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
