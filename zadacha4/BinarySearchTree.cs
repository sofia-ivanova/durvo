using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    internal class BinarySearchTree
    {
        public Node Root;
        public BinarySearchTree()
        {
            Root = null;
        }
        public void InOrder(Node node, List<int> result)
        {
            if (node != null)
            {
                InOrder(node.Left, result);
                result.Add(node.Value);
                InOrder(node.Right, result);
            }
        }
        public int FindMinInOrder()
        {
            List<int> sorted = new List<int>();
            InOrder(Root, sorted);
            if (sorted.Count > 0)
                return sorted[0];
            else
                return -1;
        }
    }
}
