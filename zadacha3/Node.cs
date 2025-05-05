using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3
{
    internal class Node
    {
        public int Value;
        public Node Left;
        public Node Right;
        public Node(int value)
        {
            Value = value;
            Left = null;
            Right = null;
        }
    }
}
