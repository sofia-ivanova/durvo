﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha4
{
    internal class Node
    {
        public int Value;
        public Node Left, Right;
        public Node(int value)
        {
            Value = value;
            Left = Right = null;
        }
    }
}
