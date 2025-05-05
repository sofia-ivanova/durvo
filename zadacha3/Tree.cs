using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3
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
            {
                return new Node(value);
            }
            if (value < node.Value)
            {
                node.Left = InsertRec(node.Left, value);
            }
            else if (value > node.Value)
            {
                node.Right = InsertRec(node.Right, value);
            }
            return node;
        }
        public void InOrder(Node node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                Console.Write(node.Value + " ");
                InOrder(node.Right);
            }
        }
    }
}
