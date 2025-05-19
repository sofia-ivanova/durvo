using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf_zad4
{
    internal class PackageBST
    {
        private PackageNode root;
        public void Insert(Package data)
        {
            root = Insert(root, data);
        }
        private PackageNode Insert(PackageNode node, Package data)
        {
            if (node == null) return new PackageNode(data);
            if (data.Id < node.Data.Id)
                node.Left = Insert(node.Left, data);
            else if (data.Id > node.Data.Id)
                node.Right = Insert(node.Right, data);
            return node;
        }
        public Package Search(int id)
        {
            return Search(root, id);
        }
        private Package Search(PackageNode node, int id)
        {
            if (node == null) return null;
            if (id == node.Data.Id) return node.Data;
            if (id < node.Data.Id) return Search(node.Left, id);
            return Search(node.Right, id);
        }
        public void InOrderTraversal()
        {
            InOrderTraversal(root);
        }
        private void InOrderTraversal(PackageNode node)
        {
            if (node == null) return;
            InOrderTraversal(node.Left);
            Console.WriteLine(node.Data);
            InOrderTraversal(node.Right);
        }
        public void FilterByDistance(int minDistance)
        {
            FilterByDistance(root, minDistance);
        }
        private void FilterByDistance(PackageNode node, int minDistance)
        {
            if (node == null) return;
            FilterByDistance(node.Left, minDistance);
            if (node.Data.Distance > minDistance)
                Console.WriteLine(node.Data);
            FilterByDistance(node.Right, minDistance);
        }
    }
}
