using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Root = new Node(50);
            bst.Root.Left = new Node(30);
            bst.Root.Right = new Node(70);
            bst.Root.Left.Left = new Node(20);
            bst.Root.Left.Right = new Node(40);
            bst.Root.Right.Left = new Node(60);
            bst.Root.Right.Right = new Node(80);
            bst.Root.Right.Left.Left = new Node(55);
            bst.Root.Right.Left.Right = new Node(65);
            int x = 55;
            int floor = bst.FindFloor(bst.Root, x);
            Console.WriteLine($"Подът на {x} е: {floor}");
            Console.ReadKey();
        }
    }
}
