using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graph_zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 5;
            Graph g = new Graph(n);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(2, 3);
            int start = 0;
            int end = 3;
            bool pathExists = g.DFS(start, end);
            Console.WriteLine(pathExists ? "Да" : "Не");
            Console.ReadKey();
        }
    }
}
