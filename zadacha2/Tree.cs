using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    internal class Tree
    {
        public Node Root;
        public Tree()
        {
            Root = null;
        }
        public void Insert(int value)
        {
            Root = InsertRec(Root, value);
        }
        private Node InsertRec(Node node, int value)
        {
            if (node == null)
                return new Node(value);
            if (value < node.Value)
                node.Left = InsertRec(node.Left, value);
            else if (value > node.Value)
                node.Right = InsertRec(node.Right, value);
            return node;
        }
        public bool Search(int target)
        {
            return SearchRec(Root, target);
        }
        private bool SearchRec(Node node, int target)
        {
            if (node == null)
                return false;
            if (target == node.Value)
                return true;
            else if (target < node.Value)
                return SearchRec(node.Left, target);
            else
                return SearchRec(node.Right, target);
        }
    }
}
