using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            int[] elements = { 50, 30, 70, 20, 40, 60, 80 };
            foreach (int el in elements)
                tree.Insert(el);
            int numberToFind = 60;
            bool exists = tree.Search(numberToFind);
            Console.WriteLine($"Числото {numberToFind} {(exists ? "съществува" : "не съществува")} в дървото.");
            Console.ReadKey();
        }
    }
}
