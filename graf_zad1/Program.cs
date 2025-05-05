using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf_zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Graph g = new Graph(5);
            g.AddEdge(0, 1);
            g.AddEdge(0, 4);
            g.AddEdge(1, 2);
            g.AddEdge(1, 3);
            g.AddEdge(1, 4);
            g.AddEdge(2, 3);
            g.AddEdge(3, 4);
            Console.WriteLine("Граф преди премахване на ребро 1-4:");
            g.PrintGraph();
            g.RemoveEdge(1, 4);
            Console.WriteLine("Граф след премахване на ребро 1-4:");
            g.PrintGraph();
            Console.ReadKey();
        }
    }
}
