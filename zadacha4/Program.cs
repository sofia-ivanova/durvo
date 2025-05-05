using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Root = new Node(5);
            bst.Root.Left = new Node(4);
            bst.Root.Right = new Node(6);
            bst.Root.Left.Left = new Node(3);
            bst.Root.Left.Right = new Node(7);
            bst.Root.Left.Left.Left = new Node(1);
            Console.WriteLine("Минималната стойност чрез обход по ред: " + bst.FindMinInOrder());
            Console.ReadKey();
        }
    }
}
