using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace graf_zad4
{
    internal class Package
    {
        public int Id;
        public string StartCity;
        public string EndCity;
        public int Distance;

        public Package(int id, string start, string end, int distance)
        {
            Id = id;
            StartCity = start;
            EndCity = end;
            Distance = distance;
        }

        public override string ToString()
        {
            return $"Пратка #{Id}: {StartCity} -> {EndCity}, Разстояние: {Distance} км";
        }
    }
}
