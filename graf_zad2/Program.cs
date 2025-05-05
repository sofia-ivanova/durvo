using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf_zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfVertices = 5;
            Graph g = new Graph(numberOfVertices);
            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 3);
            g.AddEdge(2, 3);
            g.AddEdge(3, 4);
            int start = 0;
            int target = 4;
            int steps = g.FindShortestPath(start, target);
            if (steps != -1)
                Console.WriteLine($"Най-краткият път от {start} до {target} е {steps} стъпки.");
            else
                Console.WriteLine("Няма път между върховете.");
            Console.ReadKey();
        }
    }
}
