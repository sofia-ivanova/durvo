using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5
{
    internal class BinarySearchTree
    {
        public Node Root;
        public BinarySearchTree()
        {
            Root = null;
        }
        public int FindFloor(Node node, int x)
        {
            if (node == null)
                return -1;
            if (node.Value == x)
                return node.Value;
            if (node.Value > x)
                return FindFloor(node.Left, x);
            int floorInRight = FindFloor(node.Right, x);
            if (floorInRight <= x && floorInRight != -1)
                return floorInRight;
            else
                return node.Value;
        }
    }
}
