using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf_zad4
{
    internal class PackageNode
    {
        public Package Data;
        public PackageNode Left, Right;

        public PackageNode(Package data)
        {
            Data = data;
            Left = Right = null;
        }
    }
}
