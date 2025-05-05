using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            int[] values = { 50, 30, 70, 20, 40, 60, 80 };
            foreach (int val in values)
                tree.Insert(val);
            Console.WriteLine("Обход по ред на дървото:");
            tree.InOrder(tree.Root);
            Console.ReadKey();
        }
    }
}
