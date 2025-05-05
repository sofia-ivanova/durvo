using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace durvo
{
    internal class BinaryTree
    {
        public Node Root;
        public BinaryTree()
        {
            Root = null;
        }
        public int Height(Node node)
        {
            if (node == null)
                return -1; 
            int leftHeight = Height(node.Left);
            int rightHeight = Height(node.Right);
            return Math.Max(leftHeight, rightHeight) + 1;
        }
    }
}
