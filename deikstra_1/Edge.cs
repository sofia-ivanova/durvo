using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deikstra_1
{
    internal class Edge
    {
        public int To;
        public int Weight;

        public Edge(int to, int weight)
        {
            To = to;
            Weight = weight;
        }
    }
}
