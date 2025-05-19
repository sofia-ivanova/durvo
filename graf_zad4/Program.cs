using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf_zad4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bst = new PackageBST();
            var graph = new Graph();
            while (true)
            {
                Console.WriteLine("\n=== Меню ===");
                Console.WriteLine("1. Добави пратка");
                Console.WriteLine("2. Намери пратка по номер");
                Console.WriteLine("3. Покажи всички пратки");
                Console.WriteLine("4. Добави път между два града");
                Console.WriteLine("5. Изчисли най-кратък маршрут между два града");
                Console.WriteLine("6. Покажи пратки с дължина над ...");
                Console.WriteLine("7. Изход");
                Console.Write("Избор: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Номер на пратката: ");
                        int id = int.Parse(Console.ReadLine());
                        Console.Write("Начален град: ");
                        string start = Console.ReadLine();
                        Console.Write("Краен град: ");
                        string end = Console.ReadLine();

                        int distance = graph.Dijkstra(start, end);
                        if (distance == -1)
                            Console.WriteLine("Няма маршрут между тези градове.");
                        else
                        {
                            var pkg = new Package(id, start, end, distance);
                            bst.Insert(pkg);
                            Console.WriteLine("Пратката е добавена.");
                        }
                        break;

                    case "2":
                        Console.Write("Въведи номер на пратка: ");
                        int searchId = int.Parse(Console.ReadLine());
                        var found = bst.Search(searchId);
                        Console.WriteLine(found != null ? found.ToString() : "Пратката не е намерена.");
                        break;

                    case "3":
                        bst.InOrderTraversal();
                        break;

                    case "4":
                        Console.Write("Град 1: ");
                        string city1 = Console.ReadLine();
                        Console.Write("Град 2: ");
                        string city2 = Console.ReadLine();
                        Console.Write("Разстояние (км): ");
                        int dist = int.Parse(Console.ReadLine());
                        graph.AddEdge(city1, city2, dist);
                        Console.WriteLine("Пътят е добавен.");
                        break;

                    case "5":
                        Console.Write("Начален град: ");
                        string from = Console.ReadLine();
                        Console.Write("Краен град: ");
                        string to = Console.ReadLine();
                        int result = graph.Dijkstra(from, to);
                        Console.WriteLine(result == -1 ? "Няма маршрут." : $"Разстояние: {result} км");
                        break;

                    case "6":
                        Console.Write("Минимална дължина (км): ");
                        int minDist = int.Parse(Console.ReadLine());
                        bst.FilterByDistance(minDist);
                        break;

                    case "7":
                        return;

                    default:
                        Console.WriteLine("Невалиден избор.");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
